namespace Prototipo
{
    partial class RV
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
            this.T = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.registroDeVentas = new System.Windows.Forms.DataGridView();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TV = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.TextBox();
            this.CAV = new System.Windows.Forms.TextBox();
            this.CV = new System.Windows.Forms.TextBox();
            this.PP = new System.Windows.Forms.TextBox();
            this.CP = new System.Windows.Forms.TextBox();
            this.NC = new System.Windows.Forms.TextBox();
            this.CE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroDeVentas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(12, 12);
            this.T.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.T.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(194, 20);
            this.T.TabIndex = 4;
            this.T.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.registroDeVentas);
            this.groupBox3.Location = new System.Drawing.Point(12, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(622, 305);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registros";
            // 
            // registroDeVentas
            // 
            this.registroDeVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registroDeVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empleado,
            this.Cliente,
            this.Producto,
            this.Precio,
            this.Venta,
            this.Vendido,
            this.Descuento,
            this.Total});
            this.registroDeVentas.Location = new System.Drawing.Point(6, 19);
            this.registroDeVentas.Name = "registroDeVentas";
            this.registroDeVentas.Size = new System.Drawing.Size(610, 275);
            this.registroDeVentas.TabIndex = 0;
            this.registroDeVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registroDeVentas_CellClick);
            this.registroDeVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Codigo Empleado";
            this.Empleado.Name = "Empleado";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Nombre Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Codigo Producto";
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Producto";
            this.Precio.Name = "Precio";
            // 
            // Venta
            // 
            this.Venta.HeaderText = "Codigo de Venta";
            this.Venta.Name = "Venta";
            // 
            // Vendido
            // 
            this.Vendido.HeaderText = "Cantidad Vendido";
            this.Vendido.Name = "Vendido";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total Venta";
            this.Total.Name = "Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(523, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 136);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TV);
            this.groupBox1.Controls.Add(this.D);
            this.groupBox1.Controls.Add(this.CAV);
            this.groupBox1.Controls.Add(this.CV);
            this.groupBox1.Controls.Add(this.PP);
            this.groupBox1.Controls.Add(this.CP);
            this.groupBox1.Controls.Add(this.NC);
            this.groupBox1.Controls.Add(this.CE);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total Venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Descuentos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cant Venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cod Venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Prec producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cod Producto";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nom Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cod Empleado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TV
            // 
            this.TV.Location = new System.Drawing.Point(357, 102);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(121, 20);
            this.TV.TabIndex = 9;
            this.TV.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(357, 75);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(121, 20);
            this.D.TabIndex = 8;
            this.D.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // CAV
            // 
            this.CAV.Location = new System.Drawing.Point(357, 49);
            this.CAV.Name = "CAV";
            this.CAV.Size = new System.Drawing.Size(121, 20);
            this.CAV.TabIndex = 7;
            this.CAV.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // CV
            // 
            this.CV.Location = new System.Drawing.Point(357, 23);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(121, 20);
            this.CV.TabIndex = 5;
            this.CV.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // PP
            // 
            this.PP.Location = new System.Drawing.Point(110, 98);
            this.PP.Name = "PP";
            this.PP.Size = new System.Drawing.Size(121, 20);
            this.PP.TabIndex = 4;
            this.PP.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // CP
            // 
            this.CP.Location = new System.Drawing.Point(110, 71);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(121, 20);
            this.CP.TabIndex = 3;
            this.CP.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // NC
            // 
            this.NC.Location = new System.Drawing.Point(110, 47);
            this.NC.Name = "NC";
            this.NC.Size = new System.Drawing.Size(121, 20);
            this.NC.TabIndex = 2;
            this.NC.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(110, 19);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(121, 20);
            this.CE.TabIndex = 1;
            this.CE.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registro de Ventas:";
            // 
            // RV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(646, 505);
            this.Controls.Add(this.T);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RV";
            this.Text = "RV";
            this.Load += new System.EventHandler(this.RV_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registroDeVentas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker T;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView registroDeVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CAV;
        private System.Windows.Forms.TextBox CV;
        private System.Windows.Forms.TextBox PP;
        private System.Windows.Forms.TextBox CP;
        private System.Windows.Forms.TextBox NC;
        private System.Windows.Forms.TextBox CE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TV;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}