using L_Solucion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Solucion.Models
{
    class Enemigo : IAttack, IOnDeath
    {
        public void attack()
        {
            Console.WriteLine("El enemigo ataca con su espada");
        }

        public void onDeath()
        {
            Console.WriteLine("El enemigo suelta una bolsa con oro");
        }
    }
}
