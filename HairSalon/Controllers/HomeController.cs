using Microsoft.AspNetCore.Mvc;

namespace Salon.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public IActionResult Index()
    {
      return View();
    }
  }
}