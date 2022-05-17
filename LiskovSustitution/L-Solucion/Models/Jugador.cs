using L_Solucion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Solucion.Models
{
    class Jugador : IAttack, IOnDeath, IHeal
    {
        public void attack()
        {
            Console.WriteLine("El Jugador ataca con su espada");
        }

        public void heal()
        {
            Console.WriteLine("El Jugador se cura con una pocion");
        }

        public void onDeath()
        {
            Console.WriteLine("El Jugador murio");
        }
    }
}
