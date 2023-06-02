using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_Manager.Windows.Core
{
    public static class AdicionalPericulosidade
    {
        public static double Calcula(double salarioBase)
        {
            var adicionalNoturno = 3 * salarioBase / 10;

            return adicionalNoturno;
        }
    }
}
