using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Solucion
{
    class Persona : ICorredor
    {
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; }

        public void correr()
        {
            Console.WriteLine("La persona " + nombre + " corre a toda velocidad");
        }
    }
}
