namespace Pandulzura_WinPresentacion
{
    partial class FormPedidos
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
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.dvgListarPedidos = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxUser
            // 
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(253, 76);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(227, 28);
            this.cbxUser.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Estado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(253, 176);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 28);
            this.cbxEstado.TabIndex = 35;
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(280, 127);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 26);
            this.DateTime.TabIndex = 34;
            // 
            // dvgListarPedidos
            // 
            this.dvgListarPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListarPedidos.Location = new System.Drawing.Point(43, 250);
            this.dvgListarPedidos.Name = "dvgListarPedidos";
            this.dvgListarPedidos.RowHeadersWidth = 62;
            this.dvgListarPedidos.RowTemplate.Height = 28;
            this.dvgListarPedidos.Size = new System.Drawing.Size(715, 184);
            this.dvgListarPedidos.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(560, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 32;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 31;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(560, 24);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(106, 33);
            this.BtnAceptar.TabIndex = 30;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Usuario";
            // 
            // txtPedido
            // 
            this.txtPedido.Enabled = false;
            this.txtPedido.Location = new System.Drawing.Point(253, 16);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(100, 26);
            this.txtPedido.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "PedidoID";
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.dvgListarPedidos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.label1);
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListarPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.DataGridView dvgListarPedidos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label label1;
    }
}