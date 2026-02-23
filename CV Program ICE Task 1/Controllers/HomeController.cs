using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CV_Program_ICE_Task_1.Models;

namespace CV_Program_ICE_Task_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Redirect Home page to your CV page
            return RedirectToAction("Index", "CV");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}