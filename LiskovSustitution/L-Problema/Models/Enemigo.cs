using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Problema.Models
{
    class Enemigo : Personaje
    {
        public override void attack()
        {
            Console.WriteLine("El enemigo ataca con su espada");
        }

        public override void heal()
        {
            throw new NotImplementedException("El enemigo no se puede curar");
        }

        public override void onDeath()
        {
            Console.WriteLine("El enemigo suelta una bolsa con oro");
        }
    }
}
