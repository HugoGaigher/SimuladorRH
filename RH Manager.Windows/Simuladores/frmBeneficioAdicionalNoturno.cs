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
    public partial class frmBeneficioAdicionalNoturno : Form
    {
        public frmBeneficioAdicionalNoturno()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHorasNoturnas.Text) || string.IsNullOrEmpty(txtHorasNoturnas.Text) || string.IsNullOrEmpty(txtHorasNoturnas.Text))
            {
                MessageBox.Show("Informe todos os dados e corretamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var salarioBase = double.Parse(txtSalarioBase.Text);
                    var horasNoturnasTrabalhadas = int.Parse(txtHorasNoturnas.Text);
                    var horasTrabalhadas = int.Parse(txtHorasTrabalhadas.Text);

                    var adicionalNoturno = AdicionalNoturno.Calcula(salarioBase, horasNoturnasTrabalhadas, horasTrabalhadas);

                    lblResultado.Text = adicionalNoturno.ToString("C");

                    panelResultado.Visible = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro:" + ex,
                       "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
