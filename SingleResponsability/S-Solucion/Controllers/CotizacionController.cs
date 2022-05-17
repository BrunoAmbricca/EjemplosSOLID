using S_Solucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Solucion.Controllers
{
    class CotizacionController
    {
        private List<Cotizacion> cotizaciones;

        public CotizacionController()
        {
            this.cotizaciones = new List<Cotizacion>();
        }

        public void crearCotizacion(string vendedorCode, Prenda product, double result, int quantityTextBox)
        {
            Cotizacion cotizacion = new Cotizacion(this.cotizaciones.Count(), DateTime.Now, vendedorCode, product, quantityTextBox, result);

            cotizaciones.Add(cotizacion);
        }

        public string getListaCotizaciones()
        {
            string cotizacionesShow = "Historial de Cotizaciones\n";

            foreach (Cotizacion cot in cotizaciones)
            {
                cotizacionesShow += cot.imprimir();
            }

            return cotizacionesShow;
        }
    }
}
