using System.ComponentModel.DataAnnotations;

namespace WebAppMyTienda.Models.Class
{
    public class tbl_Ligas
    {
        [Key]
        public int idliga { get; set; }

        [Display(Name = "Nombre Liga")]
        [Required(ErrorMessage = "Descripción es requerido")]
        [StringLength(20, ErrorMessage = "Longitud máxima {1}")]
        [MinLength(3, ErrorMessage = "Longitud minima {1}")]
        public string  NombreLigas  { get; set; }
    }
}
