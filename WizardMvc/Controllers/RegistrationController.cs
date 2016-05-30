using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WizardMvc.Domain.Entities;

namespace WizardMvc.Controllers
{
    public class RegistrationController : Controller
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ActionExecutingContext contect = filterContext;
            string test = contect.
        }
        private RegistrationData regData;
        // GET: /Registration/

        public ActionResult BasicDetails(string nextButton)
        {
          
            if (nextButton != null) return RedirectToAction("ExtraDetails");
            return View(regData);
        }

        public ActionResult ExtraDetails(string backButton,string nextButton)
        {
            if (backButton != null) return RedirectToAction("BasicDetails");
            else if (nextButton != null) return RedirectToAction("Confirm");
            else  return View();
        }


    }
}
