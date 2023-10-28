using SistemaAdv.Service;
using SistemaAdv.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdv
{
    public partial class TelaInicial : Form
    {
        private TelaCadProcesso telaprocesso;
        public TelaInicial()
        {
            InitializeComponent();
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
            TelaCadUser telaCadUser = new TelaCadUser(0);
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
        }

        private void processosToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FormCollection fc = Application.OpenForms;
                bool isOpened = false;
                foreach (Form frm in fc)
                {
                    if (frm.Name == "TelaCadProcessos")
                    {
                        isOpened = true;
                        break;
                    }
                }
                if (isOpened)
                {
                    MessageBox.Show("Já esta aberta");
                }
                else
                {
                    telaprocesso = new TelaCadProcesso()
                    {
                        MdiParent = this,
                        Width = this.Width - 21,
                        Height = this.Height - 90,
                    };
                    telaprocesso.Show();
                }
            }
        }
}
