using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_Manager.Windows.Core
{
    public class Fgts
    {
        public static double Calcula(double salarioBase)
        {
            var beneficioFgts = 0.08 * salarioBase;

            return beneficioFgts;
        }
    }
}
