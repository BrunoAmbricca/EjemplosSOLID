using D_Solucion.Interfaces;
using D_Solucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Solucion.Controllers
{
    class OrderController
    {
        public readonly IOrderOutputFile _OutputFile;

        public OrderController(IOrderOutputFile mailService)
        {
            _OutputFile = mailService;
        }

        public void Create(Order order)
        {
            // TODO: código para crear la orden

            // Crea el archivo para el registro de la compañia
            _OutputFile.createFile(order);
        }
    }
}
