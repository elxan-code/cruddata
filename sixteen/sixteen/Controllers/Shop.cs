using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen.Controllers
{
    public class Shop : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Addtocard(int Id)
        {
            CookieOptions options = new CookieOptions()
            {
                Expires=DateTime.Now.AddYears(1)
            };
            string oldData = Request.Cookies["cart"];
            string newData = null;
            int basketCount = 0;
            if (!string.IsNullOrEmpty(oldData))
            {
                List<string> dataList = oldData.Split("-").ToList();

                if (!dataList.Any(c=>c==Id.ToString()))
                {
                    newData = oldData + "-" + Id;
                    basketCount = dataList.Count + 1;
                }
                
                else
                {
                    newData = oldData;
                    basketCount = dataList.Count;
                }
            }
            else
            {
                newData = Id.ToString();
                basketCount = 1;
            }
            Response.Cookies.Append("cart",newData,options);
            TempData["BasketCount"] = basketCount;
            return RedirectToAction("Index", "Products");
        }
    }
}
