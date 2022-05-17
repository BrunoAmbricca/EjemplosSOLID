using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Solucion
{
    class Formula1 : ICorredor
    {
        private string modelo;

        public Formula1(string modelo)
        {
            this.modelo = modelo;
        }

        public void correr()
        {
            Console.WriteLine("El auto de modelo " + modelo + " acelera a toda velocidad");
        }
    }
}
