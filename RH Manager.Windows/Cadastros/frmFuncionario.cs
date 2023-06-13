using RH_Manager.Windows.Core;
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

            cmbEstado.Items.Clear();
            cmbEstado.DataSource = listaEstados.OrderBy(x => x.Sigla);
            cmbEstado.DisplayMember = "Sigla";
            cmbEstado.ValueMember = "Id";
        }

        
    }
}
