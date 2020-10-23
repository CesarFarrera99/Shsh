using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica12.Models;

namespace Practica12.Controllers
{
    public class AreaController : Controller
    {
        private readonly ILogger<AreaController> _logger;

        public AreaController(ILogger<AreaController> logger)
        {
            _logger = logger;
        }

        public IActionResult CalArea()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalArea(string num1,string num2,string tipo)
        {
            double a= Convert.ToDouble(num1);
            double b= Convert.ToDouble(num2);
            double c= 0;
            if (tipo=="Triangulo")
            {
                c=a*b;  c=c/2;
                ViewBag.Result = c;
            } else if(tipo=="Rectangulo")
            {
                c=a*b;
                ViewBag.Result = c;
            } else
            {
                ViewBag.Result = c;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
