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
    public class Products : Controller
    {

        private readonly AppDbContext _context;

        public Products(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Products.Include("Category").ToList();
            return View(products);
            
        }
    }
}
