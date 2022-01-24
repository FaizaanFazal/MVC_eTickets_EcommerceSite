using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticketsMvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EticketsMvc.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDBcontext _context;
        public MoviesController(AppDBcontext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n=>n.Cinema).OrderBy(n=>n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}