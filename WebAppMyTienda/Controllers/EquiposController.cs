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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] tbl_EquiposCreacionDTO otbl_Equipo)
        {
            if (ModelState.IsValid)
            {
                tbl_Equipo ObjetosEquipo = mapper.Map<tbl_Equipo>(otbl_Equipo);
                _context.Add(ObjetosEquipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(otbl_Equipo);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            tbl_Equipo oListEquipo = await _context.tbl_Equipos.FindAsync(id);
            tbl_EquiposDTO ObjDTO = mapper.Map<tbl_EquiposDTO>(oListEquipo);
            return View(ObjDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [FromForm] tbl_EquiposCreacionDTO oEquipo)
        {
            if (ModelState.IsValid)
            {
                tbl_Equipo objetoEquipo = mapper.Map<tbl_Equipo>(oEquipo);
                objetoEquipo.idEquipo = id;

                _context.Update(oEquipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(oEquipo);
        }
    }
}
