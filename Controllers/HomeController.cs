using Microsoft.AspNetCore.Mvc;

namespace TP4Bis.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.listaPaises = Info.ListarPaises();
        return View();
    }
    public IActionResult DetallePais(string nombrePais){
        ViewBag.pais = Info.DetallePais(nombrePais);
        return View("DetallePais");
    }
}
