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

namespace RH_Manager.Windows.Simuladores //local onde se encontra o arquivo
{
    public partial class frmDescontoInss : Form
    {
        //CONSTRUTOR
        public frmDescontoInss()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(txtSalarioBase.Text))
            {
                MessageBox.Show("Informe seu salário base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBase.Focus();
                return;
            }

            try
            {
                var salarioBase = double.Parse(txtSalarioBase.Text);
                var desconto_inss = Inss.Calcula(salarioBase);
                lblResultado.Text = desconto_inss.ToString("C");
                panelResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor de salário válido", 
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
       
        }

        private void frmDescontoInss_Load(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
