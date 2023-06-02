using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_Manager.Windows.Simuladores
{
    public partial class frmBeneficioFerias : Form
    {
        public frmBeneficioFerias()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalarioBase.Text))
            {
                MessageBox.Show("Informe seu salário base","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBase.Focus();
            }

            try
            {
                var salarioBase = double.Parse(txtSalarioBase.Text);
                var adicionalFerias = salarioBase / 3;
                var descontoInss = Core.Inss.Calcula(salarioBase + adicionalFerias);
                var descontoIrrf = Core.Irrf.Calcula(salarioBase + adicionalFerias);

                var valorRecebido = salarioBase + adicionalFerias - descontoIrrf - descontoInss;

                lblResultado.Text = valorRecebido.ToString("C");
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
