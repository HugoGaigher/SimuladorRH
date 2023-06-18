using System;
using System.Windows.Forms;

namespace RH_Manager.Windows.Simuladores
{
    public partial class frmBeneficioHoraExtra : Form
    {
        public frmBeneficioHoraExtra()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHorasExtras.Text) | string.IsNullOrEmpty(txtHorasTrabalhadas.Text) | string.IsNullOrEmpty(txtSalarioBase.Text) | string.IsNullOrEmpty(txtTaxaHoraExtra.Text) )
            {
                MessageBox.Show("ERRO", "Preencha todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            try
            {
                var salarioBase = double.Parse(txtSalarioBase.Text);
                var taxaHoraExtra = double.Parse(txtTaxaHoraExtra.Text)/100;
                var horasTrabalhadas = int.Parse(txtHorasTrabalhadas.Text);
                var horasExtras = int.Parse(txtHorasExtras.Text);

                var adicionalHoraExtra = Core.AdicionalHoraExrta.Calcula(salarioBase, horasExtras, horasTrabalhadas, taxaHoraExtra);

                panelResultado.Visible = true;

                lblResultado.Text = adicionalHoraExtra.ToString("C");


            }
            catch(Exception ex) 
            { 
            }
        }
    }
}
