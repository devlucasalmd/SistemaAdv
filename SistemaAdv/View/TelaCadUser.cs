﻿using SistemaAdv.Models;
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
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Printing;
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace SistemaAdv
{
    public partial class TelaCadUser : Form
    {
        private FuncionarioService funcionarioService;
        // private MenuService menuService;

        public static int parentX, parentY;
        string cargo = "";
        string status = "Ativo";
        public TelaCadUser()
        {
            InitializeComponent();
            funcionarioService = new FuncionarioService();
        }        

        public void UpdateDataGrid()
        {
            DataTable dt = new DataTable();
            dt = funcionarioService.FilterFuncionario(cargo, status);
            dtGrid_User.DataSource = dt;
            dtGrid_User.Columns[0].Visible = false;            
        }

        public void FilterFuncionario()
        {
            var cargo = CmbBox_Filter.Text;

            if (CheckBox_Inativo.Checked)
            {
                var status = "Inativo";
                DataTable dt = funcionarioService.FilterFuncionario(cargo, status);
                dtGrid_User.DataSource = dt;
            }
            else
            {
                var status = "Ativo";
                DataTable dt = funcionarioService.FilterFuncionario(cargo, status);
                dtGrid_User.DataSource = dt;
            }
        }

        public void DeleteFuncionario()
        {
            if (dtGrid_User.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dtGrid_User.SelectedRows[0];
                int id;
                if (int.TryParse(selectedRow.Cells["Id"].Value.ToString(), out id))
                {
                    if (funcionarioService.DeleteFuncionario(id))
                    {
                        MessageBox.Show(
                        "Deletado com sucesso!", "Aviso",
                        MessageBoxButtons.OK
                         );
                        UpdateDataGrid();
                    }
                    else
                    {
                        MessageBox.Show(
                        "Erro ao deletar funcionario!", "Aviso",
                        MessageBoxButtons.OK
                         );
                    }
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

        public void EditFuncionario()
        {
            if (dtGrid_User.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dtGrid_User.SelectedRows[0];
                int id;
                if(int.TryParse(selectedRow.Cells["Id"].Value.ToString(), out id))
                {
                    OpenModal(id);
                    UpdateDataGrid();
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

        private void TelaCadUser_Activated(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(CmbBox_Filter.Text))
            //{
            //    UpdateDataGrid();
            //}                
            //else
            //{
            //    FilterFuncionario();
            //}
            FilterFuncionario();
        }

        
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditFuncionario();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteFuncionario();
        }

        public void OpenModal(int id = 0)
        {
            Form modalBackground = new Form();
            using (ModalCadUser modal = new ModalCadUser(id))
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

        private void LnkLbl_Relatorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(this.DesenharRelatorio);

                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = pd;
                previewDialog.ShowDialog();
            }           
        }

        private void DesenharRelatorio(object sender, PrintPageEventArgs e)
        {
            // Desenhe o conteúdo do relatório usando GDI+
            Graphics g = e.Graphics;
            Font fonte = new Font("Arial", 12);
            float linhaAtual = 20;
            DataTable dados = null;

            if (dtGrid_User.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dtGrid_User.SelectedRows[0];
                int id;
                if (int.TryParse(selectedRow.Cells["Id"].Value.ToString(), out id))
                {
                   dados = funcionarioService.GetFuncionario(id);
                    foreach (DataRow row in dados.Rows)
                    {
                        g.DrawString($"Nome: {row["Nome"]}", fonte, Brushes.Black, new PointF(100, linhaAtual));
                        linhaAtual += 20;

                        g.DrawString($"UserName: {row["UserName"]}", fonte, Brushes.Black, new PointF(100, linhaAtual));
                        linhaAtual += 20;

                        g.DrawString($"Email: {row["Email"]}", fonte, Brushes.Black, new PointF(100, linhaAtual));
                        linhaAtual += 20;

                        g.DrawString($"Cargo: {row["Cargo"]}", fonte, Brushes.Black, new PointF(100, linhaAtual));
                        linhaAtual += 20;

                        g.DrawString($"Status: {row["Status"]}", fonte, Brushes.Black, new PointF(100, linhaAtual));
                        linhaAtual += 20;

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


        }

        private void PicBox_CadUser_Click(object sender, EventArgs e)
        {
           OpenModal();
           UpdateDataGrid();
        }

    }
}
