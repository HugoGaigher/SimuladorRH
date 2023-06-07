using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_Manager.Windows.Simuladores
{
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }

        private void cbbQuantidadeDeSolicitacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmBeneficioSeguroDesemprego_Load(object sender, EventArgs e)
        {
            lblResultado.Visible = false;
            panelResultado.Visible = false;
        }


        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var quantidadeDeSolicitacoes = cbbQuantidadeDeSolicitacoes.SelectedIndex;
            var salarioBruto = double.Parse(txtSalarioBase.Text);
            double salarioAcumulado = 0;
            const double SalarioMinimoAtual = 1320.0;
            bool possuiDireito = false;

            try
            {
                switch (quantidadeDeSolicitacoes)
                {
                    case 1:
                        salarioAcumulado = salarioBruto * 18;

                        if (salarioAcumulado / SalarioMinimoAtual >= 12) possuiDireito = true;
                        else possuiDireito = false;

                        break;

                    case 2:

                        salarioAcumulado = salarioBruto * 12;

                        if (salarioAcumulado / SalarioMinimoAtual >= 9) possuiDireito = true;
                        else possuiDireito = false;


                        break;

                    case 3:

                        salarioAcumulado = salarioBruto * 6;

                        if (salarioAcumulado / SalarioMinimoAtual >= 6) possuiDireito = true;
                        else possuiDireito = false;

                        break;
                }

                if (possuiDireito) lblResultado.Text = "Possui direito ao Seguro-Desemprego";
                else lblResultado.Text = "Não possui direito ao seguro desemprego";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex,
                       "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            lblResultado.Visible = true;
            panelResultado.Visible = true;
        }
    }
}
