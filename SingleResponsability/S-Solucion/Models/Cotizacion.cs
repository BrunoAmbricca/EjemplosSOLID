using S_Solucion.Interfaces;
using S_Solucion.OutputClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Solucion.Models
{
    public class Cotizacion : IImprimible
    {
        private int id;
        private DateTime created;
        private string sellerCode;
        private Prenda product;
        private int productQuantity;
        private double result;

        public Cotizacion(int id, DateTime created, string sellerCode, Prenda product, int productQuantity, double result)
        {
            this.id = id;
            this.created = created;
            this.sellerCode = sellerCode;
            this.product = product;
            this.productQuantity = productQuantity;
            this.result = result;
        }

        public int Id { get => id;}
        public DateTime Created { get => created;}
        public string SellerCode { get => sellerCode;}
        public Prenda Product { get => product;}
        public int ProductQuantity { get => productQuantity;}
        public double Result { get => result;}

        public string imprimir()
        {
            CotizacionOutput cotOut = new CotizacionOutput();

            return cotOut.listaFormatOutput(this);
        }
    }
}
