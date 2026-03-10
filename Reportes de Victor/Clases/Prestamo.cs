using System;
using System.Collections.Generic;

namespace Prestamos.Domain
{
    public class Prestamo
    {
        public int PrestamoId { get; set; }
        public int ClienteId { get; set; }
        public decimal Monto { get; set; }
        public int PlazoMeses { get; set; }
        public decimal TasaInteresAnual { get; set; }
        public decimal CuotaMensual { get; set; }
        public decimal InteresGenerado { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal SaldoActual { get; set; }
        public int CantidadMoras { get; set; }
        public bool EsMoroso { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Pago> Pagos { get; set; }
    }
}
