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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PicBox_CadUser = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CheckBox_Inativo = new System.Windows.Forms.CheckBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Lbl_Usuarios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmbBox_Filter = new System.Windows.Forms.ComboBox();
            this.dtGrid_User = new System.Windows.Forms.DataGridView();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.Lbl_Inativo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_CadUser)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_User)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox_CadUser
            // 
            this.PicBox_CadUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBox_CadUser.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_CadUser.Image")));
            this.PicBox_CadUser.Location = new System.Drawing.Point(752, 21);
            this.PicBox_CadUser.Name = "PicBox_CadUser";
            this.PicBox_CadUser.Size = new System.Drawing.Size(28, 23);
            this.PicBox_CadUser.TabIndex = 28;
            this.PicBox_CadUser.TabStop = false;
            this.PicBox_CadUser.Click += new System.EventHandler(this.PicBox_CadUser_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Lbl_Inativo);
            this.panel4.Controls.Add(this.CheckBox_Inativo);
            this.panel4.Location = new System.Drawing.Point(20, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(562, 18);
            this.panel4.TabIndex = 27;
            // 
            // CheckBox_Inativo
            // 
            this.CheckBox_Inativo.AutoSize = true;
            this.CheckBox_Inativo.Location = new System.Drawing.Point(3, 2);
            this.CheckBox_Inativo.Name = "CheckBox_Inativo";
            this.CheckBox_Inativo.Size = new System.Drawing.Size(15, 14);
            this.CheckBox_Inativo.TabIndex = 19;
            this.CheckBox_Inativo.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(274, 21);
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
            this.Lbl_Usuarios.Location = new System.Drawing.Point(44, 6);
            this.Lbl_Usuarios.Name = "Lbl_Usuarios";
            this.Lbl_Usuarios.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Usuarios.TabIndex = 25;
            this.Lbl_Usuarios.Text = "Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
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
            ""});
            this.CmbBox_Filter.Location = new System.Drawing.Point(47, 23);
            this.CmbBox_Filter.Name = "CmbBox_Filter";
            this.CmbBox_Filter.Size = new System.Drawing.Size(209, 21);
            this.CmbBox_Filter.TabIndex = 23;
            // 
            // dtGrid_User
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dtGrid_User.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrid_User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrid_User.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGrid_User.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrid_User.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrid_User.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrid_User.EnableHeadersVisualStyles = false;
            this.dtGrid_User.Location = new System.Drawing.Point(20, 87);
            this.dtGrid_User.Name = "dtGrid_User";
            this.dtGrid_User.RowTemplate.Height = 25;
            this.dtGrid_User.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrid_User.Size = new System.Drawing.Size(760, 273);
            this.dtGrid_User.TabIndex = 22;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(624, 415);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 29;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(705, 415);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 30;
            this.BtnDelete.Text = "Excluir";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Lbl_Inativo
            // 
            this.Lbl_Inativo.AutoSize = true;
            this.Lbl_Inativo.Location = new System.Drawing.Point(16, 2);
            this.Lbl_Inativo.Name = "Lbl_Inativo";
            this.Lbl_Inativo.Size = new System.Drawing.Size(39, 13);
            this.Lbl_Inativo.TabIndex = 20;
            this.Lbl_Inativo.Text = "Inativo";
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.CheckBox CheckBox_Inativo;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label Lbl_Usuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CmbBox_Filter;
        private System.Windows.Forms.DataGridView dtGrid_User;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label Lbl_Inativo;
    }
}