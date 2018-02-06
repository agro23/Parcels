using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
// using ParcelVars.cs;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {
        public string Hello() { return "Hello User!"; }

        [Route("/")]

        public string Main() { return "Main Program!"; }

        // [Produces("text/html")]
        [Route("Form")]
        public ActionResult Form(){
          // return View("Results.cshtml");
          return View();
        }

        [Route("/Results")]
        // public ActionResult Results()
        public string myResults()
        {
          // return View("Results.cshtml");
          return View("Hi There!");
        }
    }
}
