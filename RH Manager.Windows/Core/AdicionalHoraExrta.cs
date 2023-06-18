using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_Manager.Windows.Core
{
    public class AdicionalHoraExrta
    {
        public static double Calcula(double salarioBase, int horasExtras, int horasTrabalhadas, double taxaHoraExtra)
        {
            var adicionalHoraExtra = 0.0;

            var valorDaHoraTrabalhada = salarioBase / horasTrabalhadas;

            adicionalHoraExtra = valorDaHoraTrabalhada * horasExtras * (1+taxaHoraExtra);

            return adicionalHoraExtra;
        }
    }
}
