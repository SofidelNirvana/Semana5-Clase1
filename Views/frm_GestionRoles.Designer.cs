namespace Semana5_Clase1.Views
{
    partial class frm_GestionRoles
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
            dataGridView1 = new DataGridView();
            grpDatos = new GroupBox();
            lblNombreRol = new Label();
            txtNombreRol = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnCerrar = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtDescripcion);
            grpDatos.Controls.Add(lblDescripcion);
            grpDatos.Controls.Add(lblNombreRol);
            grpDatos.Controls.Add(txtNombreRol);
            grpDatos.Location = new Point(0, 156);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(338, 160);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Rol";
            grpDatos.Enter += groupBox1_Enter;
            // 
            // lblNombreRol
            // 
            lblNombreRol.AutoSize = true;
            lblNombreRol.Location = new Point(14, 28);
            lblNombreRol.Name = "lblNombreRol";
            lblNombreRol.Size = new Size(93, 15);
            lblNombreRol.TabIndex = 2;
            lblNombreRol.Text = "Nombre del Rol:";
            lblNombreRol.Click += lblNombreRol_Click;
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(7, 58);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(325, 23);
            txtNombreRol.TabIndex = 3;
            txtNombreRol.TextChanged += txtNombreRol_TextChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(14, 84);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(7, 114);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(325, 23);
            txtDescripcion.TabIndex = 5;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(7, 347);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(88, 347);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(169, 347);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(250, 347);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(331, 347);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(412, 347);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(354, 278);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(75, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Mostrar total";
            lblTotal.Click += lblTotal_Click;
            // 
            // frm_GestionRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(btnCerrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(grpDatos);
            Controls.Add(dataGridView1);
            Name = "frm_GestionRoles";
            Text = "frm_GestionRoles";
            Load += frm_GestionRoles_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox grpDatos;
        private Label lblNombreRol;
        private TextBox txtNombreRol;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnCerrar;
        private Label lblTotal;
    }
}