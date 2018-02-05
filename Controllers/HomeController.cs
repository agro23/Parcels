using Microsoft.AspNetCore.Mvc;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {
        public string Hello() { return "Hello User!"; }

        [Route("/")]

        public string Main() { return "Main Program!"; }
    }
}
