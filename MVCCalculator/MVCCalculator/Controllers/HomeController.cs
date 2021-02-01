using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCalculator.Models;

namespace MVCCalculator.Controllers
{
   
    public class HomeController : Controller
    {
        
        public IActionResult Index(string name)
        {
            Calculator calculator = new Calculator();
            ViewBag.Name = name;
            return View(calculator);
        }
        [HttpPost]
        public IActionResult Index(Calculator calculator)
        {
            if (ModelState.IsValid) 
            {
                calculator.Calculate();
            }

            return View(calculator);
        }
    }
}