using IntroducaoAspNetCoreMvc.Models;
using IntroducaoAspNetCoreMvc.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace IntroducaoAspNetCoreMvc.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio clienteRepositorio;
        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            this.clienteRepositorio = clienteRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {                        
            return View(clienteRepositorio.ObterClientes());            
        }

        
        public IActionResult Criar()
        {
            return View();            
        }

        [HttpPost]
        public IActionResult Criar([FromForm] ClienteModel cliente)
        {
            if (!ModelState.IsValid)
                return View(cliente);            

            clienteRepositorio.Adicionar(cliente);
            return RedirectToAction("Listar");
        }
        
        public IActionResult Detalhes(int id)
        {
            return View(clienteRepositorio.ObterPelaChave(id));
        }

    }
}
