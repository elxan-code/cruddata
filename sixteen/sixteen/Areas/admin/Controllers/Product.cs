using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sixteen.Data;
using sixteen.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen.Areas.admin.Controllers
{
    [Area("admin")]
    public class Products : Controller

    {

        private readonly AppDbContext _context;

        public Products(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.Products.Include(c => c.Category).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile.ContentType=="image/jpeg"|| model.ImageFile.ContentType=="image/png")
                {
                    if (model.ImageFile.Length<=3145728)
                    {
                        string fileName =Guid.NewGuid()+model.ImageFile.FileName;
                        string filePath = Path.Combine();
                    }
                    else
                    {
                        ModelState.AddModelError("", "you can only select image");
                        return View(model);
                    }

                }
                else
                {
                    ModelState.AddModelError("", "you can only select image");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
            
        }

    }

}
