using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Problema.Models
{
    abstract class Personaje
    {
        public abstract void attack();
      
        public abstract void onDeath();

        public abstract void heal();
    }
}
