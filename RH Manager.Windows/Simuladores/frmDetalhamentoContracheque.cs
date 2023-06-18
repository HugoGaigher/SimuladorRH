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
    public partial class frmDetalhamentoContracheque : Form
    {
        public frmDetalhamentoContracheque()
        {
            InitializeComponent();
        }

        private void panelResultado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRealizarDetalhamento_Click(object sender, EventArgs e)
        {
            const double TaxaHoraNoturna = 0.2;
            const double TaxaHoraExtra = 0.5;

            var salarioBase = double.Parse(txtSalarioBase.Text);
            var horasTrabalhadasNoMes = int.Parse(txtHorasTrabalhadasNoMes.Text);
            var horasNoturnasTrabalhadas = int.Parse(txtHorasNoturnasTrabalhadas.Text);
            var hotasExtrasTrabalhadas = int.Parse(txtHorasExtrasTrabalhadas.Text) ;
            
            var descontoInss = Inss.Calcula(salarioBase);
            var descontoIrrf = Irrf.Calcula(salarioBase - descontoInss);
            var descontoValeTransporte = 0.0;

            var adicionalFgts = Fgts.Calcula(salarioBase);
            var adicionalPericulosidade = 0.0;
            var adicionalHoraNoturna = AdicionalNoturno.Calcula(salarioBase, horasNoturnasTrabalhadas, horasTrabalhadasNoMes);
            var adicionalHoraExtra = AdicionalHoraExrta.Calcula(salarioBase, hotasExtrasTrabalhadas, horasTrabalhadasNoMes, TaxaHoraExtra);

            

            if(rdbOpcaoSimPericulosidade.Checked)
            {
                adicionalPericulosidade = AdicionalPericulosidade.Calcula(salarioBase);
            }

            if(rdbOpcaoSimValeTransporte.Checked)
            {
                descontoValeTransporte = ValeTransporte.Calcula(salarioBase);
            }

            panelResultado.Visible = true;
            lblAdicionais.Visible = true;
            lblDescontos.Visible = true;
            lblDetalhamento.Visible = true;
            lblFgts.Text = "FGTS: " + adicionalFgts.ToString("C");
            lblHorasExtras.Text = "Horas Extras: " + adicionalHoraExtra.ToString("C");
            lblHorasNoturnas.Text = "Horas Noturnas: " + adicionalHoraNoturna.ToString("C");
            lblPericulosidade.Text = "Periculosidade: " + adicionalPericulosidade.ToString("C");

            lblValeTransporte.Text = "Vale transporte: " + descontoValeTransporte.ToString("C");
            lblIrrf.Text = "IRRF: " + descontoIrrf.ToString("C");
            lblInss.Text = "INSS: " + descontoInss.ToString("C");


            
        }
    }
}
