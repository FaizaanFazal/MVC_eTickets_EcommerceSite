using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticketsMvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EticketsMvc.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDBcontext _context;
        public CinemasController(AppDBcontext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}