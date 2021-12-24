using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorYapsi.Data.Modelos
{
    public class Movimiento
    {
        public int Id { get; set; }
        public int IdSocio { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int IdTipoMovimiento { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal Cantidad { get; set; }
        public Socio Socio { get; set; }
    }
}
