using Correios.Net;
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
    public partial class ModalCadCliente : Form
    {
        public ModalCadCliente()
        {
            InitializeComponent();
        }

        private void Btn_BuscarCEP_Click(object sender, EventArgs e)
        {
            LocalizarCEP();
        }
        private void LocalizarCEP()
        {

            if (!string.IsNullOrWhiteSpace(mskdBox_CEP.Text))
            {
                using(var ws = new WsCep.AtendeClienteClient())
                {
                    try
                    {                        
                        var endereco = ws.consultaCEP(mskdBox_CEP.Text);

                        TxtBox_Logadouro.Text = endereco.end;
                        TxtBox_Municipio.Text = endereco.cidade;
                        TxtBox_Estado.Text = endereco.uf;
                        TxtBox_Bairro.Text = endereco.bairro;
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show(err.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
