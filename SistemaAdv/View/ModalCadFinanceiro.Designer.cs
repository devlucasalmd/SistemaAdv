namespace SistemaAdv.View
{
    partial class ModalCadFinanceiro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalCadFinanceiro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Min = new System.Windows.Forms.Button();
            this.Btn_Max = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNumProcesso = new System.Windows.Forms.Label();
            this.TxtBox_NumProcesso = new System.Windows.Forms.TextBox();
            this.TxtBox_Acordo = new System.Windows.Forms.TextBox();
            this.LblAcordo = new System.Windows.Forms.Label();
            this.TxtBox_Honorarios = new System.Windows.Forms.TextBox();
            this.LblHonorarios = new System.Windows.Forms.Label();
            this.TxtBox_DataPgnt = new System.Windows.Forms.TextBox();
            this.LblDataPgnt = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_ValorParcela = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.panel1.Size = new System.Drawing.Size(559, 37);
            this.panel1.TabIndex = 37;
            // 
            // Btn_Min
            // 
            this.Btn_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Min.FlatAppearance.BorderSize = 0;
            this.Btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Min.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Min.Image")));
            this.Btn_Min.Location = new System.Drawing.Point(440, 3);
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
            this.Btn_Max.Location = new System.Drawing.Point(480, 3);
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
            this.Btn_Close.Location = new System.Drawing.Point(519, 3);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(40, 28);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
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
            this.LblNumProcesso.Location = new System.Drawing.Point(4, 54);
            this.LblNumProcesso.Name = "LblNumProcesso";
            this.LblNumProcesso.Size = new System.Drawing.Size(106, 13);
            this.LblNumProcesso.TabIndex = 47;
            this.LblNumProcesso.Text = "Número do Processo";
            // 
            // TxtBox_NumProcesso
            // 
            this.TxtBox_NumProcesso.Location = new System.Drawing.Point(7, 70);
            this.TxtBox_NumProcesso.Name = "TxtBox_NumProcesso";
            this.TxtBox_NumProcesso.Size = new System.Drawing.Size(172, 20);
            this.TxtBox_NumProcesso.TabIndex = 46;
            // 
            // TxtBox_Acordo
            // 
            this.TxtBox_Acordo.Location = new System.Drawing.Point(237, 70);
            this.TxtBox_Acordo.Name = "TxtBox_Acordo";
            this.TxtBox_Acordo.Size = new System.Drawing.Size(172, 20);
            this.TxtBox_Acordo.TabIndex = 72;
            // 
            // LblAcordo
            // 
            this.LblAcordo.AutoSize = true;
            this.LblAcordo.Location = new System.Drawing.Point(234, 54);
            this.LblAcordo.Name = "LblAcordo";
            this.LblAcordo.Size = new System.Drawing.Size(41, 13);
            this.LblAcordo.TabIndex = 71;
            this.LblAcordo.Text = "Acordo";
            // 
            // TxtBox_Honorarios
            // 
            this.TxtBox_Honorarios.Location = new System.Drawing.Point(7, 132);
            this.TxtBox_Honorarios.Name = "TxtBox_Honorarios";
            this.TxtBox_Honorarios.Size = new System.Drawing.Size(172, 20);
            this.TxtBox_Honorarios.TabIndex = 77;
            // 
            // LblHonorarios
            // 
            this.LblHonorarios.AutoSize = true;
            this.LblHonorarios.Location = new System.Drawing.Point(4, 116);
            this.LblHonorarios.Name = "LblHonorarios";
            this.LblHonorarios.Size = new System.Drawing.Size(58, 13);
            this.LblHonorarios.TabIndex = 76;
            this.LblHonorarios.Text = "Honorarios";
            // 
            // TxtBox_DataPgnt
            // 
            this.TxtBox_DataPgnt.Location = new System.Drawing.Point(7, 250);
            this.TxtBox_DataPgnt.Name = "TxtBox_DataPgnt";
            this.TxtBox_DataPgnt.Size = new System.Drawing.Size(172, 20);
            this.TxtBox_DataPgnt.TabIndex = 79;
            // 
            // LblDataPgnt
            // 
            this.LblDataPgnt.AutoSize = true;
            this.LblDataPgnt.Location = new System.Drawing.Point(4, 234);
            this.LblDataPgnt.Name = "LblDataPgnt";
            this.LblDataPgnt.Size = new System.Drawing.Size(87, 13);
            this.LblDataPgnt.TabIndex = 78;
            this.LblDataPgnt.Text = "Data Pagamento";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(429, 292);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(97, 23);
            this.Btn_Clear.TabIndex = 81;
            this.Btn_Clear.Text = "Limpar";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(326, 292);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(97, 23);
            this.Btn_Confirmar.TabIndex = 80;
            this.Btn_Confirmar.Text = "Salvar";
            this.Btn_Confirmar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox1.Location = new System.Drawing.Point(237, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Parcelas";
            // 
            // TxtBox_ValorParcela
            // 
            this.TxtBox_ValorParcela.Location = new System.Drawing.Point(7, 190);
            this.TxtBox_ValorParcela.Name = "TxtBox_ValorParcela";
            this.TxtBox_ValorParcela.Size = new System.Drawing.Size(172, 20);
            this.TxtBox_ValorParcela.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Valor da Parcela";
            // 
            // modalEffect_Timer
            // 
            this.modalEffect_Timer.Enabled = true;
            this.modalEffect_Timer.Interval = 1;
            this.modalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // ModalCadFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 340);
            this.Controls.Add(this.TxtBox_ValorParcela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.TxtBox_DataPgnt);
            this.Controls.Add(this.LblDataPgnt);
            this.Controls.Add(this.TxtBox_Honorarios);
            this.Controls.Add(this.LblHonorarios);
            this.Controls.Add(this.TxtBox_Acordo);
            this.Controls.Add(this.LblAcordo);
            this.Controls.Add(this.LblNumProcesso);
            this.Controls.Add(this.TxtBox_NumProcesso);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalCadFinanceiro";
            this.Text = "ModalCadFinanceiro";
            this.Load += new System.EventHandler(this.ModalCadFinanceiro_Load);
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
        private System.Windows.Forms.TextBox TxtBox_Acordo;
        private System.Windows.Forms.Label LblAcordo;
        private System.Windows.Forms.TextBox TxtBox_Honorarios;
        private System.Windows.Forms.Label LblHonorarios;
        private System.Windows.Forms.TextBox TxtBox_DataPgnt;
        private System.Windows.Forms.Label LblDataPgnt;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_ValorParcela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private System.Windows.Forms.Timer timer1;
    }
}