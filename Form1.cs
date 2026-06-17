using Semana5_Clase1.Controllers;
using Semana5_Clase1.Models;
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
            this.Text = "Sistema de Gestión - Semana 5";
            this.WindowState = FormWindowState.Maximized;
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
            cargaLista();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form1 frmClientes = new Form1();
            frmClientes.ShowDialog();

        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            try
            {
                frm_GestionRoles frm = new frm_GestionRoles();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir Gestión de Roles: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                frm_GestionUsuarios frm = new frm_GestionUsuarios();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir Gestión de Usuarios: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de salir del sistema?",
                "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var cliente = dataGridView1.CurrentRow.DataBoundItem as ClienteModel;
                if (cliente != null)
                {
                    DialogResult result = MessageBox.Show(
                        $"¿Está seguro de eliminar al cliente {cliente.Nombre}?",
                        "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string res = _clienteControllers.eliminar(cliente.id);
                        if (res == "ok")
                        {
                            MessageBox.Show("Cliente eliminado exitosamente", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargaLista();
                        }
                        else
                        {
                            MessageBox.Show("Error: " + res, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var cliente = dataGridView1.CurrentRow.DataBoundItem as ClienteModel;
                if (cliente != null)
                {
                    // Aquí podrías abrir un formulario de edición
                    MessageBox.Show("Función de editar en desarrollo", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargaLista();
        }
    }
}
