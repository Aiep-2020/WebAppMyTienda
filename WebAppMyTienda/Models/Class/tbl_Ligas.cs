using System.ComponentModel.DataAnnotations;

namespace WebAppMyTienda.Models.Class
{
    public class tbl_Ligas
    {
        [Key]
        public int idliga       { get; set; }
        public string  NombreLigas  { get; set; }
    }
}
