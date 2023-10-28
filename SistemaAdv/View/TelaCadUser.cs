using SistemaAdv.Models;
using SistemaAdv.Service;
using SistemaAdv.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace SistemaAdv
{
    public partial class TelaCadUser : Form
    {
        private FuncionarioService funcionarioService;
        // private MenuService menuService;


        public TelaCadUser()
        {
            InitializeComponent();
            funcionarioService = new FuncionarioService();
        }

        public static int parentX, parentY;

        public void UpdateDataGrid()
        {
            DataTable dt = new DataTable();
            dt = funcionarioService.ReadFuncionarios();
            dtGrid_User.DataSource = dt;
            dtGrid_User.Columns.Remove("Id");
        }

        public void FilterFuncionario()
        {
            var cargo = CmbBox_Filter.Text;           
            DataTable dt = funcionarioService.FilterFuncionario(cargo);        
            dtGrid_User.DataSource = dt;
        }

        public void EditFuncionario()
        {
            //funcionarioService.EditFuncionario();
        }

        private void TelaCadUser_Activated(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            FilterFuncionario();
        }

        //int index = dtGrid_User.S
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditFuncionario();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Deseja excluir o Usuario selecionado?", "Aviso",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning
            );
        }


        private void PicBox_CadUser_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using(ModalCadUser modal = new ModalCadUser())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
        }

    }
}
