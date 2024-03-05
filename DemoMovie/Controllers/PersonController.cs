using Microsoft.AspNetCore.Mvc;
using DemoMovie.Models;

namespace DemoMovie.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Dat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Dat(Person ps)
        {
            string strOutput = "Xin chào" + ps.PersonId + "-" + ps.Fullname + "-" + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
    }
}