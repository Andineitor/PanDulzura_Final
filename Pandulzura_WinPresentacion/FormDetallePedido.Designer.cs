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
            this.btListar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.DetalleId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgtDetalle = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLimpiar);
            this.groupBox1.Controls.Add(this.btListar);
            this.groupBox1.Controls.Add(this.btAgregar);
            this.groupBox1.Controls.Add(this.Cantidad);
            this.groupBox1.Controls.Add(this.DetalleId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.Color.Salmon;
            this.btLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btLimpiar.Location = new System.Drawing.Point(166, 118);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 13;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.Color.PaleGreen;
            this.btListar.Location = new System.Drawing.Point(317, 127);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(75, 23);
            this.btListar.TabIndex = 12;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btAgregar.Location = new System.Drawing.Point(24, 118);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(317, 78);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(100, 20);
            this.Cantidad.TabIndex = 8;
            this.Cantidad.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            // 
            // DetalleId
            // 
            this.DetalleId.Location = new System.Drawing.Point(129, 72);
            this.DetalleId.Name = "DetalleId";
            this.DetalleId.Size = new System.Drawing.Size(100, 20);
            this.DetalleId.TabIndex = 6;
            this.DetalleId.TextChanged += new System.EventHandler(this.DetalleId_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Detalle de pedido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(121, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLE PEDIDOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgtDetalle
            // 
            this.dgtDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDetalle.Location = new System.Drawing.Point(30, 225);
            this.dgtDetalle.Name = "dgtDetalle";
            this.dgtDetalle.Size = new System.Drawing.Size(551, 199);
            this.dgtDetalle.TabIndex = 1;
            this.dgtDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtDetalle_CellContentClick);
            // 
            // FormDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 475);
            this.Controls.Add(this.dgtDetalle);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDetallePedido";
            this.Text = "FormDetallePedido";
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
        private System.Windows.Forms.TextBox DetalleId;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.DataGridView dgtDetalle;
    }
}