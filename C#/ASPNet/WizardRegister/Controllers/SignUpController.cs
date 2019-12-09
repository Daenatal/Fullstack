using Microsoft.AspNetCore.Mvc;
using WizardRegister.Models;
namespace WizardRegister
{
    public class SignUpController: Controller 
    {
        [HttpGet]
        [Route("")]
        public IActionResult register()
        {
            return View("Index");
        }
        [HttpPost]
        [Route("result")]
        public IActionResult showWizard(Wizard student)
        {
            return View("Result",student);
        }
    }
}