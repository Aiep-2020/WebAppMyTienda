using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppMyTienda.Models.Class;

namespace WebAppMyTienda.Controllers
{
    public class LigasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LigasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<tbl_Ligas> ListLigas = await _context.Tbl_Ligas.ToListAsync();
            return View(ListLigas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            tbl_Ligas ListLigas = await _context.Tbl_Ligas.FindAsync(id);
            return View(ListLigas);
        }

        [HttpPost]
  
        public async Task<IActionResult> Create([Bind("idliga,NombreLigas")] tbl_Ligas tbl_Ligas )
        {

            if (ModelState.IsValid) {
                _context.Add(tbl_Ligas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            }

            return View(tbl_Ligas);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            tbl_Ligas ListLigas = await _context.Tbl_Ligas.FindAsync(id);
            return View(ListLigas);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreLigas")] tbl_Ligas tbl_Ligas)
        {
            if (ModelState.IsValid)
            {

                tbl_Ligas.idliga = id;
                _context.Update(tbl_Ligas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(tbl_Ligas);
        }
    }
}
