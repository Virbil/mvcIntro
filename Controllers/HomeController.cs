using Microsoft.AspNetCore.Mvc;

namespace Portfolio
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000
        [Route("")]
        [HttpGet]
        public ViewResult HelloFromController()
        {
            return View("Index");
        }

        // localhost:5000/projects
        [HttpGet("projects")]
        public string Project()
        {
            return "These are my projects";
        }

        // localhost:5000/contact
        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}