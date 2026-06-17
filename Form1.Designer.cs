namespace Semana5_Clase1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            lblClientes = new Label();
            dataGridView1 = new DataGridView();
            btnRoles = new Button();
            btnUsuarios = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(13, 258);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(87, 35);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(106, 258);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 35);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(206, 258);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(87, 35);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(299, 258);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 35);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(13, 9);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(148, 25);
            lblClientes.TabIndex = 4;
            lblClientes.Text = "Lista de Clientes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(790, 215);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRoles
            // 
            btnRoles.Location = new Point(13, 299);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(188, 35);
            btnRoles.TabIndex = 7;
            btnRoles.Text = "Gestión de Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(207, 299);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(288, 35);
            btnUsuarios.TabIndex = 8;
            btnUsuarios.Text = "Gestión de Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(400, 258);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 35);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 430);
            Controls.Add(btnSalir);
            Controls.Add(btnUsuarios);
            Controls.Add(btnRoles);
            Controls.Add(dataGridView1);
            Controls.Add(lblClientes);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnCancelar;
        private Label lblClientes;
        private DataGridView dataGridView1;
        private Button btnRoles;
        private Button btnUsuarios;
        private Button btnSalir;
    }
}
