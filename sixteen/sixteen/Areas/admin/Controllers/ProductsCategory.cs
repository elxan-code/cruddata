using Microsoft.AspNetCore.Mvc;
using sixteen.Data;
using sixteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen.Areas.admin.Controllers
{
    [Area("admin")]
    public class ProductsCategory : Controller
    {
        private readonly AppDbContext _context;

        public ProductsCategory(AppDbContext context)
        {
           _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }
     
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_context.Categories.Find(id));
        }
        [HttpPost]
        public IActionResult Update(Category model)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

           

        }
        public IActionResult Delete(int id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Category category = _context.Categories.Find(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }


}
