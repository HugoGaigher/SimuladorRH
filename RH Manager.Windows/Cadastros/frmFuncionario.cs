using RH_Manager.Windows.Core;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RH_Manager.Windows.Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void frmFuncionario_Load(object sender, System.EventArgs e)
        {
            CarregarEstados();
        }
        private void CarregarEstados()
        {
            var estados = new Estados();
            var listaEstados = estados.ObterTodosEstados();
            var estadosAz = listaEstados.OrderBy(x => x.Sigla).ToList();

            cmbEstado.Items.Clear();
            cmbEstado.DataSource = estadosAz;
            cmbEstado.DisplayMember = "Nome";
            cmbEstado.ValueMember = "Sigla";
        }

        
        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            var cepDigitado = txtCep.Text;

            if (cepDigitado.Length < 9)
            {
                MessageBox.Show("Insira um CEP com 8 caracteres", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Focus();
                return;
            }
            
            
            var endereco = new Endereco();
            var enderecoCompleto = endereco.ObterPorCep(cepDigitado);
            var cepInvalido = enderecoCompleto.Erro;

            if (string.IsNullOrEmpty(txtCep.Text) || cepInvalido)
            {
                MessageBox.Show("Insira um CEP válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCidade.Enabled = true;
                cmbEstado.Enabled = true;
                txtDdd.Enabled = true;

                ApagarTudo();

                return;
            }

            if (endereco.Localidade != "") txtCidade.Enabled = false;
            if(endereco.Uf != "") cmbEstado.Enabled = false;
            
            txtLogradouro.Text = enderecoCompleto.Logradouro.ToUpper();
            txtBairro.Text = enderecoCompleto.Bairro.ToUpper();

            //DEVEM FICAR FIXOS: DDD, CIDADE E ESTADO
            txtCidade.Text = enderecoCompleto.Localidade.ToUpper();
            cmbEstado.SelectedValue = enderecoCompleto.Uf;
            txtDdd.Text = enderecoCompleto.Ddd;

            txtCidade.Enabled = false;
            cmbEstado.Enabled = false;
            txtDdd.Enabled = false;
            
               
        }
        
        private void ApagarTudo()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtDdd.Clear();
            txtNumero.Clear();
            
            txtLogradouro.Clear();
            cmbEstado.SelectedValue = "AC";
        }

       
    }
}
