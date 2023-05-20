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
    public partial class frmDescontoInss : Form
    {
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
                var salarioBase = decimal.Parse(txtSalarioBase.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor de salário válido", 
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          

           
            

           
        }
    }
}
