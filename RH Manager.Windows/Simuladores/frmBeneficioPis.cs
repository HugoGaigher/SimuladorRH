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
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
        {
            InitializeComponent();
        }

        private void btnVerificarDireitoAoPis_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalarioBase.Text) | string.IsNullOrEmpty(txtDiasTrabalhadosAnoBase.Text) | string.IsNullOrEmpty(txtAnosTrabalhadosCarteiraAssinada.Text))
            {
                MessageBox.Show("ERRO", "Preencha todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var salarioBase = double.Parse(txtSalarioBase.Text);
                var diasTrabalhadosAnoBase = int.Parse(txtDiasTrabalhadosAnoBase.Text);
                var anosTrabalhadosCarteiraAssinada = int.Parse(txtAnosTrabalhadosCarteiraAssinada.Text);

                int mesesTrabalhadosAnoBase = diasTrabalhadosAnoBase / 30;
                double abonoPis = 0.0;

                const double SalarioMinimoAtual = 1320.0;

                if ((salarioBase <= 2*SalarioMinimoAtual)&&(diasTrabalhadosAnoBase >= 30)&&(anosTrabalhadosCarteiraAssinada >= 5))
                {
                    abonoPis = SalarioMinimoAtual * mesesTrabalhadosAnoBase / 12;
                    lblResultado.Text = "Possui o direito ao Abono do PIS no valor de: " + abonoPis.ToString("C");
                }
                else
                {
                    lblResultado.Text = "Não possui direito ao Abono Salarial";
                }

                panelResultado.Visible = true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("ATENÇÃO", "Preencha todos os campos corretamente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
