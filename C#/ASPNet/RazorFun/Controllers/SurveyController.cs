using Microsoft.AspNetCore.Mvc;
using RazorFun.Models;
namespace RazorFun
{
    public class SurveyController: Controller 
    {   
        [HttpGet]
        [Route("survey")]
        public ViewResult Survey()
        {
            return View("Survey");
        }
        [HttpPost]
        [Route("formSubmitted")]
        public ViewResult Result(Student theStudent)
        {
            if(ModelState.IsValid)
            {
                return View("Result", theStudent);
            }
            else
            {
                return View("Survey");
            }
        }
    }
}