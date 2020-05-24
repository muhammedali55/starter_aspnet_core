using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers
{
   public class HomeController : Controller
  {
       public IActionResult Index(int id)
      {
          return View();
      }
  }
}
