namespace SistemaAdv.View
{
    partial class TelaCadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadCliente));
            this.PicBox_CadClientes = new System.Windows.Forms.PictureBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.Lbl_Clientes = new System.Windows.Forms.Label();
            this.CmbBox_Clientes = new System.Windows.Forms.ComboBox();
            this.dtGrid_Cliente = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radBtn_Juridica = new System.Windows.Forms.RadioButton();
            this.radBtn_Fisica = new System.Windows.Forms.RadioButton();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.LnkLbl_Enderecos = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_CadClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Cliente)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBox_CadClientes
            // 
            this.PicBox_CadClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBox_CadClientes.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_CadClientes.Image")));
            this.PicBox_CadClientes.Location = new System.Drawing.Point(752, 21);
            this.PicBox_CadClientes.Name = "PicBox_CadClientes";
            this.PicBox_CadClientes.Size = new System.Drawing.Size(28, 23);
            this.PicBox_CadClientes.TabIndex = 28;
            this.PicBox_CadClientes.TabStop = false;
            this.PicBox_CadClientes.Click += new System.EventHandler(this.PicBox_CadClientes_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(274, 21);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 27;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // Lbl_Clientes
            // 
            this.Lbl_Clientes.AutoSize = true;
            this.Lbl_Clientes.Location = new System.Drawing.Point(44, 6);
            this.Lbl_Clientes.Name = "Lbl_Clientes";
            this.Lbl_Clientes.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Clientes.TabIndex = 26;
            this.Lbl_Clientes.Text = "Clientes";
            // 
            // CmbBox_Clientes
            // 
            this.CmbBox_Clientes.FormattingEnabled = true;
            this.CmbBox_Clientes.Items.AddRange(new object[] {
            "Fisico",
            "Juridico"});
            this.CmbBox_Clientes.Location = new System.Drawing.Point(47, 23);
            this.CmbBox_Clientes.Name = "CmbBox_Clientes";
            this.CmbBox_Clientes.Size = new System.Drawing.Size(209, 21);
            this.CmbBox_Clientes.TabIndex = 25;
            // 
            // dtGrid_Cliente
            // 
            this.dtGrid_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrid_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_Cliente.Location = new System.Drawing.Point(20, 87);
            this.dtGrid_Cliente.Name = "dtGrid_Cliente";
            this.dtGrid_Cliente.Size = new System.Drawing.Size(760, 273);
            this.dtGrid_Cliente.TabIndex = 24;
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
            this.panel4.Location = new System.Drawing.Point(20, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(562, 18);
            this.panel4.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.radBtn_Juridica);
            this.panel5.Controls.Add(this.radBtn_Fisica);
            this.panel5.Location = new System.Drawing.Point(669, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(82, 42);
            this.panel5.TabIndex = 70;
            // 
            // radBtn_Juridica
            // 
            this.radBtn_Juridica.AutoSize = true;
            this.radBtn_Juridica.Location = new System.Drawing.Point(12, 24);
            this.radBtn_Juridica.Name = "radBtn_Juridica";
            this.radBtn_Juridica.Size = new System.Drawing.Size(61, 17);
            this.radBtn_Juridica.TabIndex = 1;
            this.radBtn_Juridica.TabStop = true;
            this.radBtn_Juridica.Text = "Juridica";
            this.radBtn_Juridica.UseVisualStyleBackColor = true;
            // 
            // radBtn_Fisica
            // 
            this.radBtn_Fisica.AutoSize = true;
            this.radBtn_Fisica.Location = new System.Drawing.Point(12, 1);
            this.radBtn_Fisica.Name = "radBtn_Fisica";
            this.radBtn_Fisica.Size = new System.Drawing.Size(52, 17);
            this.radBtn_Fisica.TabIndex = 0;
            this.radBtn_Fisica.TabStop = true;
            this.radBtn_Fisica.Text = "Fisica";
            this.radBtn_Fisica.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(705, 415);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 72;
            this.BtnDelete.Text = "Excluir";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(624, 415);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 71;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // LnkLbl_Enderecos
            // 
            this.LnkLbl_Enderecos.ActiveLinkColor = System.Drawing.SystemColors.ScrollBar;
            this.LnkLbl_Enderecos.AutoSize = true;
            this.LnkLbl_Enderecos.LinkColor = System.Drawing.Color.Black;
            this.LnkLbl_Enderecos.Location = new System.Drawing.Point(722, 71);
            this.LnkLbl_Enderecos.Name = "LnkLbl_Enderecos";
            this.LnkLbl_Enderecos.Size = new System.Drawing.Size(58, 13);
            this.LnkLbl_Enderecos.TabIndex = 73;
            this.LnkLbl_Enderecos.TabStop = true;
            this.LnkLbl_Enderecos.Text = "Endereços";
            // 
            // TelaCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LnkLbl_Enderecos);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PicBox_CadClientes);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.Lbl_Clientes);
            this.Controls.Add(this.CmbBox_Clientes);
            this.Controls.Add(this.dtGrid_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "8";
            this.Activated += new System.EventHandler(this.TelaCadCliente_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_CadClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Cliente)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox_CadClientes;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label Lbl_Clientes;
        private System.Windows.Forms.ComboBox CmbBox_Clientes;
        private System.Windows.Forms.DataGridView dtGrid_Cliente;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radBtn_Fisica;
        private System.Windows.Forms.RadioButton radBtn_Juridica;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.LinkLabel LnkLbl_Enderecos;
    }
}