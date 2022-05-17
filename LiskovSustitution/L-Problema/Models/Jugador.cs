using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Problema.Models
{
    class Jugador : Personaje
    {
        public override void attack()
        {
            Console.WriteLine("El Jugador ataca con su espada");
        }

        public override void heal()
        {
            Console.WriteLine("El Jugador se cura con una pocion");
        }

        public override void onDeath()
        {
            Console.WriteLine("El Jugador murio");
        }
    }
}
