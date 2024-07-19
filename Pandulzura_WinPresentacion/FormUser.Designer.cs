namespace Pandulzura_WinPresentacion
{
    partial class FormUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ce = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id Usuario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rol:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ce
            // 
            this.ce.AutoSize = true;
            this.ce.Location = new System.Drawing.Point(78, 129);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(63, 20);
            this.ce.TabIndex = 13;
            this.ce.Text = "Cedula:";
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contraseña:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(322, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(402, 65);
            this.label9.TabIndex = 20;
            this.label9.Text = "Registro Usuario";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxRol);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtContra);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ce);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 324);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(241, 58);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(103, 28);
            this.cbxRol.TabIndex = 25;
            this.cbxRol.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(684, 100);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(191, 26);
            this.txtTelefono.TabIndex = 24;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(684, 174);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(191, 26);
            this.txtDireccion.TabIndex = 23;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(684, 250);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(191, 26);
            this.txtContra.TabIndex = 22;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(684, 28);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(191, 26);
            this.txtMail.TabIndex = 21;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(210, 126);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(191, 26);
            this.txtCedula.TabIndex = 19;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(210, 202);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 26);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(235, 457);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(110, 26);
            this.txtId.TabIndex = 17;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefono:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Direccion:";
            this.label5.Click += new System.EventHandler(this.label5_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mail:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(71, 586);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 62;
            this.grid.RowTemplate.Height = 28;
            this.grid.Size = new System.Drawing.Size(854, 182);
            this.grid.TabIndex = 18;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Location = new System.Drawing.Point(230, 262);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(151, 35);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnCuser);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInsertar.Location = new System.Drawing.Point(688, 498);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(119, 35);
            this.btnInsertar.TabIndex = 20;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnIuser);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListar.Location = new System.Drawing.Point(688, 426);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(119, 36);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnLuser);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscar.Location = new System.Drawing.Point(242, 510);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 34);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(107, 510);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 34);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 802);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ce;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
    }
}