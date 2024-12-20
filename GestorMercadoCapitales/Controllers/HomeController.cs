﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestorMercadoCapitales.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace GestorMercadoCapitales.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Menu Principal";
            List<CotizacionAccion> cotizacionAccion = new List<CotizacionAccion>();

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

        private List<CotizacionAccion> GetCotizaciones()
        {
            //string url = "http://localhost:22684/api/Precio";
            //var parames = new Dictionary<string, string>();
            //HttpClientHandler clientHandler = new HttpClientHandler();
            //clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            var data = new List<CotizacionAccion>();

            //using (HttpClient client = new HttpClient(clientHandler))
            //{
            //    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("none"));

            //    //HttpResponseMessage response = client.PostAsync(url, new FormUrlEncodedContent(parames)).Result;
            //    HttpResponseMessage response = client.GetAsync(url).Result;
            //    var responseText = response.Content.ReadAsStringAsync().Result;
            //    data = JsonConvert.DeserializeObject<List<CotizacionAccion>>(responseText); 
            //}




           /* CotizacionAccion cotiAccion = new CotizacionAccion();
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
            cotiAccion.Hora = "Anterior";*/




            return data;

        }
        

    }
}
