using System;
using System.Collections.Generic;
using Prestamos.Application.DTOs;
using Prestamos.Domain;

namespace Prestamos.Application.Services
{
    public class PrestamoService
    {
        public decimal ObtenerTasaPorPlazo(int plazoMeses)
        {
            if (plazoMeses <= 12)
                return 0.1325m;
            if (plazoMeses <= 24)
                return 0.15m;
            return 0.30m;
        }

        public void ValidarPrestamo(Cliente cliente, decimal monto, decimal fondoDisponible)
        {
            if (cliente == null)
                throw new Exception("El cliente no existe.");

            if (string.IsNullOrWhiteSpace(cliente.Garantia))
                throw new Exception("No se puede otorgar un prestamo sin garantia.");

            if (monto > cliente.SueldoMensual * 4)
                throw new Exception("El prestamo no puede superar 4 veces el sueldo.");

            if (monto > fondoDisponible)
                throw new Exception("La entidad no puede prestar dinero que no posee.");
        }

        public decimal CalcularCuotaMensual(decimal monto, decimal tasaAnual, int plazoMeses)
        {
            decimal tasaMensual = tasaAnual / 12m;
            double i = (double)tasaMensual;
            double n = plazoMeses;
            double p = (double)monto;

            double cuota = p * (i * Math.Pow(1 + i, n)) / (Math.Pow(1 + i, n) - 1);
            return Math.Round((decimal)cuota, 2);
        }

        public List<AmortizacionItemDto> GenerarTablaAmortizacion(decimal monto, decimal tasaAnual, int plazoMeses)
        {
            var lista = new List<AmortizacionItemDto>();
            decimal tasaMensual = tasaAnual / 12m;
            decimal cuota = CalcularCuotaMensual(monto, tasaAnual, plazoMeses);
            decimal saldo = monto;

            for (int mes = 1; mes <= plazoMeses; mes++)
            {
                decimal interes = Math.Round(saldo * tasaMensual, 2);
                decimal capital = Math.Round(cuota - interes, 2);
                saldo = Math.Round(saldo - capital, 2);

                if (mes == plazoMeses && saldo < 1)
                    saldo = 0;

                lista.Add(new AmortizacionItemDto
                {
                    Mes = mes,
                    Cuota = cuota,
                    Interes = interes,
                    Capital = capital,
                    Saldo = saldo
                });
            }

            return lista;
        }

        public decimal CalcularInteresGenerado(decimal monto, decimal cuota, int plazoMeses)
        {
            return Math.Round((cuota * plazoMeses) - monto, 2);
        }
    }
}
