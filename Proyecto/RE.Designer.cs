namespace Prototipo
{
    partial class RE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.primerNombreBox = new System.Windows.Forms.TextBox();
            this.apellidoBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cargoBox = new System.Windows.Forms.TextBox();
            this.nombreDeUsuarioBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.direccionBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telefonoBox = new System.Windows.Forms.TextBox();
            this.registrarEmpleadoBoton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.contraseñaBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.registroDeEmpleado = new System.Windows.Forms.DataGridView();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrarEmpleadoBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registroDeEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // primerNombreBox
            // 
            this.primerNombreBox.Location = new System.Drawing.Point(34, 101);
            this.primerNombreBox.Name = "primerNombreBox";
            this.primerNombreBox.Size = new System.Drawing.Size(160, 20);
            this.primerNombreBox.TabIndex = 4;
            this.primerNombreBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // apellidoBox
            // 
            this.apellidoBox.Location = new System.Drawing.Point(226, 101);
            this.apellidoBox.Name = "apellidoBox";
            this.apellidoBox.Size = new System.Drawing.Size(158, 20);
            this.apellidoBox.TabIndex = 5;
            this.apellidoBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre de Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cargo";
            // 
            // cargoBox
            // 
            this.cargoBox.Location = new System.Drawing.Point(34, 185);
            this.cargoBox.Name = "cargoBox";
            this.cargoBox.Size = new System.Drawing.Size(160, 20);
            this.cargoBox.TabIndex = 8;
            // 
            // nombreDeUsuarioBox
            // 
            this.nombreDeUsuarioBox.Location = new System.Drawing.Point(410, 101);
            this.nombreDeUsuarioBox.Name = "nombreDeUsuarioBox";
            this.nombreDeUsuarioBox.Size = new System.Drawing.Size(158, 20);
            this.nombreDeUsuarioBox.TabIndex = 9;
            this.nombreDeUsuarioBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direccion";
            // 
            // direccionBox
            // 
            this.direccionBox.Location = new System.Drawing.Point(221, 185);
            this.direccionBox.Name = "direccionBox";
            this.direccionBox.Size = new System.Drawing.Size(163, 20);
            this.direccionBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefono";
            // 
            // telefonoBox
            // 
            this.telefonoBox.Location = new System.Drawing.Point(410, 185);
            this.telefonoBox.Name = "telefonoBox";
            this.telefonoBox.Size = new System.Drawing.Size(158, 20);
            this.telefonoBox.TabIndex = 13;
            // 
            // registrarEmpleadoBoton
            // 
            this.registrarEmpleadoBoton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarEmpleadoBoton.Location = new System.Drawing.Point(248, 235);
            this.registrarEmpleadoBoton.Name = "registrarEmpleadoBoton";
            this.registrarEmpleadoBoton.Size = new System.Drawing.Size(136, 49);
            this.registrarEmpleadoBoton.TabIndex = 14;
            this.registrarEmpleadoBoton.Text = "Registrar Empleado";
            this.registrarEmpleadoBoton.UseVisualStyleBackColor = true;
            this.registrarEmpleadoBoton.Click += new System.EventHandler(this.registrarEmpleadoBoton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Registro de empleado";
            // 
            // contraseñaBox
            // 
            this.contraseñaBox.Location = new System.Drawing.Point(34, 264);
            this.contraseñaBox.Name = "contraseñaBox";
            this.contraseñaBox.Size = new System.Drawing.Size(160, 20);
            this.contraseñaBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Contraseña";
            // 
            // registroDeEmpleado
            // 
            this.registroDeEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registroDeEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cargo,
            this.Usuario,
            this.Nombre,
            this.Apellido,
            this.contraseña,
            this.Direccion,
            this.Telefono});
            this.registroDeEmpleado.Location = new System.Drawing.Point(12, 304);
            this.registroDeEmpleado.Name = "registroDeEmpleado";
            this.registroDeEmpleado.Size = new System.Drawing.Size(627, 208);
            this.registroDeEmpleado.TabIndex = 19;
            this.registroDeEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registroDeEmpleado_CellContentClick);
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // contraseña
            // 
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // borrarEmpleadoBoton
            // 
            this.borrarEmpleadoBoton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarEmpleadoBoton.Location = new System.Drawing.Point(435, 235);
            this.borrarEmpleadoBoton.Name = "borrarEmpleadoBoton";
            this.borrarEmpleadoBoton.Size = new System.Drawing.Size(106, 49);
            this.borrarEmpleadoBoton.TabIndex = 14;
            this.borrarEmpleadoBoton.Text = "Borrar Empleado";
            this.borrarEmpleadoBoton.UseVisualStyleBackColor = true;
            this.borrarEmpleadoBoton.Click += new System.EventHandler(this.borrarEmpleadoBoton_Click);
            // 
            // RE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 544);
            this.Controls.Add(this.borrarEmpleadoBoton);
            this.Controls.Add(this.registroDeEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.contraseñaBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.registrarEmpleadoBoton);
            this.Controls.Add(this.telefonoBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.direccionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nombreDeUsuarioBox);
            this.Controls.Add(this.cargoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellidoBox);
            this.Controls.Add(this.primerNombreBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RE";
            this.Text = "RE";
            this.Load += new System.EventHandler(this.RE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registroDeEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox primerNombreBox;
        private System.Windows.Forms.TextBox apellidoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cargoBox;
        private System.Windows.Forms.TextBox nombreDeUsuarioBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox direccionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefonoBox;
        private System.Windows.Forms.Button registrarEmpleadoBoton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox contraseñaBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView registroDeEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button borrarEmpleadoBoton;
    }
}