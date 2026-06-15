

using Semana5_Clase1.Controllers;
using Semana5_Clase1.Models;

namespace Semana5_Clase1.Views
{
    public partial class frm_NuevoCliente : Form
    {
        private readonly ClienteControllers _clienteControllers;
        public frm_NuevoCliente()
        {
            InitializeComponent();
            _clienteControllers = new ClienteControllers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteModel clienteModel = new ClienteModel
            {
                Cedula = txtCedula.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim()
            };
            string res = _clienteControllers.nuevo(clienteModel);
            if (res == "ok")
            {
                MessageBox.Show("Se guardo con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar. " + res);
            }
        }

    }
}
