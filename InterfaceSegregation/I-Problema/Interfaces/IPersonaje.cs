using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Problema.Interfaces
{
    interface IPersonaje
    {
        void attack();
        void onDeath();
        void heal();
        void onFriendlyInteraction();

    }
}
