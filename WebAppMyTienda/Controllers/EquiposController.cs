using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppMyTienda.Models.Class;
using WebAppMyTienda.Models.DTOs;

namespace WebAppMyTienda.Controllers
{
    public class EquiposController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public EquiposController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            List<tbl_Equipo> ListEquipos = await _context.tbl_Equipos.ToListAsync();
            List<tbl_EquiposDTO> ListEquiposDto = mapper.Map<List<tbl_EquiposDTO>>(ListEquipos);

            return View(ListEquiposDto);
        }
    }
}
