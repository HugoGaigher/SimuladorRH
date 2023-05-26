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
    public partial class frmDescontoIrpf : Form
    {
        public frmDescontoIrpf()
        {
            InitializeComponent();
        }

        private void btnCalculaIrpf_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalarioBase.Text))
            {
                MessageBox.Show("Informe seu salário base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBase.Focus();
            }
            else
            {
                try
                {
                    var salarioBase = double.Parse(txtSalarioBase.Text);
                    var descontoIrpf = Irpf.Calcula(salarioBase);
                    lblResultado.Text = descontoIrpf.ToString("C");
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
}
