using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMyTienda.Models.DTOs
{
    public class tbl_ligasCreacionDTO
    {

        [Display(Name = "Nombre Liga")]
        [Required(ErrorMessage = "Descripción es requerido")]
        [StringLength(20, ErrorMessage = "Longitud máxima {1}")]
        [MinLength(3, ErrorMessage = "Longitud minima {1}")]
        public string NombreLigas { get; set; }
    }
}
