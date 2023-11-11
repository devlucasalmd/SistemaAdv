using SistemaAdv.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdv.View
{
    public partial class TelaCadProcesso : Form
    {
        public TelaCadProcesso()
        {
            InitializeComponent();
        }

        //public void UpdateDataGrid()
        //{
        //    DataTable dt = new DataTable();
        //    dt = processoService.ReadProcessos();
        //    dtGrid_Processos.DataSource = dt;
        //    dtGrid_Processos.Columns[0].Visible = false;
        //}

        //public void FilterFuncionario()
        //{
        //    var cargo = CmbBox_Filter.Text;
        //    DataTable dt = funcionarioService.FilterFuncionario(cargo);
        //    dtGrid_Processos.DataSource = dt;
        //}

        //public void DeleteFuncionario()
        //{
        //    if (dtGrid_Processos.SelectedRows.Count == 1)
        //    {
        //        DataGridViewRow selectedRow = dtGrid_Processos.SelectedRows[0];
        //        int id;
        //        if (int.TryParse(selectedRow.Cells["Id"].Value.ToString(), out id))
        //        {
        //            if (funcionarioService.DeleteFuncionario(id))
        //            {
        //                MessageBox.Show(
        //                "Deletado com sucesso!", "Aviso",
        //                MessageBoxButtons.OK
        //                 );
        //            }
        //            else
        //            {
        //                MessageBox.Show(
        //                "Erro ao deletar funcionario!", "Aviso",
        //                MessageBoxButtons.OK
        //                 );
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show(
        //        "Nenhum usuario selecionado", "Aviso",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Warning
        //    );
        //    }
        //}

        //public void EditFuncionario()
        //{
        //    if (dtGrid_Processos.SelectedRows.Count == 1)
        //    {
        //        DataGridViewRow selectedRow = dtGrid_Processos.SelectedRows[0];
        //        int id;
        //        if (int.TryParse(selectedRow.Cells["Id"].Value.ToString(), out id))
        //        {
        //            OpenModal(id);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show(
        //        "Nenhum usuario selecionado", "Aviso",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Warning
        //    );
        //    }
        //}

        public static int parentX, parentY;
        private void PicBox_CadProcessos_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (ModalCadProcesso modal = new ModalCadProcesso())
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
