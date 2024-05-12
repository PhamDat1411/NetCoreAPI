using Microsoft.AspNetCore.Mvc;

namespace DATMVC.Controllers
{
    public class HelloWorldController: Controller
    {
        public IActionResult Dat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Dat(string? FullName, string? Address)
        {
            string? strOutput = "Xin chào" + " " + FullName + " " + "Đến từ " + " " + Address;
            ViewBag.InFo= strOutput;
            return View();
        }
        public string? Welcome()
        {
            return("Tra ve man hinh chinh");
        }
    }
}