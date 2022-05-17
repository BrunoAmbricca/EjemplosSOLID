using D_Problema.OrderOutputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Problema.Models
{
    class OrderController
    {
        public readonly ExcelOutput _ExcelOutput;

        public OrderController(ExcelOutput mailService)
        {
            _ExcelOutput = mailService;
        }

        public void Create(Order order)
        {
            // TODO: código para crear la orden

            // Crea el archivo para el registro de la compañia
            _ExcelOutput.createExcel(order);
        }
    }
}
