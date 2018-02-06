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
        public ActionResult Results()
        {
          // return View("Results.cshtml");
          Parcel myParcel = new Parcel();
          myParcel.SetWeight(Request.Query["weight"]);
          myParcel.SetHeight(Request.Query["height"]);
          myParcel.SetLength(Request.Query["length"]);
          myParcel.SetWidth(Request.Query["width"]);

          return View("Results", myParcel);
          //
          // return View("Results");
        }

        // [Route("/greeting_card")]
        // public ActionResult GreetingCard()
        // {
        //     LetterVariable myLetterVariable = new LetterVariable();
        //     myLetterVariable.SetRecipient(Request.Query["recipient"]);
        //     myLetterVariable.SetSender(Request.Query["sender"]);
        //     return View("Hello", myLetterVariable);
        // }
    }
}
