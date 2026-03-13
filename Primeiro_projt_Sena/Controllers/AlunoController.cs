using Microsoft.AspNetCore.Mvc;

namespace Primeiro_projt_Sena.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nota = "Aluno nota 10";
            ViewData["Escola"] = "E.E. Anhanguera";
            return View();
        }
    }
}
