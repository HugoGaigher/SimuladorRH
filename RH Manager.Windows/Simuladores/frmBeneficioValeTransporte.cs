using RH_Manager.Windows.Core;
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
    public partial class frmBeneficioValeTransporte : Form
    {
        public frmBeneficioValeTransporte()
        {
            InitializeComponent();
        }

        private void lblValeTransporte_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculaDescontoValeTransporte_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalarioBase.Text) || string.IsNullOrEmpty(txtValorDaPassagem.Text) || string.IsNullOrEmpty(txtUsoMensalDoTransporte.Text))
            {
                MessageBox.Show("Informe todos os dados solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBase.Focus();
                return;
            }else
            {
                try
                {
                    var salarioBase = double.Parse(txtSalarioBase.Text);
                    var quantidadeDoUsoTransporte = int.Parse(txtUsoMensalDoTransporte.Text);
                    var valorPassagem = double.Parse(txtValorDaPassagem.Text);

                    var descontoValeTransporte = ValeTransporte.Calcula(salarioBase);

                    if (descontoValeTransporte <= quantidadeDoUsoTransporte * valorPassagem)
                    {
                        lblCustoBeneficio.Text = "Recomendamos que aceite nosso Vale Transporte";
                    }
                    else
                    {
                        lblCustoBeneficio.Text = "Não recomendamos que aceite nosso Vale Transporte";
                    }

                    lblResultado.Text = descontoValeTransporte.ToString("C");
                    panelResultado.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex,
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
        }
    }
}
