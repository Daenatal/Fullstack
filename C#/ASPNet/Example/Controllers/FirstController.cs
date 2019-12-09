using Microsoft.AspNetCore.Mvc;
namespace Example.Controllers
{
    public class FirstController: Controller
    {
        [HttpGet("other")]
        public RedirectToActionResult returnIndex()
        {
            return RedirectToAction("Index","Hello"); //accessing methods from other controllers, pass in Action first and then the Controller Name
        }
        [HttpGet("hungry")]
        public RedirectToActionResult returnBuffet()
        {
            return RedirectToAction("BuffetItems", "Hello", new {dish1 = "Hamburgers", dish2 = "Mozarella Sticks", dish3= "Pancakes"});
        }
        
    }
}