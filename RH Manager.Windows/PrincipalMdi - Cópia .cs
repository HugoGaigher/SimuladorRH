using RH_Manager.Windows.Simuladores;
using RH_Manager.Windows.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RH_Manager.Windows.Properties;

namespace RH_Manager.Windows
{
    public partial class PrincipalMdi : Form
    {
        public PrincipalMdi()
        {
            InitializeComponent();
        }

        private void descontoDeINSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmDescontoInss();
            form.MdiParent = this;
            form.Show();
        }

        private void descontoDeIRPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmDescontoIrpf();
            form.MdiParent = this;
            form.Show();
        }

        private void benefícioDeAdicionalNoturnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioAdicionalNoturno();
            form.MdiParent = this;
            form.Show();
        }

        private void benefícioDeDepositoFGTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioFgts();
            form.MdiParent = this;
            form.Show();
        }

        private void benefícioDeFériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioFerias();
            form.MdiParent = this;
            form.Show();
        }

        private void benefícioDeHoraExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioHoraExtra();
            form.MdiParent = this;
            form.Show();
        }

        private void benefícioDePericulosidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPericulosidade();
            form.MdiParent = this;
            form.Show();
        }

        private void benefícioDePISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioPis();
            form.MdiParent = this;
            form.Show();
        }

        private void benefícioDeSeguroDesempregoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioSeguroDesemprego();
            form.MdiParent = this;
            form.Show();
        }

        private void benefícioDeValeTransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmBeneficioValeTransporte();
            form.MdiParent = this;
            form.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        private void PrincipalMdi_Load(object sender, EventArgs e)
        {

        }

        private void claroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void escuroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contrachequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmDetalhamentoContracheque();
            form.MdiParent = this;
            form.Show();
        }
    }
}
