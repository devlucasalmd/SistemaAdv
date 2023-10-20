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
        }

        public void FilterFuncionario()
        {
            var cargo = CmbBox_Filter.Text;           
            DataTable dt = funcionarioService.FilterFuncionario(cargo);        
            dtGrid_User.DataSource = dt;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            FilterFuncionario();
        }

        private void TelaCadUser_Load(object sender, EventArgs e)
        {
            // UpdateDataGrid();
        }

       private void Btn_Processos_Click(object sender, EventArgs e)
       {
         //   menuService.OpenTelaProcesso();
       }

        private void TelaCadUser_Activated(object sender, EventArgs e)
        {
            UpdateDataGrid();
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
