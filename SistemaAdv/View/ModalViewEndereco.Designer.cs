namespace SistemaAdv.View
{
    partial class ModalViewEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalViewEndereco));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Min = new System.Windows.Forms.Button();
            this.Btn_Max = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Btn_BuscarCEP = new System.Windows.Forms.Button();
            this.mskdBox_CEP = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_Estado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtBox_Municipio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtBox_Comple = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBox_Bairro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtBox_Numero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtBox_Logadouro = new System.Windows.Forms.TextBox();
            this.LblCEP = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(363, 37);
            this.panel1.TabIndex = 52;
            // 
            // Btn_Min
            // 
            this.Btn_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Min.FlatAppearance.BorderSize = 0;
            this.Btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Min.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Min.Image")));
            this.Btn_Min.Location = new System.Drawing.Point(244, 3);
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
            this.Btn_Max.Location = new System.Drawing.Point(284, 3);
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
            this.Btn_Close.Location = new System.Drawing.Point(323, 3);
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
            // Btn_BuscarCEP
            // 
            this.Btn_BuscarCEP.Location = new System.Drawing.Point(162, 69);
            this.Btn_BuscarCEP.Name = "Btn_BuscarCEP";
            this.Btn_BuscarCEP.Size = new System.Drawing.Size(97, 23);
            this.Btn_BuscarCEP.TabIndex = 122;
            this.Btn_BuscarCEP.Text = "Buscar";
            this.Btn_BuscarCEP.UseVisualStyleBackColor = true;
            // 
            // mskdBox_CEP
            // 
            this.mskdBox_CEP.Location = new System.Drawing.Point(14, 71);
            this.mskdBox_CEP.Mask = "00000-000";
            this.mskdBox_CEP.Name = "mskdBox_CEP";
            this.mskdBox_CEP.Size = new System.Drawing.Size(100, 20);
            this.mskdBox_CEP.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Estado";
            // 
            // TxtBox_Estado
            // 
            this.TxtBox_Estado.Location = new System.Drawing.Point(150, 222);
            this.TxtBox_Estado.Name = "TxtBox_Estado";
            this.TxtBox_Estado.Size = new System.Drawing.Size(121, 20);
            this.TxtBox_Estado.TabIndex = 119;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 118;
            this.label15.Text = "Município";
            // 
            // TxtBox_Municipio
            // 
            this.TxtBox_Municipio.Location = new System.Drawing.Point(14, 222);
            this.TxtBox_Municipio.Name = "TxtBox_Municipio";
            this.TxtBox_Municipio.Size = new System.Drawing.Size(121, 20);
            this.TxtBox_Municipio.TabIndex = 117;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(212, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 116;
            this.label16.Text = "Complemento";
            // 
            // TxtBox_Comple
            // 
            this.TxtBox_Comple.Location = new System.Drawing.Point(215, 131);
            this.TxtBox_Comple.Name = "TxtBox_Comple";
            this.TxtBox_Comple.Size = new System.Drawing.Size(121, 20);
            this.TxtBox_Comple.TabIndex = 115;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 114;
            this.label13.Text = "Bairro";
            // 
            // TxtBox_Bairro
            // 
            this.TxtBox_Bairro.Location = new System.Drawing.Point(14, 176);
            this.TxtBox_Bairro.Name = "TxtBox_Bairro";
            this.TxtBox_Bairro.Size = new System.Drawing.Size(121, 20);
            this.TxtBox_Bairro.TabIndex = 113;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(147, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 112;
            this.label14.Text = "Número";
            // 
            // TxtBox_Numero
            // 
            this.TxtBox_Numero.Location = new System.Drawing.Point(150, 131);
            this.TxtBox_Numero.Name = "TxtBox_Numero";
            this.TxtBox_Numero.Size = new System.Drawing.Size(27, 20);
            this.TxtBox_Numero.TabIndex = 111;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 110;
            this.label12.Text = "Logadouro";
            // 
            // TxtBox_Logadouro
            // 
            this.TxtBox_Logadouro.Location = new System.Drawing.Point(14, 131);
            this.TxtBox_Logadouro.Name = "TxtBox_Logadouro";
            this.TxtBox_Logadouro.Size = new System.Drawing.Size(121, 20);
            this.TxtBox_Logadouro.TabIndex = 109;
            // 
            // LblCEP
            // 
            this.LblCEP.AutoSize = true;
            this.LblCEP.Location = new System.Drawing.Point(11, 55);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(28, 13);
            this.LblCEP.TabIndex = 108;
            this.LblCEP.Text = "CEP";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(269, 248);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(67, 23);
            this.Btn_Clear.TabIndex = 124;
            this.Btn_Clear.Text = "Limpar";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(192, 248);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(67, 23);
            this.BtnConfirmar.TabIndex = 123;
            this.BtnConfirmar.Text = "Salvar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // ModalViewEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 282);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.Btn_BuscarCEP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mskdBox_CEP);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblCEP);
            this.Controls.Add(this.TxtBox_Estado);
            this.Controls.Add(this.TxtBox_Logadouro);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtBox_Municipio);
            this.Controls.Add(this.TxtBox_Numero);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtBox_Comple);
            this.Controls.Add(this.TxtBox_Bairro);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalViewEndereco";
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
        private System.Windows.Forms.Button Btn_BuscarCEP;
        private System.Windows.Forms.MaskedTextBox mskdBox_CEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_Estado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtBox_Municipio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtBox_Comple;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBox_Bairro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtBox_Numero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtBox_Logadouro;
        private System.Windows.Forms.Label LblCEP;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button BtnConfirmar;
    }
}