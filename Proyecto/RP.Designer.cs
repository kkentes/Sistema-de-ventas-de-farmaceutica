namespace Prototipo
{
    partial class RP
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
            this.registroDeProducto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codigoProductoBox = new System.Windows.Forms.TextBox();
            this.nombreProductoBox = new System.Windows.Forms.TextBox();
            this.clasificacionBox = new System.Windows.Forms.TextBox();
            this.adicionarBoton = new System.Windows.Forms.Button();
            this.borrarBoton = new System.Windows.Forms.Button();
            this.precioBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descuentoBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registroDeProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // registroDeProducto
            // 
            this.registroDeProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registroDeProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tipo,
            this.Precio,
            this.Porcentaje});
            this.registroDeProducto.Location = new System.Drawing.Point(56, 228);
            this.registroDeProducto.Name = "registroDeProducto";
            this.registroDeProducto.Size = new System.Drawing.Size(553, 304);
            this.registroDeProducto.TabIndex = 0;
            this.registroDeProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.registroDeProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo de Producto";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Producto";
            this.Nombre.Name = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Clasificacion del Producto";
            this.Tipo.Name = "Tipo";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "%Descuento";
            this.Porcentaje.Name = "Porcentaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clasificacion ";
            // 
            // codigoProductoBox
            // 
            this.codigoProductoBox.Location = new System.Drawing.Point(220, 53);
            this.codigoProductoBox.Name = "codigoProductoBox";
            this.codigoProductoBox.Size = new System.Drawing.Size(100, 20);
            this.codigoProductoBox.TabIndex = 4;
            this.codigoProductoBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nombreProductoBox
            // 
            this.nombreProductoBox.Location = new System.Drawing.Point(220, 92);
            this.nombreProductoBox.Name = "nombreProductoBox";
            this.nombreProductoBox.Size = new System.Drawing.Size(100, 20);
            this.nombreProductoBox.TabIndex = 5;
            // 
            // clasificacionBox
            // 
            this.clasificacionBox.Location = new System.Drawing.Point(220, 136);
            this.clasificacionBox.Name = "clasificacionBox";
            this.clasificacionBox.Size = new System.Drawing.Size(100, 20);
            this.clasificacionBox.TabIndex = 6;
            // 
            // adicionarBoton
            // 
            this.adicionarBoton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarBoton.Location = new System.Drawing.Point(191, 179);
            this.adicionarBoton.Name = "adicionarBoton";
            this.adicionarBoton.Size = new System.Drawing.Size(94, 33);
            this.adicionarBoton.TabIndex = 7;
            this.adicionarBoton.Text = "Adicionar";
            this.adicionarBoton.UseVisualStyleBackColor = true;
            this.adicionarBoton.Click += new System.EventHandler(this.button1_Click);
            // 
            // borrarBoton
            // 
            this.borrarBoton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarBoton.Location = new System.Drawing.Point(360, 179);
            this.borrarBoton.Name = "borrarBoton";
            this.borrarBoton.Size = new System.Drawing.Size(93, 33);
            this.borrarBoton.TabIndex = 8;
            this.borrarBoton.Text = "Borrar";
            this.borrarBoton.UseVisualStyleBackColor = true;
            this.borrarBoton.Click += new System.EventHandler(this.button2_Click);
            // 
            // precioBox
            // 
            this.precioBox.Location = new System.Drawing.Point(442, 57);
            this.precioBox.Name = "precioBox";
            this.precioBox.Size = new System.Drawing.Size(100, 20);
            this.precioBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // descuentoBox
            // 
            this.descuentoBox.Location = new System.Drawing.Point(442, 96);
            this.descuentoBox.Name = "descuentoBox";
            this.descuentoBox.Size = new System.Drawing.Size(100, 20);
            this.descuentoBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descuento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(232, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Registrar producto";
            // 
            // RP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 544);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descuentoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.precioBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.borrarBoton);
            this.Controls.Add(this.adicionarBoton);
            this.Controls.Add(this.clasificacionBox);
            this.Controls.Add(this.nombreProductoBox);
            this.Controls.Add(this.codigoProductoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registroDeProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RP";
            this.Text = "RP";
            this.Load += new System.EventHandler(this.RP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registroDeProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView registroDeProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codigoProductoBox;
        private System.Windows.Forms.TextBox nombreProductoBox;
        private System.Windows.Forms.TextBox clasificacionBox;
        private System.Windows.Forms.Button adicionarBoton;
        private System.Windows.Forms.Button borrarBoton;
        private System.Windows.Forms.TextBox precioBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descuentoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}