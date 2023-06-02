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
    public partial class frmBeneficioPericulosidade : Form
    {
        public frmBeneficioPericulosidade()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalarioBase.Text))
            {
                MessageBox.Show("Insira um valor de salário", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBase.Focus();
            }

            try
            {
                var salarioBase = double.Parse(txtSalarioBase.Text);

                var adicionalPericulosidade = Core.AdicionalPericulosidade.Calcula(salarioBase);

                lblResultado.Text = adicionalPericulosidade.ToString("C");
                panelResultado.Visible = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Informe um valor de salário válido",
                     "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
