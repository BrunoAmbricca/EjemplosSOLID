using I_Problema.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Problema.Models
{
    class Enemigo : IPersonaje
    {
        public void attack()
        {
            Console.WriteLine("El enemigo ataca con su espada");
        }

        public void heal()
        {
            throw new NotImplementedException("El enemigo no puede curarse");
        }

        public void onDeath()
        {
            Console.WriteLine("El enemigo suelta una bolsa de oro");
        }

        public void onFriendlyInteraction()
        {
            throw new NotImplementedException("El enemigo es tu enemigo, no tu amigo");
        }
    }
}
