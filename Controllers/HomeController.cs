﻿using Microsoft.AspNetCore.Mvc;
using TP_05_Sala_de_Escape.Models;

namespace TP_05_Sala_de_Escape.Controllers;

public class HomeController : Controller
{
    public string[] salas = {"SalaUno", "SalaDos", "SalaTres", "SalaCuatro"};

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Creditos()
    {
        return View();
    }

    public IActionResult Comenzar()
    {
        Escape.estadoJuego = 1;
        Escape.puntaje = 0;
        return View(salas[Escape.getEstadoJuego() - 1]);
    }

    [HttpPost]
    
    public IActionResult Habitacion(int sala, string clave)
    {

        if(sala == Escape.getEstadoJuego()){
            if(Escape.resolverSala(sala, clave)){
                if(Escape.getEstadoJuego() == 5) {
                    ViewBag.puntaje = Escape.puntaje;
                    Escape.puntaje = 0;
                    return View("Victoria");
                }
                else{
                    ViewBag.puntaje = Escape.puntaje;
                    Escape.puntaje = 0;
                    return View(salas[Escape.getEstadoJuego() - 1]);
                }
            }
            else{
                ViewBag.Error = "La respuesta ingresada es incorrecta";
                ViewBag.puntaje = Escape.puntaje;
                Escape.puntaje = 0;
                return View(salas[sala - 1]);
            }
        }
        else{
            if(salas.Length < Escape.getEstadoJuego()){
                return View("Victoria");
            }
            ViewBag.puntaje = Escape.puntaje;
            Escape.puntaje = 0;
            return View(salas[Escape.estadoJuego - 1]);
        }
    }
}
