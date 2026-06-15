namespace Semana5_Clase1.Views
{
    partial class frm_NuevoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblNuevoCliente = new Label();
            lblCedula = new Label();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 356);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(89, 32);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(107, 356);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 32);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // lblNuevoCliente
            // 
            lblNuevoCliente.AutoSize = true;
            lblNuevoCliente.Location = new Point(12, 9);
            lblNuevoCliente.Name = "lblNuevoCliente";
            lblNuevoCliente.Size = new Size(131, 25);
            lblNuevoCliente.TabIndex = 2;
            lblNuevoCliente.Text = "Nuevo Cliente";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(12, 35);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(71, 25);
            lblCedula.TabIndex = 3;
            lblCedula.Text = "Cedula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(12, 63);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(182, 32);
            txtCedula.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 126);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 32);
            txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 98);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 189);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(182, 32);
            txtDireccion.TabIndex = 8;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(12, 161);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(92, 25);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 252);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(182, 32);
            txtTelefono.TabIndex = 10;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(12, 224);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(84, 25);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(12, 315);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(182, 32);
            txtCorreo.TabIndex = 12;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(12, 287);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 25);
            lblCorreo.TabIndex = 11;
            lblCorreo.Text = "Correo";
            // 
            // frm_NuevoCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 400);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtCedula);
            Controls.Add(lblCedula);
            Controls.Add(lblNuevoCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_NuevoCliente";
            Text = "Nuevo Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblNuevoCliente;
        private Label lblCedula;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
    }
}