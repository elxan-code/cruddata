using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController1 : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
