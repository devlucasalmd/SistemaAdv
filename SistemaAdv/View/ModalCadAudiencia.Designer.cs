namespace SistemaAdv.View
{
    partial class ModalCadAudiencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalCadAudiencia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Min = new System.Windows.Forms.Button();
            this.Btn_Max = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNumProcesso = new System.Windows.Forms.Label();
            this.TxtBox_NumProcesso = new System.Windows.Forms.TextBox();
            this.LblLocal = new System.Windows.Forms.Label();
            this.TxtBox_LocalAudiencia = new System.Windows.Forms.TextBox();
            this.DataAudiencia = new System.Windows.Forms.DateTimePicker();
            this.LblDataProcesso = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.TxtBox_Cliente = new System.Windows.Forms.TextBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.Btn_Min);
            this.panel1.Controls.Add(this.Btn_Max);
            this.panel1.Controls.Add(this.Btn_Close);
            this.panel1.Controls.Add(this.LblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 37);
            this.panel1.TabIndex = 38;
            // 
            // Btn_Min
            // 
            this.Btn_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Min.FlatAppearance.BorderSize = 0;
            this.Btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Min.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Min.Image")));
            this.Btn_Min.Location = new System.Drawing.Point(331, 3);
            this.Btn_Min.Name = "Btn_Min";
            this.Btn_Min.Size = new System.Drawing.Size(40, 28);
            this.Btn_Min.TabIndex = 7;
            this.Btn_Min.UseVisualStyleBackColor = true;
            // 
            // Btn_Max
            // 
            this.Btn_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Max.FlatAppearance.BorderSize = 0;
            this.Btn_Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Max.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Max.Image")));
            this.Btn_Max.Location = new System.Drawing.Point(371, 3);
            this.Btn_Max.Name = "Btn_Max";
            this.Btn_Max.Size = new System.Drawing.Size(40, 28);
            this.Btn_Max.TabIndex = 6;
            this.Btn_Max.UseVisualStyleBackColor = true;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.Location = new System.Drawing.Point(410, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(40, 28);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.UseVisualStyleBackColor = true;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(3, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(80, 21);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Advocacia";
            // 
            // LblNumProcesso
            // 
            this.LblNumProcesso.AutoSize = true;
            this.LblNumProcesso.Location = new System.Drawing.Point(9, 56);
            this.LblNumProcesso.Name = "LblNumProcesso";
            this.LblNumProcesso.Size = new System.Drawing.Size(106, 13);
            this.LblNumProcesso.TabIndex = 49;
            this.LblNumProcesso.Text = "Número do Processo";
            // 
            // TxtBox_NumProcesso
            // 
            this.TxtBox_NumProcesso.Location = new System.Drawing.Point(12, 72);
            this.TxtBox_NumProcesso.Name = "TxtBox_NumProcesso";
            this.TxtBox_NumProcesso.Size = new System.Drawing.Size(172, 20);
            this.TxtBox_NumProcesso.TabIndex = 48;
            // 
            // LblLocal
            // 
            this.LblLocal.AutoSize = true;
            this.LblLocal.Location = new System.Drawing.Point(9, 137);
            this.LblLocal.Name = "LblLocal";
            this.LblLocal.Size = new System.Drawing.Size(33, 13);
            this.LblLocal.TabIndex = 51;
            this.LblLocal.Text = "Local";
            // 
            // TxtBox_LocalAudiencia
            // 
            this.TxtBox_LocalAudiencia.Location = new System.Drawing.Point(12, 153);
            this.TxtBox_LocalAudiencia.Name = "TxtBox_LocalAudiencia";
            this.TxtBox_LocalAudiencia.Size = new System.Drawing.Size(172, 20);
            this.TxtBox_LocalAudiencia.TabIndex = 50;
            // 
            // DataAudiencia
            // 
            this.DataAudiencia.Location = new System.Drawing.Point(225, 72);
            this.DataAudiencia.Name = "DataAudiencia";
            this.DataAudiencia.Size = new System.Drawing.Size(200, 20);
            this.DataAudiencia.TabIndex = 52;
            // 
            // LblDataProcesso
            // 
            this.LblDataProcesso.AutoSize = true;
            this.LblDataProcesso.Location = new System.Drawing.Point(222, 56);
            this.LblDataProcesso.Name = "LblDataProcesso";
            this.LblDataProcesso.Size = new System.Drawing.Size(30, 13);
            this.LblDataProcesso.TabIndex = 53;
            this.LblDataProcesso.Text = "Data";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(222, 137);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 55;
            this.LblCliente.Text = "Cliente";
            // 
            // TxtBox_Cliente
            // 
            this.TxtBox_Cliente.Location = new System.Drawing.Point(225, 153);
            this.TxtBox_Cliente.Name = "TxtBox_Cliente";
            this.TxtBox_Cliente.Size = new System.Drawing.Size(172, 20);
            this.TxtBox_Cliente.TabIndex = 54;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(332, 211);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(97, 23);
            this.Btn_Clear.TabIndex = 83;
            this.Btn_Clear.Text = "Limpar";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(229, 211);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(97, 23);
            this.Btn_Confirmar.TabIndex = 82;
            this.Btn_Confirmar.Text = "Salvar";
            this.Btn_Confirmar.UseVisualStyleBackColor = true;
            // 
            // ModalCadAudiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 260);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.TxtBox_Cliente);
            this.Controls.Add(this.LblDataProcesso);
            this.Controls.Add(this.DataAudiencia);
            this.Controls.Add(this.LblLocal);
            this.Controls.Add(this.TxtBox_LocalAudiencia);
            this.Controls.Add(this.LblNumProcesso);
            this.Controls.Add(this.TxtBox_NumProcesso);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalCadAudiencia";
            this.Text = "ModalCadAudiencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Min;
        private System.Windows.Forms.Button Btn_Max;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNumProcesso;
        private System.Windows.Forms.TextBox TxtBox_NumProcesso;
        private System.Windows.Forms.Label LblLocal;
        private System.Windows.Forms.TextBox TxtBox_LocalAudiencia;
        private System.Windows.Forms.DateTimePicker DataAudiencia;
        private System.Windows.Forms.Label LblDataProcesso;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox TxtBox_Cliente;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Confirmar;
    }
}