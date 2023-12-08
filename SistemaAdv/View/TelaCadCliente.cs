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
    public partial class TelaCadCliente : Form
    {
        // private MenuService menuService;
        private ModalCadCliente modalCliente;
        
        private ClienteService clienteService;

        public static int parentX, parentY;
        public TelaCadCliente()
        {
            InitializeComponent();
            clienteService = new ClienteService();
        }

        private void PicBox_CadClientes_Click(object sender, EventArgs e)
        {
            if (radBtn_Fisica.Checked)
            {
                AbrirModalClienteFisico();
            }
            else if (radBtn_Juridica.Checked)
            {
                AbrirModalClienteJuridico();
            }
            else
            {
                MessageBox.Show("Selecione um tipo para o cliente");
            }
        }

        private void AbrirModalClienteFisico()
        {
            OpenModal();
            UpdateDataGrid();
        }

        private void AbrirModalClienteJuridico()
        {
            ModalCadFinanceiro modalCadFinanceiro = new ModalCadFinanceiro();
            modalCadFinanceiro.ShowDialog();
        }

        public void UpdateDataGrid()
        {
            DataTable dt = new DataTable();
            dt = clienteService.ReadCliente();
            dtGrid_Cliente.DataSource = dt;
        }

        public void DeleteCliente()
        {
            if (dtGrid_Cliente.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dtGrid_Cliente.SelectedRows[0];

                // Supondo que a coluna 'CPF' está na posição 0 (ajuste conforme necessário)
                int cpfColumnIndex = 0;

                // Obtendo o valor da célula da coluna 'CPF' na linha selecionada
                string cpf = selectedRow.Cells[cpfColumnIndex].Value.ToString();

                if (!string.IsNullOrEmpty(cpf))
                {
                    if (clienteService.DeleteCliente(cpf))
                    {
                        MessageBox.Show("Deletado com sucesso!", "Aviso", MessageBoxButtons.OK);
                        UpdateDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar funcionario!", "Aviso", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum usuario selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void FilterCliente()
        {
            var tipo = CmbBox_Clientes.Text;

            if (tipo == "Fisico")
            {
                DataTable dt = clienteService.FilterClienteFisico();
                dtGrid_Cliente.DataSource = dt;
            }
            //else
            //{
            //    DataTable dt = clienteService.FilterFuncionarioJuridico();
            //    dtGrid_Cliente.DataSource = dt;
            //}
        }

        private void TelaCadCliente_Activated(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FilterCliente();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteCliente();
        }

       

        private void LnkLbl_Enderecos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            //else
            //{
            //    MessageBox.Show(
            //    "Nenhum usuario selecionado", "Aviso",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Warning
            //    );
            //}

            //OpenModal(cpf);
            UpdateDataGrid();
        }

        public void EditEndereco()
        {
            if (dtGrid_Cliente.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dtGrid_Cliente.SelectedRows[0];
                int cpf;
                //    cpf = cpf.Replace(",", "").Replace("-", "");
                if (int.TryParse(selectedRow.Cells["CPF"].Value.ToString().Replace(",", "").Replace("-", ""), out cpf))
                {
                    MessageBox.Show("CPF");
                    OpenModal(cpf);
                }
            }
            else
            {
                MessageBox.Show(
                "Nenhum usuario selecionado", "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditEndereco();
        }

        public void OpenModal(int cpf = 0)
        {
            //ModalCadCliente modal = new ModalCadCliente(cpf);
            //modal.ShowDialog();

            Form modalBackground = new Form();
            //using (ModalViewEndereco modal = new ModalViewEndereco(cpf))
            using (ModalCadCliente modal = new ModalCadCliente(cpf))
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
