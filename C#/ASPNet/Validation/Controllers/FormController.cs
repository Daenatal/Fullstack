using System;
using Microsoft.AspNetCore.Mvc;
using Validation.Models;
namespace Validation
{
    public class FormController: Controller 
    {
        [HttpGet]
        [Route("")]
        public IActionResult getForm()
        {
            ViewBag.CurrentTime = DateTime.Now;
            ViewBag.Message = "The time is now: ";
            User Stan = new User()
            {
                FirstName = "Stan",
                LastName= "Stan",
                Age = 33,
                Email = "test@test.com",
                Password = "passwordnumber",
                Date = DateTime.Now
            };
            return View("Index", Stan);
        }
        [HttpPost]
        [Route("register")]
        public IActionResult registered(User aUser)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet]
        [Route("success")]
        public ViewResult Success()
        {
            return View("Result");
        }
    }
    
}