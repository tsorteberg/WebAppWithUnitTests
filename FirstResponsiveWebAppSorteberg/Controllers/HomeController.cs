/***************************************************************
* Name        : HomeController.cs
* Author      : Tom Sorteberg
* Created     : 01/28/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This controller class file represents the controller for an 
*               MVC ASP.NET Core Web Application, which has been prepared
*               for the First Responsive Web App assignment.  Input is passed
*               from the view into ViewBag containers, which are then used to
*               call methods from the FRWAModel class.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppSorteberg.Models;

namespace FirstResponsiveWebAppSorteberg.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FRWAModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = model.AgeThisYear();
            }
            else
            {
                ViewBag.Age = 0;
            }

            return View(model);
        }
    }
}
