namespace Pandulzura_WinPresentacion
{
    partial class FormFactura
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
            this.EditarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textValorF = new System.Windows.Forms.TextBox();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.textFacturaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditarBtn
            // 
            this.EditarBtn.Location = new System.Drawing.Point(391, 27);
            this.EditarBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(84, 29);
            this.EditarBtn.TabIndex = 1;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseVisualStyleBackColor = true;
            this.EditarBtn.Click += new System.EventHandler(this.ListarBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(494, 27);
            this.EliminarBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(84, 29);
            this.EliminarBtn.TabIndex = 2;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(433, 124);
            this.AgregarBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(84, 29);
            this.AgregarBtn.TabIndex = 3;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(151, 302);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 229);
            this.dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha";
            // 
            // textValorF
            // 
            this.textValorF.Location = new System.Drawing.Point(173, 120);
            this.textValorF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textValorF.Name = "textValorF";
            this.textValorF.Size = new System.Drawing.Size(200, 26);
            this.textValorF.TabIndex = 5;
            // 
            // DateTime
            // 
            this.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTime.Location = new System.Drawing.Point(173, 178);
            this.DateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 26);
            this.DateTime.TabIndex = 35;
            this.DateTime.ValueChanged += new System.EventHandler(this.DateTime_ValueChanged);
            // 
            // textFacturaId
            // 
            this.textFacturaId.Location = new System.Drawing.Point(173, 27);
            this.textFacturaId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textFacturaId.Name = "textFacturaId";
            this.textFacturaId.Size = new System.Drawing.Size(158, 26);
            this.textFacturaId.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Id de factura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textFacturaId);
            this.groupBox1.Controls.Add(this.DateTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textValorF);
            this.groupBox1.Controls.Add(this.AgregarBtn);
            this.groupBox1.Controls.Add(this.EliminarBtn);
            this.groupBox1.Controls.Add(this.EditarBtn);
            this.groupBox1.Location = new System.Drawing.Point(151, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 223);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFactura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textValorF;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.TextBox textFacturaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
