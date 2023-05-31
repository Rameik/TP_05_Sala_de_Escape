using Microsoft.AspNetCore.Mvc;
using TP_05_Sala_de_Escape.Models;

namespace TP_05_Sala_de_Escape.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }

    public IActionResult Comenzar()
    {
        int estado = Escape.getEstadoJuego();
        switch(estado){
            case 1:
                return View("SalaUno");
            case 2:
                return View("SalaDos");
            case 3:
                return View("SalaTres");
            case 4:
                return View("SalaCuatro");
        }
        return View();
    }

    public IActionResult Habitacion(int sala, string clave)
    {
        
        return View();
    }
}
