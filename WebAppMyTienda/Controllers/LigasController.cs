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
    }
}
