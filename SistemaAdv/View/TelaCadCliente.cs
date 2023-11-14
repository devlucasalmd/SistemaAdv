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

        public TelaCadCliente()
        {
            InitializeComponent();
        }

        //private void PicBox_CadClientes_Click(object sender, EventArgs e)
        //{
        //    CmbBox_Status_SelectedIndexChanged(sender, e);
        //}

        //private void CmbBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    if (radBtn_Fisica.ToString() == "Fisica")
        //    {
        //        ClienteFisicoSelected();
        //    }
        //    else if (radBtn_Juridica.ToString() == "Juridica")
        //    {
        //        ClienteJuridicoSelected();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Selecione um tipo para o cliente");
        //    }            
        //}

        //private void ClienteFisicoSelected()
        //{
        //    ModalCadCliente modalCliente = new ModalCadCliente();
        //    modalCliente.Show();
        //}

        //private void ClienteJuridicoSelected()
        //{
        //    ModalCadFinanceiro modalCadFinanceiro = new ModalCadFinanceiro();
        //    modalCadFinanceiro.Show();
        //}
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
    }
}
