using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appcomics.Models;

namespace appcomics.Controllers
{
    public class CalculadoraController : Controller
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Operacion objOperacion)
        {
            int temporadas, costo, edad;
            double costoTot;
            string nombre, genero, categoria, nombramiento, club;

            temporadas = objOperacion.Temporadas();
            nombramiento = objOperacion.Nombrar();
            categoria = objOperacion.DefCategoria();
            edad = objOperacion.DefEdad();
            nombre = objOperacion.DefNombres();
            genero = objOperacion.DefGenero();
            club = objOperacion.DefClub();


            costo = temporadas*600;
            costoTot = costo*1.19;

            if(nombramiento == "-"){
                ViewData["Message"] = "Por favor, completa tus datos";
                return View("Index");
            }if(edad <= 0){
                ViewData["Message"] = "Por favor, completa tus datos correctamente";
                return View("Index");
            }else{
                ViewData["Message"] = $"{nombramiento}<br/>Edad: {edad}<br>Nombre Completo: {nombre}<br>Categoria: {categoria}<br>Genero: {genero}<br>Club: {club}<br><br>COSTOS:<br>Costo Subtotal: {costo}<br>Impuesto (19%): {costoTot-costo}<br>Costo Total: {costoTot}";
                return View("Index");
            }

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}

