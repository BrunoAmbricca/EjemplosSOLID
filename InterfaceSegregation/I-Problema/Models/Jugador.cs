using I_Problema.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Problema.Models
{
    class Jugador : IPersonaje
    {
        public void attack()
        {
            Console.WriteLine("El jugador ataca con su espada");
        }

        public void heal()
        {
            Console.WriteLine("El jugador se cura con una pocion");
        }

        public void onDeath()
        {
            Console.WriteLine("El jugador reaparece en el ultimo checkpoint");
        }

        public void onFriendlyInteraction()
        {
            Console.WriteLine("Se abre el inventario del jugador con el que interacciona");
        }
    }
}
