using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMyTienda.Models.Class;
using WebAppMyTienda.Models.DTOs;

namespace WebAppMyTienda.Helpers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            // Mapeando  Ligas desde ligas a ligasDTO. => Dirigirse luego a controlador de LigasController para utilizar.
            CreateMap<tbl_Ligas, tbl_ligasDTO>();

        }
    }
}
