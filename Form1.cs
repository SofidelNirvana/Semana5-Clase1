using Semana5_Clase1.Controllers;
using Semana5_Clase1.Views;

namespace Semana5_Clase1
{
    public partial class Form1 : Form
    {
        private readonly ClienteControllers _clienteControllers;
        public Form1()
        {
            InitializeComponent();
            _clienteControllers = new ClienteControllers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargaLista();
        }

        public void cargaLista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _clienteControllers.todos();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frm_NuevoCliente frm_NuevoCliente = new frm_NuevoCliente();
            frm_NuevoCliente.ShowDialog();
        }
    }
}
