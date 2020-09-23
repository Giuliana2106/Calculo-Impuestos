using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculo_Impuestos
{
    class Aguin
    {
        public double aguinaldo(double total, int dias, int dias_año)
        {
            return (total * dias / dias_año);
        }
    }
}
