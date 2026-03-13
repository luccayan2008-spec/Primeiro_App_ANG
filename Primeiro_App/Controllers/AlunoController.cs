using Microsoft.AspNetCore.Mvc;

namespace Primeiro_App.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
