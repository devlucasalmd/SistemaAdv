namespace SistemaAdv
{
    partial class TelaCadUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadUser));
            this.PicBox_CadUser = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Lbl_Usuarios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmbBox_Filter = new System.Windows.Forms.ComboBox();
            this.dtGrid_User = new System.Windows.Forms.DataGridView();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_CadUser)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_User)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox_CadUser
            // 
            this.PicBox_CadUser.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_CadUser.Image")));
            this.PicBox_CadUser.Location = new System.Drawing.Point(768, 37);
            this.PicBox_CadUser.Name = "PicBox_CadUser";
            this.PicBox_CadUser.Size = new System.Drawing.Size(28, 23);
            this.PicBox_CadUser.TabIndex = 28;
            this.PicBox_CadUser.TabStop = false;
            this.PicBox_CadUser.Click += new System.EventHandler(this.PicBox_CadUser_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Location = new System.Drawing.Point(20, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(562, 18);
            this.panel4.TabIndex = 27;
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
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(267, 21);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 26;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Lbl_Usuarios
            // 
            this.Lbl_Usuarios.AutoSize = true;
            this.Lbl_Usuarios.Location = new System.Drawing.Point(40, 9);
            this.Lbl_Usuarios.Name = "Lbl_Usuarios";
            this.Lbl_Usuarios.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Usuarios.TabIndex = 25;
            this.Lbl_Usuarios.Text = "Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 37);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // CmbBox_Filter
            // 
            this.CmbBox_Filter.FormattingEnabled = true;
            this.CmbBox_Filter.Items.AddRange(new object[] {
            "---- Cargos ----",
            "Estagiario (a)",
            "Secretario (a)",
            "Advogado (a)",
            "Administrador (a)",
            "",
            "---- Status ----",
            "Ativo",
            "Inativo"});
            this.CmbBox_Filter.Location = new System.Drawing.Point(40, 23);
            this.CmbBox_Filter.Name = "CmbBox_Filter";
            this.CmbBox_Filter.Size = new System.Drawing.Size(209, 21);
            this.CmbBox_Filter.TabIndex = 23;
            // 
            // dtGrid_User
            // 
            this.dtGrid_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_User.Location = new System.Drawing.Point(20, 87);
            this.dtGrid_User.Name = "dtGrid_User";
            this.dtGrid_User.Size = new System.Drawing.Size(767, 273);
            this.dtGrid_User.TabIndex = 22;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(632, 386);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 29;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(713, 386);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 30;
            this.BtnDelete.Text = "Excluir";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TelaCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.PicBox_CadUser);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.dtGrid_User);
            this.Controls.Add(this.Lbl_Usuarios);
            this.Controls.Add(this.CmbBox_Filter);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCadUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadUser";
            this.Activated += new System.EventHandler(this.TelaCadUser_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_CadUser)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PicBox_CadUser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Lbl_Usuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CmbBox_Filter;
        private System.Windows.Forms.DataGridView dtGrid_User;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
    }
}