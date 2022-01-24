using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticketsMvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EticketsMvc.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDBcontext _context;
        public ProducersController(AppDBcontext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}