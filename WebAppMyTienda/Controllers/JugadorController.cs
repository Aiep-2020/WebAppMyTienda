using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMyTienda.Models.Class;
using WebAppMyTienda.Models.DTOs;

namespace WebAppMyTienda.Controllers
{
    public class JugadorController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        public JugadorController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }


        public async Task<IActionResult> Index()
        {
            List<Jugador> oListjugadores = await _context.Jugadores.ToListAsync();

            List<JugadorDTO> oListJugadoresDto = mapper.Map<List<JugadorDTO>>(oListjugadores);

            return View(oListJugadoresDto);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] JugadorCreacionDTO oJugadorIn)
        {

            if (ModelState.IsValid)
            {
                Jugador oJugador = mapper.Map<Jugador>(oJugadorIn);
                _context.Add(oJugador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(oJugadorIn);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Jugador ListJugador = await _context.Jugadores.FindAsync(id);
            JugadorDTO ObjDTO = mapper.Map<JugadorDTO>(ListJugador);
            return View(ObjDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [FromForm] JugadorDTO oJugador)
        {
            if (ModelState.IsValid)
            {
                Jugador objetosJugador = mapper.Map<Jugador>(oJugador);
                objetosJugador.Id = id;
                _context.Update(objetosJugador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oJugador);
        }
    }
}
