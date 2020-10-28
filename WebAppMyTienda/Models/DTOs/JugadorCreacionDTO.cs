using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMyTienda.Models.DTOs
{
    public class JugadorCreacionDTO
    {

        [Display(Name = "Nombre Jugador")]
        [Required(ErrorMessage = "EL campo {0} es requerido")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener como longitud máxima {1} caracteres.")]

        public string Nombre { get; set; }
        //public int Anio { get; set; }
        //[StringLength(500, ErrorMessage = "El campo {0} debe tener como longitud máxima {1} caracteres.")]
        public DateTime FechaNacimiento { get; set; }
        [StringLength(500, ErrorMessage = "El campo {0} debe tener como longitud máxima {1} caracteres.")]
        public string Sinopsis { get; set; }
        public string Trailer { get; set; }
        public string PostUrl { get; set; }
        //public string Fotografia { get; set; }
        public string Biografia { get; set; }


    }
}
