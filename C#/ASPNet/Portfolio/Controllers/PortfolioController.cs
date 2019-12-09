using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
    public class PortfolioController : Controller 
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }
        [HttpGet]
        [Route("contact")]
        public ViewResult Contact()
        {
            return View("Contact");
        }
    }
}