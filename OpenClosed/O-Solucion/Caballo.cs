using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Solucion
{
    class Caballo : ICorredor
    {
        private string nombre;

        public Caballo(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; }

        public void correr()
        {
            Console.WriteLine("El caballo " + nombre + " galopa a toda velocidad");
        }
    }
}
