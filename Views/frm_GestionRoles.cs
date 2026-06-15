using Semana5_Clase1.Controllers;
using Semana5_Clase1.Models;

namespace Semana5_Clase1.Views
{
    public partial class frm_GestionRoles : Form
    {
        private readonly RolController _rolController;
        private RolModel? _rolSeleccionado;
        private bool _modoEdicion = false;
        public frm_GestionRoles()
        {
            InitializeComponent();
            _rolController = new RolController();
            ConfigurarDataGridView();
            CargarRoles();
        }
        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                HeaderText = "ID",
                Width = 50,
                Visible = false
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreRol",
                HeaderText = "Nombre del Rol",
                Width = 200
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripción",
                Width = 300
            });
        }

        private void CargarRoles()
        {
            try
            {
                var roles = _rolController.Todos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = roles;
                lblTotal.Text = $"Total: {roles.Count} rol(es)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_GestionRoles_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblNombreRol_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _modoEdicion = false;
            LimpiarFormulario();
            txtNombreRol.Focus();
            grpDatos.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_rolSeleccionado == null)
            {
                MessageBox.Show("Seleccione un rol para editar",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _modoEdicion = true;
            txtNombreRol.Text = _rolSeleccionado.NombreRol;
            txtDescripcion.Text = _rolSeleccionado.Descripcion;
            grpDatos.Enabled = true;
            btnGuardar.Enabled = true;
            txtNombreRol.Focus();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_rolSeleccionado == null)
            {
                MessageBox.Show("Seleccione un rol para eliminar",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var resultado = MessageBox.Show(
                $"¿Está seguro de eliminar el rol '{_rolSeleccionado.NombreRol}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string res = _rolController.Eliminar(_rolSeleccionado.id);
                if (res == "ok")
                {
                    MessageBox.Show("Rol eliminado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarRoles();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(res, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
            {
                MessageBox.Show("El nombre del rol es obligatorio",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreRol.Focus();
                return;
            }

            RolModel rol = new RolModel
            {
                id = _modoEdicion ? _rolSeleccionado!.id : 0,
                NombreRol = txtNombreRol.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim()
            };

            string res = _modoEdicion ?
                _rolController.Actualizar(rol) :
                _rolController.Nuevo(rol);

            if (res == "ok")
            {
                MessageBox.Show(_modoEdicion ?
                    "Rol actualizado exitosamente" :
                    "Rol creado exitosamente",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarRoles();
                LimpiarFormulario();
                grpDatos.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                MessageBox.Show(res, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            grpDatos.Enabled = false;
            btnGuardar.Enabled = false;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtNombreRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem != null)
            {
                _rolSeleccionado = (RolModel)dataGridView1.CurrentRow.DataBoundItem;
            }

        }

        private void LimpiarFormulario()
        {
            txtNombreRol.Clear();
            txtDescripcion.Clear();
            _rolSeleccionado = null;
        }
    }
}
