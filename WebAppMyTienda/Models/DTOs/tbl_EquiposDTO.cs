using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMyTienda.Models.DTOs
{
    public class tbl_EquiposDTO
    {

        [Key]
        public int idEquipo { get; set; }

        [Display(Name = "Nombre Equipo")]
        [Required(ErrorMessage = "Descripción es requerido")]
        [StringLength(20, ErrorMessage = "Longitud máxima {1}")]
        [MinLength(3, ErrorMessage = "Longitud minima {1}")]
        public string NombreEquipo { get; set; }

        public DateTime FechaFundc { get; set; }
        public string Fotografia { get; set; }
    }
}
