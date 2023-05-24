namespace RH_Manager.Windows.Core
{
    public static class Inss
    {

        const double Faixa01 = 1320.0;
        const double Faixa02 = 2571.29;
        const double Faixa03 = 3856.94;
        const double Faixa04 = 7507.79;
        //FUNCAO RETORNO NOME ()
        public static double Calcula(double salarioBase)
        {
            

            var descontoFaixa01 = Core.Inss.InssCalculaFaixa01(salarioBase);
            var descontoFaixa02 = Core.Inss.InssCalculaFaixa02(salarioBase);
            var descontoFaixa03 = Core.Inss.InssCalculaFaixa03(salarioBase);
            var descontFaixa04 = Core.Inss.InssCalculaFaixa04(salarioBase);

            double valorInss = 0;
            
            if(salarioBase <= Faixa01)
            {
                valorInss = Core.Inss.InssCalculaFaixa01(salarioBase);    

            }else if(salarioBase <= Faixa02)
            {

                valorInss = Core.Inss.InssCalculaFaixa02(salarioBase);

            }else if(salarioBase <= Faixa03)
            {
                valorInss = Core.Inss.InssCalculaFaixa03(salarioBase);
            }
            else if(salarioBase <= Faixa04)
            {
                valorInss = Core.Inss.InssCalculaFaixa04(salarioBase);
            }
            else
            {
                valorInss = Core.Inss.InssCalculaFaixa05();
            }

            return valorInss;
        }

        private static double InssCalculaFaixa01(double salarioBase)
        {
            return 0.075 * salarioBase;
        }

        private static double InssCalculaFaixa02(double salarioBase)
        {
            return 0.09 * (salarioBase - Faixa01) + 0.075*(Faixa02 - Faixa01);
        }

        private static double InssCalculaFaixa03(double salarioBase)
        {
            return 0.12 * (salarioBase - Faixa02) + 0.09 * (Faixa02 - Faixa01) + 0.075 * Faixa01;
        }

        private static double InssCalculaFaixa04(double salarioBase)
        {
            return 0.14 * (salarioBase - Faixa03) + 0.12*(Faixa03 - Faixa02) + 0.09*(Faixa02 - Faixa01) + 0.075*Faixa01;
        }

        private static double InssCalculaFaixa05()
        {
            return (Faixa04 - Faixa03)*0.14 + 0.12*(Faixa03 - Faixa02) + 0.09 * (Faixa02 - Faixa01) + 0.075 * Faixa01;
        }


    }
}
