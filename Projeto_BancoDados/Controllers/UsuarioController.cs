using Microsoft.AspNetCore.Mvc;

namespace Projeto_BancoDados.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult CadastrarUsuario()
        {
            return View();
        }

    }
}
