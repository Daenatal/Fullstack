using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Example.Controllers //should be the project name 
{
    public class HelloController : Controller 
    {
        [HttpGet] //type of request
        [Route("")] //associated route string 
        //public string Index() replacing this to serve us a view rather than a string
        public ViewResult Index() //we call View() which is of type ViewResult which we return
        {
            return View();
        }
        [HttpGet]
        [Route("{name}")] 
        public ViewResult Info(string name)
        {
            ViewBag.name = "Hello " + name + ", welcome to your page!"; 
            return View("Name");
        }
        [HttpGet]
        [Route("pizza/{topping}")]
        public string PizzaTimes(string topping)
        {
            return $"I see you like pizza with {topping}!";
        }
        [HttpGet("elsewhere")]
        public ViewResult Elsewhere()
        {
            return View("Index");
        }
        [HttpGet("buffet/{dish1}/{dish2}/{dish3}")]
        public string BuffetItems(string dish1, string dish2, string dish3)
        {
            return $"Welcome to the Ninja Buffet, we have {dish1}, {dish2}, and lastly {dish3}. We hope you enjoy!";
        }
        [HttpGet]
        [Route("displayint")]
        public JsonResult DisplayInt()
        {
            return Json(34);
        }
        [HttpGet]
        [Route("displayhuman")]
        public JsonResult DisplayHuman()
        {
            return Json(new Human("Strauss", 100, 11, 5));
        }
        [HttpGet]
        [Route("displayanon")]
        public JsonResult DisplayAnon()
        {
            var AnonObject = new {
                FirstName = "Raz",
                LastName = "Man",
                Age = 10

            };
            return Json(AnonObject);
        }
    }
}