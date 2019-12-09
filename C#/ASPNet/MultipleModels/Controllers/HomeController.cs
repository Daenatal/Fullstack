using Microsoft.AspNetCore.Mvc;
using MultipleModels.Models;
namespace MultipleModels
{
    public class HomeController: Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("Index2");
        }
        [HttpPost]
        [Route("create/product")]
        public IActionResult CreateProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            
            return View("Index2");
        }
        [HttpPost]
        [Route("create/product2")]
        public IActionResult CreateProduct2(IndexViewModel modelData)
        {
            Product submittedProduct = modelData.ProductObject;
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            
            return View("Index2");
        }
        [HttpPost]
        [Route("create/user")]
        public IActionResult CreateUser(User newUser)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index2");
        }
        [HttpPost]
        [Route("create/user2")]
        public IActionResult CreateUser2(IndexViewModel modelData)
        {
            User submittedUser = modelData.UserObject;
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index2");
        }
        [HttpGet("success")]
        public string Success()
        {
            return "You have successfully submitted";
        }
    }
}