using System;
using System.Collections.Generic;

namespace O_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> corredores = new List<Object>();

            corredores.Add(new Caballo("Juanito"));
            corredores.Add(new Formula1("Mercedez"));

            Carrera carrera = new Carrera(corredores);

            carrera.iniciarCarrera();
        }
    }
}
