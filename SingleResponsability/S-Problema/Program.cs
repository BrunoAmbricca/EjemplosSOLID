using S_Problema.Controllers;
using S_Problema.Models;
using System;

namespace S_Problema
{
    class Program
    {
        static void Main(string[] args)
        {
            CotizacionController cotizacionController = new CotizacionController();
            Camisa camisa = new Camisa(false, 100, false, false);
            Pantalon pantalon = new Pantalon(false, 100, false);

            cotizacionController.crearCotizacion("HJDO209D", camisa, 2500, 10);
            cotizacionController.crearCotizacion("HJDO209D", pantalon, 2500, 10);

            Console.WriteLine(cotizacionController.getListaCotizaciones());
        }
    }
}
