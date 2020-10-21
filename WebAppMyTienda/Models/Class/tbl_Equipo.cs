using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppMyTienda.Models.Class
{
    public class tbl_Equipo
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
