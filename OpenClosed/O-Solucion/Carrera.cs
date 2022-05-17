using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Solucion
{
    class Carrera
    {
        private List<ICorredor> corredores;

        public Carrera(List<ICorredor> corredores)
        {
            this.corredores = corredores;
        }

        public void iniciarCarrera()
        {
            foreach (ICorredor corredor in corredores)
            {
                corredor.correr();
            }
        }
    }
}
