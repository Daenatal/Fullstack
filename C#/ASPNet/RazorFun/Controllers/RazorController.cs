using Microsoft.AspNetCore.Mvc;
namespace RazorFun
{
    public class RazorController: Controller 
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}