using Reportes_de_Victor;
using System.Collections.Generic;

namespace Prestamos.Domain
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Garantia { get; set; }
        public decimal SueldoMensual { get; set; }

        public virtual ICollection<Prestamo> Prestamos { get; set; }
    }
}

