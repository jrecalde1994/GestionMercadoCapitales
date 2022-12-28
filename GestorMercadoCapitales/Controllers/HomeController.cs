using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestorMercadoCapitales.Models;

namespace GestorMercadoCapitales.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Menu Principal";
            CotizacionAccion cotizacionAccion = new CotizacionAccion();

            cotizacionAccion = GetCotizaciones();


            return View(cotizacionAccion);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private CotizacionAccion GetCotizaciones()
        {
            CotizacionAccion cotiAccion = new CotizacionAccion();
            cotiAccion.Ticker = "AGRO";
            cotiAccion.Precio = 22400;
            cotiAccion.VarPorcentual = float.Parse("1.54");
            cotiAccion.PrecioA = 22750;
            cotiAccion.CCompra = 1000;
            cotiAccion.PCompra = 22000;
            cotiAccion.PVenta = 23600;
            cotiAccion.CVenta = 14;
            cotiAccion.Min = 22100;
            cotiAccion.Max = 23000;
            cotiAccion.VolNom = "OK";
            cotiAccion.Monto = 2496;
            cotiAccion.Oper = 236;
            cotiAccion.Hora = "Anterior";

            return cotiAccion;

        }

    }
}
