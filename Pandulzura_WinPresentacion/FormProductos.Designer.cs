namespace Pandulzura_WinPresentacion
{
    partial class FormProductos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productoid = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.NumericUpDown();
            this.txtcate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Listar = new System.Windows.Forms.Button();
            this.disponibilidad = new System.Windows.Forms.NumericUpDown();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprod = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.producto = new System.Windows.Forms.TextBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCategoria);
            this.groupBox1.Controls.Add(this.productoid);
            this.groupBox1.Controls.Add(this.precio);
            this.groupBox1.Controls.Add(this.txtcate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.Listar);
            this.groupBox1.Controls.Add(this.disponibilidad);
            this.groupBox1.Controls.Add(this.descripcion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtprod);
            this.groupBox1.Controls.Add(this.agregar);
            this.groupBox1.Controls.Add(this.producto);
            this.groupBox1.Location = new System.Drawing.Point(38, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(816, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // productoid
            // 
            this.productoid.Location = new System.Drawing.Point(190, 97);
            this.productoid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productoid.Name = "productoid";
            this.productoid.Size = new System.Drawing.Size(106, 26);
            this.productoid.TabIndex = 17;
            this.productoid.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // precio
            // 
            this.precio.DecimalPlaces = 2;
            this.precio.Location = new System.Drawing.Point(460, 266);
            this.precio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(88, 26);
            this.precio.TabIndex = 16;
            // 
            // txtcate
            // 
            this.txtcate.AutoSize = true;
            this.txtcate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtcate.Location = new System.Drawing.Point(324, 102);
            this.txtcate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtcate.Name = "txtcate";
            this.txtcate.Size = new System.Drawing.Size(113, 20);
            this.txtcate.TabIndex = 14;
            this.txtcate.Text = "ID Categrotría";
            this.txtcate.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(344, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "PRODUCTOS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Limpiar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Location = new System.Drawing.Point(621, 174);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(154, 46);
            this.Limpiar.TabIndex = 12;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Listar
            // 
            this.Listar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Listar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Listar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listar.Location = new System.Drawing.Point(621, 265);
            this.Listar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(154, 45);
            this.Listar.TabIndex = 11;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = false;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // disponibilidad
            // 
            this.disponibilidad.Location = new System.Drawing.Point(190, 265);
            this.disponibilidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.disponibilidad.Name = "disponibilidad";
            this.disponibilidad.Size = new System.Drawing.Size(88, 26);
            this.disponibilidad.TabIndex = 10;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(190, 212);
            this.descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(205, 26);
            this.descripcion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(38, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Disponibilidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(366, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(38, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(38, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtprod
            // 
            this.txtprod.AutoSize = true;
            this.txtprod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprod.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtprod.Location = new System.Drawing.Point(38, 100);
            this.txtprod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(99, 20);
            this.txtprod.TabIndex = 2;
            this.txtprod.Text = "ID Producto";
            this.txtprod.Click += new System.EventHandler(this.label1_Click);
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.YellowGreen;
            this.agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.agregar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(621, 88);
            this.agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(154, 42);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // producto
            // 
            this.producto.Location = new System.Drawing.Point(190, 160);
            this.producto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(205, 26);
            this.producto.TabIndex = 0;
            this.producto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(27, 485);
            this.dgvProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowHeadersWidth = 62;
            this.dgvProd.Size = new System.Drawing.Size(816, 265);
            this.dgvProd.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Lime;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(80, 404);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(154, 45);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnActulizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActulizar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActulizar.Location = new System.Drawing.Point(348, 404);
            this.btnActulizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(154, 45);
            this.btnActulizar.TabIndex = 20;
            this.btnActulizar.Text = "Actualizar";
            this.btnActulizar.UseVisualStyleBackColor = false;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(628, 404);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 45);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(460, 99);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(103, 28);
            this.cbxCategoria.TabIndex = 26;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 764);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActulizar);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disponibilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox producto;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label txtprod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.NumericUpDown disponibilidad;
        private System.Windows.Forms.Button Listar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtcate;
        private System.Windows.Forms.NumericUpDown precio;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.TextBox productoid;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxCategoria;
    }
}