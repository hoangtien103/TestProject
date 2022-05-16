using Microsoft.AspNetCore.Mvc;

namespace TestProject.Controllers
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
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login(string msg)
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginCheck(IFormCollection collection) // handles POST requests by default
        {
            string uname = collection["uname"];
            string psw = collection["psw"];
            if(uname=="admin"&&psw== "123")
            return RedirectToAction("Index");
            TempData["error"] = true;
            TempData["errmsg"] = "Username or password is wrong";
            return RedirectToAction("Login");
        }
    }
}
