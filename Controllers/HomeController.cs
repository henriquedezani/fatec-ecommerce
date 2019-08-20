using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("http://www.google.com");
        }
    }
}