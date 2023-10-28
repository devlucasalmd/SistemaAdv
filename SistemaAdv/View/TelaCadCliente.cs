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

        private void PicBox_CadClientes_Click(object sender, EventArgs e)
        {
            //   CmbBox_Status_SelectedValueChanged();
        }

        private void CmbBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

           // string fisica = radBtn_Fisica.;
           // string juridica = radBtn_Juridica.ToString();

            //if (fisica)
            //{
            //    ModalCadCliente modalCliente = new ModalCadCliente();
            //    modalCliente.Show();
            //}
            //else if (item == "Juridica")
            //{
            //    ModalCadFinanceiro modalCadFinanceiro = new ModalCadFinanceiro();
            //    modalCadFinanceiro.Show();
            //}
            //else
            //{
            //   MessageBox.Show("Selecione um tipo para o cliente");
            //}
        }


        // private void Btn_Processos_Click(object sender, EventArgs e)
        // {
        //menuService.OpenTelaProcesso();
        // }

    }
}
