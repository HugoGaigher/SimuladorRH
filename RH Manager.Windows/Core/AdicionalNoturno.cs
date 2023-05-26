using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_Manager.Windows.Core
{
    public static class AdicionalNoturno
    {
        public static double Calcula(double salarioBase, double horasNoturnasTrabalhadas, double horasTrabalhadas)
        {
            double adicionalNoturno = 0.0;
            
            double valorDaHoraTrabalhada = salarioBase / horasTrabalhadas;
            
            const double TaxaNoturna = 0.2;

            double equivalenteHorasNoturnas = 60 * horasNoturnasTrabalhadas / 52.5;

            adicionalNoturno = TaxaNoturna* valorDaHoraTrabalhada*equivalenteHorasNoturnas;

            return adicionalNoturno;
        }
    }
}
