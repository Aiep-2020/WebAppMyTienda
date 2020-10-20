using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppMyTienda.Models.Class;
using WebAppMyTienda.Models.DTOs;

namespace WebAppMyTienda.Controllers
{
    public class LigasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public LigasController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            List<tbl_Ligas> ListLigas = await _context.Tbl_Ligas.ToListAsync();

            List<tbl_ligasDTO> ListLigasDto = mapper.Map<List<tbl_ligasDTO>>(ListLigas);

            //List<tbl_ligasDTO> ListLigasDto = new List<tbl_ligasDTO>();

            //foreach(tbl_Ligas item in ListLigas)
            //{
            //    tbl_ligasDTO oTrans = new tbl_ligasDTO();
            //    oTrans.idliga = item.idliga;
            //    oTrans.NombreLigas = item.NombreLigas;
            //    ListLigasDto.Add(oTrans);
            //}

            return View(ListLigasDto);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
  
        public async Task<IActionResult> Create([FromForm] tbl_ligasCreacionDTO tbl_Ligas )
        {

            if (ModelState.IsValid) 
            {
                tbl_Ligas Objetosligas = mapper.Map<tbl_Ligas>(tbl_Ligas);

                _context.Add(Objetosligas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            }

            return View(tbl_Ligas);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            tbl_Ligas ListLigas = await _context.Tbl_Ligas.FindAsync(id);

            tbl_ligasDTO ObjDTO = mapper.Map<tbl_ligasDTO>(ListLigas);


            return View(ObjDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [FromForm] tbl_ligasCreacionDTO tbl_Ligas)
        {
            if (ModelState.IsValid)
            {

                tbl_Ligas Objetosligas = mapper.Map<tbl_Ligas>(tbl_Ligas);
                Objetosligas.idliga = id;

                _context.Update(Objetosligas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(tbl_Ligas);
        }

        [HttpPost]
        public async Task<IActionResult> delete(int id)
        {
            tbl_Ligas ListLigas = await _context.Tbl_Ligas.FindAsync(id);
            _context.Remove(ListLigas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            tbl_Ligas ListLigas = await _context.Tbl_Ligas.FindAsync(id);

            tbl_ligasDTO ObjDTO = mapper.Map<tbl_ligasDTO>(ListLigas);

            return View(ObjDTO);
        }
    }
}
