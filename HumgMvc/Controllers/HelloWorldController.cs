using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HumgMvc.Controllers
{
    public class HelloWorldController : Controller
    {
        private readonly ILogger<HelloWorldController> _logger;
        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FullName, string Address)
        {
            string strOutput = "Xin chào" + " " + FullName + " " + "đến từ" + " " + Address;
            ViewBag.Message = strOutput;
            return View();
        }
    }
}