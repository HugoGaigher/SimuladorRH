using System.Runtime.InteropServices;

namespace RH_Manager.Windows.Core
{
    public class Irpf
    {
        const double Faixa01 = 2112;
        const double Faixa02 = 2826.65;
        const double Faixa03 = 3751.06;
        const double Faixa04 = 4664.68;
        public static double Calcula(double salarioBase)
        {
            var descontoInss = Inss.Calcula(salarioBase);

            double salarioReal = salarioBase - descontoInss - 528.0;
            
            double descontoIrpf = 0;

            if (salarioReal <= Faixa01)
            {
                descontoIrpf = 0;
            }
            else if (salarioReal <= Faixa02)
            {
                descontoIrpf = (salarioReal - Faixa01) * 0.075;
            }
            else if (salarioReal <= Faixa03)
            {
                descontoIrpf = (salarioReal - Faixa02) * 0.15 + (Faixa02 - Faixa01) * 0.075;  
            }
            else if (salarioReal <= Faixa04)
            {
                descontoIrpf = (salarioReal - Faixa03)*0.225 + (Faixa03 - Faixa02)*0.15 + (Faixa02 - Faixa01) * 0.075;
            }
            else
            {
                descontoIrpf = (salarioReal - Faixa04)*0.275+ (Faixa04 - Faixa03) * 0.225 + (Faixa03 - Faixa02) * 0.15 + (Faixa02 - Faixa01) * 0.075;
            }

            return descontoIrpf;
        }


    }
}
