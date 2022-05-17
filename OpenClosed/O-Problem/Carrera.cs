using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Problem
{
    class Carrera
    {
        private List<Object> corredores;

        public Carrera(List<Object> corredores)
        {
            this.corredores = corredores;
        }

        public void iniciarCarrera()
        {
            foreach(Object corredor in corredores)
            {
                if(corredor is Caballo)
                {
                    Caballo caballo = (Caballo)corredor;
                    Console.WriteLine("El caballo " + caballo.Nombre + " galopa a toda velocidad");
                }
                else if (corredor is Formula1)
                {
                    Formula1 formula1 = (Formula1)corredor;
                    Console.WriteLine("El auto de modelo " + formula1.Modelo + " acelera a toda velocidad");
                }
            }
        }
    }
}
