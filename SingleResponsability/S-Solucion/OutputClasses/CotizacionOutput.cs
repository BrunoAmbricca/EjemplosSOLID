using S_Solucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Solucion.OutputClasses
{
    class CotizacionOutput
    {
        public string listaFormatOutput(Cotizacion cot)
        {
            string product = "";
            string specifications = "";

            if (cot.Product is Camisa)
            {
                Camisa camisa = (Camisa)cot.Product;
                string sleeve = camisa.ShortSleeve ? "Manga Corta" : "Manga Larga";
                string neck = camisa.MaoNeck ? "Cuello Mao" : "Cuello Comun";
                string quality = camisa.Premium ? "Premium" : "Standard";

                product = "Camisa";
                specifications = sleeve + " - " + neck + " - " + quality;
            }
            else
            {
                Pantalon pantalon = (Pantalon)cot.Product;
                string type = pantalon.Chupin ? "Chupin" : "Comun";
                string quality = pantalon.Premium ? "Premium" : "Standard";

                product = "Pantalon";
                specifications = type + " - " + quality;
            }

            string cotizacionShow = ("-------------------------\n"
                               + "Id: " + cot.Id + "\n"
                               + "Fecha: " + cot.Created + "\n"
                               + "Codigo de Vendedor: " + cot.SellerCode + "\n"
                               + "Producto: " + product + " " + specifications + "\n"
                               + "Cantidad: " + cot.ProductQuantity + "\n"
                               + "Precio Cotizado: " + cot.Result + "\n");

            return cotizacionShow;
        }
    }
}
