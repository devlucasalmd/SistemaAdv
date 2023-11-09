namespace SistemaAdv.View
{
    partial class TelaCadAudiencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadAudiencia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PicBox_CadAudiencia = new System.Windows.Forms.PictureBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Lbl_Clientes = new System.Windows.Forms.Label();
            this.CmbBox_Audiencia = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_CadAudiencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Location = new System.Drawing.Point(8, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 18);
            this.panel4.TabIndex = 36;
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
            // PicBox_CadAudiencia
            // 
            this.PicBox_CadAudiencia.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_CadAudiencia.Image")));
            this.PicBox_CadAudiencia.Location = new System.Drawing.Point(755, 35);
            this.PicBox_CadAudiencia.Name = "PicBox_CadAudiencia";
            this.PicBox_CadAudiencia.Size = new System.Drawing.Size(28, 23);
            this.PicBox_CadAudiencia.TabIndex = 35;
            this.PicBox_CadAudiencia.TabStop = false;
            this.PicBox_CadAudiencia.Click += new System.EventHandler(this.PicBox_CadClientes_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(267, 35);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 34;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Clientes
            // 
            this.Lbl_Clientes.AutoSize = true;
            this.Lbl_Clientes.Location = new System.Drawing.Point(40, 18);
            this.Lbl_Clientes.Name = "Lbl_Clientes";
            this.Lbl_Clientes.Size = new System.Drawing.Size(54, 13);
            this.Lbl_Clientes.TabIndex = 33;
            this.Lbl_Clientes.Text = "Audiencia";
            // 
            // CmbBox_Audiencia
            // 
            this.CmbBox_Audiencia.FormattingEnabled = true;
            this.CmbBox_Audiencia.Location = new System.Drawing.Point(40, 37);
            this.CmbBox_Audiencia.Name = "CmbBox_Audiencia";
            this.CmbBox_Audiencia.Size = new System.Drawing.Size(209, 21);
            this.CmbBox_Audiencia.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 278);
            this.dataGridView1.TabIndex = 31;
            // 
            // TelaCadAudiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PicBox_CadAudiencia);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Lbl_Clientes);
            this.Controls.Add(this.CmbBox_Audiencia);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCadAudiencia";
            this.Text = "TelaCadAudiencia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_CadAudiencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox PicBox_CadAudiencia;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Lbl_Clientes;
        private System.Windows.Forms.ComboBox CmbBox_Audiencia;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}