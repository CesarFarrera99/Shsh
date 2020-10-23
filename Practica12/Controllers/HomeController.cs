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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string numero1,string numero2,string tipo)
        {
            double a= Convert.ToDouble(numero1);
            double b= Convert.ToDouble(numero2);
            double c= 0;
            if (tipo=="Suma")
            {
                c=a+b;
                ViewBag.Result = c;
            } else if(tipo=="Resta")
            {
                c=a-b;
                ViewBag.Result = c;
            } else if(tipo=="Multiplicacion")
            {
                c=a*b;
                ViewBag.Result = c;
            } else if(tipo=="Division")
            {
                c=a/b;
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
