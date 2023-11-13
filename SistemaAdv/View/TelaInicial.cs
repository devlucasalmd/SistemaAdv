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
        //private TelaInicial telainicial;
        private TelaCadProcesso telaprocesso;
        private TelaCadUser telauser;
        private TelaCadCliente telacliente;
        private TelaCadAudiencia telaaudiencia;
        private LoginService loginService;
        private Form formul;

        public TelaInicial()
        {
            InitializeComponent();

        }
     
        private void processosToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FormCollection fc = Application.OpenForms;
                bool isOpened = false;
                foreach (Form frm in fc)
                {
                    if (frm.Name == "TelaCadProcesso")
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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FormCollection fc = Application.OpenForms;
                bool isOpened = false;
                foreach (Form frm in fc)
                {
                    if (frm.Name == "TelaCadUser")
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
                    telauser = new TelaCadUser()
                    {
                        MdiParent = this,
                        Width = this.Width - 21,
                        Height = this.Height - 90,
                    };
                    telauser.Show();
                }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool isOpened = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "TelaCadCliente")
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
                telacliente = new TelaCadCliente()
                {
                    MdiParent = this,
                    Width = this.Width - 21,
                    Height = this.Height - 90,
                };
                telacliente.Show();
            }
        }

        private void audienciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool isOpened = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "TelaCadAudiencia")
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
                telaaudiencia = new TelaCadAudiencia()
                {
                    MdiParent = this,
                    Width = this.Width - 21,
                    Height = this.Height - 90,
                };
                telaaudiencia.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Deseja sair?", "Aviso",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Warning
                 );
            loginService = new LoginService();
            loginService.Logoff();
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            // Percorra todos os formulários abertos no aplicativo
            if(fc.Count > 1) 
            {
                foreach (Form frm in fc)
                {
                    // Certifique-se de não fechar o formulário principal (se houver)
                    if (frm.Name != "TelaInicial" && frm.Name != "TelaLogin")
                    {
                        frm.Close(); // Fecha o formulário
                    }
                    if(fc.Count == 2)
                    {
                        break;
                    }
                }
            }
            
        }
    }
}
