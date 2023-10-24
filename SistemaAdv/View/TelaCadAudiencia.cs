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
    public partial class TelaCadAudiencia : Form
    {
        // private MenuService menuService;
        public TelaCadAudiencia()
        {
            InitializeComponent();
        }


        public static int parentX, parentY;

         private void Btn_Processos_Click(object sender, EventArgs e)
         {
            TelaCadProcesso telaCadProcesso = new TelaCadProcesso();
            telaCadProcesso.Show();
            this.Visible = false;
            // menuService.OpenTelaProcesso();
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TelaInicial telaInicial = new TelaInicial();            
            telaInicial.Show();
        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TelaCadUser telaCadUser = new TelaCadUser();
            telaCadUser.Show();
        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TelaCadCliente telaCadCliente = new TelaCadCliente();
            telaCadCliente.Show();
        }

        private void Btn_Financeiro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TelaCadAudiencia telaCadAudiencia = new TelaCadAudiencia();
            telaCadAudiencia.Show();
            //this.
        }


        private void PicBox_CadClientes_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (ModalCadFinanceiro modal = new ModalCadFinanceiro())
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
