using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sixteen.Data;
using sixteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen.Controllers
{
    public class About : Controller
    {
        private readonly AppDbContext _context;

        public About(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Teams> Teamses = _context.Teamses.Include("Specality").ToList();
            return View(Teamses);
        }
    }
}
