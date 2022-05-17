using D_Solucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Solucion.Interfaces
{
    interface IOrderOutputFile
    {
        void createFile(Order order);
    }
}
