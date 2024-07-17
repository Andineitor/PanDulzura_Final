namespace Pandulzura_WinPresentacion
{
    partial class FormCategorias
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
            this.idCategoria = new System.Windows.Forms.TextBox();
            this.limpiarbt = new System.Windows.Forms.Button();
            this.agregarbt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoria = new System.Windows.Forms.TextBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.listarbt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idCategoria);
            this.groupBox1.Controls.Add(this.limpiarbt);
            this.groupBox1.Controls.Add(this.agregarbt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.categoria);
            this.groupBox1.Location = new System.Drawing.Point(72, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(776, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // idCategoria
            // 
            this.idCategoria.Location = new System.Drawing.Point(322, 78);
            this.idCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.Size = new System.Drawing.Size(151, 26);
            this.idCategoria.TabIndex = 7;
            // 
            // limpiarbt
            // 
            this.limpiarbt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.limpiarbt.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarbt.Location = new System.Drawing.Point(597, 137);
            this.limpiarbt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.limpiarbt.Name = "limpiarbt";
            this.limpiarbt.Size = new System.Drawing.Size(141, 40);
            this.limpiarbt.TabIndex = 6;
            this.limpiarbt.Text = "Limpiar";
            this.limpiarbt.UseVisualStyleBackColor = false;
            this.limpiarbt.Click += new System.EventHandler(this.limpiarbt_Click);
            // 
            // agregarbt
            // 
            this.agregarbt.BackColor = System.Drawing.Color.YellowGreen;
            this.agregarbt.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarbt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.agregarbt.Location = new System.Drawing.Point(597, 72);
            this.agregarbt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agregarbt.Name = "agregarbt";
            this.agregarbt.Size = new System.Drawing.Size(141, 40);
            this.agregarbt.TabIndex = 5;
            this.agregarbt.Text = "Agregar";
            this.agregarbt.UseVisualStyleBackColor = false;
            this.agregarbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(129, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(112, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(309, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "CATEGORIAS";
            // 
            // categoria
            // 
            this.categoria.Location = new System.Drawing.Point(315, 134);
            this.categoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(160, 26);
            this.categoria.TabIndex = 0;
            this.categoria.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(18, 362);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RowHeadersWidth = 62;
            this.dgvCategoria.Size = new System.Drawing.Size(876, 251);
            this.dgvCategoria.TabIndex = 1;
            this.dgvCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellContentClick);
            // 
            // listarbt
            // 
            this.listarbt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.listarbt.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarbt.Location = new System.Drawing.Point(408, 295);
            this.listarbt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listarbt.Name = "listarbt";
            this.listarbt.Size = new System.Drawing.Size(141, 40);
            this.listarbt.TabIndex = 2;
            this.listarbt.Text = "Listar";
            this.listarbt.UseVisualStyleBackColor = false;
            this.listarbt.Click += new System.EventHandler(this.listarbt_Click);
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 654);
            this.Controls.Add(this.listarbt);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.TextBox categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiarbt;
        private System.Windows.Forms.Button agregarbt;
        private System.Windows.Forms.Button listarbt;
        private System.Windows.Forms.TextBox idCategoria;
    }
}