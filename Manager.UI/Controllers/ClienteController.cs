using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Manager.UI.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ClienteController(ILogger<HomeController> logger)
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

            _logger.Log(LogLevel.Information, $"{nameof(Index)} - chama serviço que submete dados ao servidor.");
            // chama serviço que submete dados ao servidor.



            // captura e processa retorno da operacao anterior

            // retorna resultado da operacao anterior ao usuario
            ViewBag.OpcaoSelecionada = new SelectList(new List<string> { "Opção 1", "Opção 2", "Opção 3" });
            return View(model);
        }
    }
}
