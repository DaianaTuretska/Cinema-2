using Microsoft.AspNetCore.Mvc;

namespace Cinema2.Cinema2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}