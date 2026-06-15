using Semana5_Clase1.Controllers;
using Semana5_Clase1.Models;

namespace Semana5_Clase1.Views
{
    public partial class frm_GestionUsuarios : Form
    {
        private readonly UsuarioController _usuarioController;
        private readonly RolController _rolController;
        private UsuarioModel? _usuarioSeleccionado;
        private bool _modoEdicion = false;
        public frm_GestionUsuarios()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();
            _rolController = new RolController();
            ConfigurarDataGridView();
            CargarRoles();
            CargarUsuarios();
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
                DataPropertyName = "Username",
                HeaderText = "Usuario",
                Width = 120
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCompleto",
                HeaderText = "Nombre Completo",
                Width = 200
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Width = 200
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Rol",
                Width = 150,
                Name = "Rol"
            });
        }
        private void CargarRoles()
        {
            try
            {
                var roles = _rolController.Todos();
                cmbRol.DataSource = roles;
                cmbRol.DisplayMember = "NombreRol";
                cmbRol.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
            }
        }
        private void CargarUsuarios()
        {
            try
            {
                var usuarios = _usuarioController.Todos();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = usuarios;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.DataBoundItem is UsuarioModel usuario && usuario.Rol != null)
                    {
                        row.Cells["Rol"].Value = usuario.Rol.NombreRol;
                    }
                }

                lblTotal.Text = $"Total: {usuarios.Count} usuario(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _modoEdicion = false;
            LimpiarFormulario();
            grpDatos.Enabled = true;
            btnGuardar.Enabled = true;
            txtUsername.Focus();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_usuarioSeleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario para editar");
                return;
            }

            _modoEdicion = true;
            txtUsername.Text = _usuarioSeleccionado.Username;
            txtPassword.Text = "";
            txtNombreCompleto.Text = _usuarioSeleccionado.NombreCompleto;
            txtEmail.Text = _usuarioSeleccionado.Email;
            cmbRol.SelectedValue = _usuarioSeleccionado.RolId;

            grpDatos.Enabled = true;
            btnGuardar.Enabled = true;
            txtUsername.Focus();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_usuarioSeleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario para eliminar");
                return;
            }

            var resultado = MessageBox.Show(
                $"¿Está seguro de eliminar al usuario '{_usuarioSeleccionado.Username}'?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string res = _usuarioController.Eliminar(_usuarioSeleccionado.id);
                if (res == "ok")
                {
                    MessageBox.Show("Usuario eliminado exitosamente");
                    CargarUsuarios();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("El nombre de usuario es obligatorio");
                txtUsername.Focus();
                return;
            }

            if (!_modoEdicion && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("La contraseña es obligatoria para nuevos usuarios");
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                MessageBox.Show("El nombre completo es obligatorio");
                txtNombreCompleto.Focus();
                return;
            }

            if (cmbRol.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un rol");
                cmbRol.Focus();
                return;
            }

            UsuarioModel usuario = new UsuarioModel
            {
                id = _modoEdicion ? _usuarioSeleccionado!.id : 0,
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text,
                NombreCompleto = txtNombreCompleto.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                RolId = Convert.ToInt32(cmbRol.SelectedValue)
            };

            string res = _modoEdicion ?
                _usuarioController.Actualizar(usuario) :
                _usuarioController.Nuevo(usuario);

            if (res == "ok")
            {
                MessageBox.Show(_modoEdicion ?
                    "Usuario actualizado exitosamente" :
                    "Usuario creado exitosamente");
                CargarUsuarios();
                LimpiarFormulario();
                grpDatos.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void LimpiarFormulario()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtNombreCompleto.Clear();
            txtEmail.Clear();
            cmbRol.SelectedIndex = 0;
            _usuarioSeleccionado = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem != null)
            {
                _usuarioSeleccionado = (UsuarioModel)dataGridView1.CurrentRow.DataBoundItem;
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
