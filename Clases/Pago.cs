using System;

namespace Prestamos.Domain
{
    public class Pago
    {
        public int PagoId { get; set; }
        public int PrestamoId { get; set; }
        public int NumeroMes { get; set; }
        public decimal MontoAnterior { get; set; }
        public decimal InteresAPagar { get; set; }
        public decimal NuevoMontoDeber { get; set; }
        public decimal Cuota { get; set; }
        public int MesesRestantes { get; set; }
        public decimal TotalAcumuladoIntereses { get; set; }
        public decimal TasaPrestamo { get; set; }
        public decimal Mora { get; set; }
        public bool Pagado { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual Prestamo Prestamo { get; set; }
    }
}
