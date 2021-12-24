using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIYapsi.Entities
{
    public class Socio
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "El campo {0} es requerido")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Phone]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal SaldoTotal { get; set; }
        
        public List<Movimientos> Movimientos { get; set; }
    }
}
