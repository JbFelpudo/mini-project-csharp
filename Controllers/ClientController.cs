using Microsoft.AspNetCore.Mvc;

namespace mini_project_csharp.Controllers
{
  public class ClientController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}