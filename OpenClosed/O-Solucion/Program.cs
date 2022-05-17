using System;
using System.Collections.Generic;

namespace O_Solucion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICorredor> corredores = new List<ICorredor>();

            corredores.Add(new Caballo("Juanito"));
            corredores.Add(new Formula1("Mercedez"));
            corredores.Add(new Persona("Martin"));

            Carrera carrera = new Carrera(corredores);

            carrera.iniciarCarrera();
        }
    }
}
