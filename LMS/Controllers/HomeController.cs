using LMS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LMS.Services.Classes;
using System.Net;

namespace LMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClassService _classService;
        public HomeController(ILogger<HomeController> logger,IClassService classService)
        {
            _logger = logger;
            _classService = classService;
        }

        public IActionResult Index()
        {
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
        [HttpGet("[controller]/Home")]
        public async Task<IActionResult> getClasses()
        {
            Console.WriteLine("hello");
            
            if (Request.Cookies["token"] == null)
            {
                return new ObjectResult("User not authorized") { StatusCode = (int)HttpStatusCode.Forbidden};
            }
            else
            {
                string tokenvalue = Request.Cookies["token"].ToString();
                List<Class> res = await _classService.GetClasses(tokenvalue);
                ViewBag.Class = res;
                Console.WriteLine(res.Count);
            }

            return View(Path.Combine("/", "Views", "Home", "Index.cshtml"));
        }
    }
}