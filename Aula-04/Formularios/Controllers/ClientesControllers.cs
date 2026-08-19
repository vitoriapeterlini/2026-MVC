using Microsoft.AspNetCore.Mvc;

namespace Formularios.Controllers;

public class ClientesController : Controller
{
    public IActionResult Cadastrar()
    {
        return View();
    }
}
