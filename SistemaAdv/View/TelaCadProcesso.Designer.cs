namespace SistemaAdv.View
{
    partial class TelaCadProcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadProcesso));
            this.dtGrid_Processos = new System.Windows.Forms.DataGridView();
            this.CmbBox_Processos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Processos = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PicBox_CadProcessos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Processos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_CadProcessos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid_Processos
            // 
            this.dtGrid_Processos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrid_Processos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_Processos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_Processos.Location = new System.Drawing.Point(8, 87);
            this.dtGrid_Processos.Name = "dtGrid_Processos";
            this.dtGrid_Processos.Size = new System.Drawing.Size(777, 309);
            this.dtGrid_Processos.TabIndex = 13;
            // 
            // CmbBox_Processos
            // 
            this.CmbBox_Processos.FormattingEnabled = true;
            this.CmbBox_Processos.Location = new System.Drawing.Point(42, 24);
            this.CmbBox_Processos.Name = "CmbBox_Processos";
            this.CmbBox_Processos.Size = new System.Drawing.Size(209, 21);
            this.CmbBox_Processos.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 38);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Processos
            // 
            this.Lbl_Processos.AutoSize = true;
            this.Lbl_Processos.Location = new System.Drawing.Point(42, 5);
            this.Lbl_Processos.Name = "Lbl_Processos";
            this.Lbl_Processos.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Processos.TabIndex = 16;
            this.Lbl_Processos.Text = "Processos";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(269, 22);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 17;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Location = new System.Drawing.Point(5, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 18);
            this.panel4.TabIndex = 20;
            // 
            // PicBox_CadProcessos
            // 
            this.PicBox_CadProcessos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBox_CadProcessos.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_CadProcessos.Image")));
            this.PicBox_CadProcessos.Location = new System.Drawing.Point(757, 22);
            this.PicBox_CadProcessos.Name = "PicBox_CadProcessos";
            this.PicBox_CadProcessos.Size = new System.Drawing.Size(0, 23);
            this.PicBox_CadProcessos.TabIndex = 21;
            this.PicBox_CadProcessos.TabStop = false;
            this.PicBox_CadProcessos.Click += new System.EventHandler(this.PicBox_CadProcessos_Click);
            // 
            // TelaCadProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicBox_CadProcessos);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lbl_Processos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmbBox_Processos);
            this.Controls.Add(this.dtGrid_Processos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCadProcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TelaCadProcesso";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Processos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_CadProcessos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGrid_Processos;
        private System.Windows.Forms.ComboBox CmbBox_Processos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Processos;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox PicBox_CadProcessos;
    }
}