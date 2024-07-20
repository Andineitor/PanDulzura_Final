namespace Pandulzura_WinPresentacion
{
    partial class FormDetallePedido
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
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgtDetalle = new System.Windows.Forms.DataGridView();
            this.btListar = new System.Windows.Forms.Button();
            this.productid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtdetalleid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdetalleid);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.productid);
            this.groupBox1.Controls.Add(this.btListar);
            this.groupBox1.Controls.Add(this.btAgregar);
            this.groupBox1.Controls.Add(this.Cantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(718, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.Color.Salmon;
            this.btLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btLimpiar.Location = new System.Drawing.Point(623, 241);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(127, 28);
            this.btLimpiar.TabIndex = 13;
            this.btLimpiar.Text = "Limpiar campos";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btAgregar.Location = new System.Drawing.Point(31, 155);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(100, 28);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(423, 96);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(132, 22);
            this.Cantidad.TabIndex = 8;
            this.Cantidad.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(162, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLE PEDIDOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgtDetalle
            // 
            this.dgtDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDetalle.Location = new System.Drawing.Point(40, 277);
            this.dgtDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgtDetalle.Name = "dgtDetalle";
            this.dgtDetalle.RowHeadersWidth = 62;
            this.dgtDetalle.Size = new System.Drawing.Size(734, 245);
            this.dgtDetalle.TabIndex = 1;
            this.dgtDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtDetalle_CellContentClick);
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.Color.PaleGreen;
            this.btListar.Location = new System.Drawing.Point(150, 155);
            this.btListar.Margin = new System.Windows.Forms.Padding(4);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(100, 28);
            this.btListar.TabIndex = 12;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // productid
            // 
            this.productid.Location = new System.Drawing.Point(182, 93);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(100, 22);
            this.productid.TabIndex = 14;
            this.productid.TextChanged += new System.EventHandler(this.productid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID Detalle Pedido";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtdetalleid
            // 
            this.txtdetalleid.Location = new System.Drawing.Point(410, 161);
            this.txtdetalleid.Name = "txtdetalleid";
            this.txtdetalleid.Size = new System.Drawing.Size(100, 22);
            this.txtdetalleid.TabIndex = 18;
            this.txtdetalleid.TextChanged += new System.EventHandler(this.detalleid_TextChanged_1);
            // 
            // FormDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 585);
            this.Controls.Add(this.dgtDetalle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btLimpiar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDetallePedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetallePedido";
            this.Load += new System.EventHandler(this.FormDetallePedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.DataGridView dgtDetalle;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdetalleid;
        private System.Windows.Forms.Button button2;
    }
}