using SistemaAdv.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdv.View
{
    public partial class TelaCadCliente : Form
    {
        // private MenuService menuService;

        private ClienteService clienteService;

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
            ModalCadCliente modalCliente = new ModalCadCliente();
            modalCliente.ShowDialog();
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
            dtGrid_Cliente.Columns[0].Visible = false;
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
            if (dtGrid_Cliente.SelectedRows.Count == 1)
            {
                    AbrirModalClienteFisico();
                    UpdateDataGrid();
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
    }
}
