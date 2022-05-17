using I_Solucion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Solucion.Models
{
    class Enemigo : ICombat
    {
        public void attack()
        {
            Console.WriteLine("El enemigo ataca con su espada");
        }

        public void onDeath()
        {
            Console.WriteLine("El enemigo suelta una bolsa de oro");
        }
    }
}
