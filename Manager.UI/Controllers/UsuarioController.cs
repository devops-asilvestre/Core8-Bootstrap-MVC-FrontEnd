using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Manager.UI.Controllers
{
    public class Usuarioontroller : Controller
    {
        private readonly ILogger<Usuarioontroller> _logger;

        public Usuarioontroller(ILogger<Usuarioontroller> logger)
        {
            _logger = logger;
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            _logger.Log(LogLevel.Information, $"{nameof(Index)}");
            return View();
        }

        public IActionResult Cadastro()
        {
            _logger.Log(LogLevel.Information, $"{nameof(Cadastro)}");
            return View();
        }

        [HttpPost("Index")]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string model)
        {
            if (ModelState.IsValid)
            {
                // Lógica para salvar os dados
                return RedirectToAction("Index");
            }
            ViewBag.OpcaoSelecionada = new SelectList(new List<string> { "Opção 1", "Opção 2", "Opção 3" });
            return View(model);
        }
    }
}
