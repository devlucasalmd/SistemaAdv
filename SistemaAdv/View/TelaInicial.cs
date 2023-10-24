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
       // private MenuService menuService;
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

        private void Btn_Processos_Click(object sender, EventArgs e)
        {
            TelaCadProcesso telaCadProcesso = new TelaCadProcesso();
            telaCadProcesso.Show();
            this.Visible = false;
            // menuService.OpenTelaProcesso();
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
    }
}
