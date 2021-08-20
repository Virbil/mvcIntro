using Microsoft.AspNetCore.Mvc;

namespace Portfolio
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // localhost:5000/projects
        [HttpGet("projects")]
        public IActionResult Project()
        {
            return View("Project");
        }

        // localhost:5000/contact
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}