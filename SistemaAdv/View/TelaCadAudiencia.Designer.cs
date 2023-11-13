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
            this.dtGrid_User = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.PicBox_CadUser = new System.Windows.Forms.PictureBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.CmbBox_Filter = new System.Windows.Forms.ComboBox();
            this.Lbl_Usuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_CadUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // dtGrid_User
            // 
            this.dtGrid_User.AllowUserToAddRows = false;
            this.dtGrid_User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrid_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_User.Location = new System.Drawing.Point(20, 87);
            this.dtGrid_User.Name = "dtGrid_User";
            this.dtGrid_User.Size = new System.Drawing.Size(760, 273);
            this.dtGrid_User.TabIndex = 22;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(705, 415);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 39;
            this.BtnDelete.Text = "Excluir";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(624, 415);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 38;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // PicBox_CadUser
            // 
            this.PicBox_CadUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBox_CadUser.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_CadUser.Image")));
            this.PicBox_CadUser.Location = new System.Drawing.Point(752, 21);
            this.PicBox_CadUser.Name = "PicBox_CadUser";
            this.PicBox_CadUser.Size = new System.Drawing.Size(28, 23);
            this.PicBox_CadUser.TabIndex = 40;
            this.PicBox_CadUser.TabStop = false;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(274, 21);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 41;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
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
            ""});
            this.CmbBox_Filter.Location = new System.Drawing.Point(47, 23);
            this.CmbBox_Filter.Name = "CmbBox_Filter";
            this.CmbBox_Filter.Size = new System.Drawing.Size(209, 21);
            this.CmbBox_Filter.TabIndex = 42;
            // 
            // Lbl_Usuarios
            // 
            this.Lbl_Usuarios.AutoSize = true;
            this.Lbl_Usuarios.Location = new System.Drawing.Point(44, 6);
            this.Lbl_Usuarios.Name = "Lbl_Usuarios";
            this.Lbl_Usuarios.Size = new System.Drawing.Size(54, 13);
            this.Lbl_Usuarios.TabIndex = 43;
            this.Lbl_Usuarios.Text = "Audiencia";
            // 
            // TelaCadAudiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Usuarios);
            this.Controls.Add(this.CmbBox_Filter);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.PicBox_CadUser);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.dtGrid_User);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCadAudiencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TelaCadAudiencia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_CadUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtGrid_User;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.PictureBox PicBox_CadUser;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.ComboBox CmbBox_Filter;
        private System.Windows.Forms.Label Lbl_Usuarios;
    }
}