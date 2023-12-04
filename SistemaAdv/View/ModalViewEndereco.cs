 using SistemaAdv.Models;
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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace SistemaAdv.View
{
    public partial class ModalViewEndereco : Form
    {
        private EnderecoService enderecoService;
        int cpf;

        public ModalViewEndereco(int cpf)
        {
            InitializeComponent();
            this.cpf = cpf;
            if (cpf != 0)
            {
                DataTable dt = new DataTable();
                dt = enderecoService.GetEndereco(cpf);
                mskdBox_CEP.Text = dt.Rows[0]["CEP"].ToString();
                TxtBox_Logadouro.Text = dt.Rows[0]["Logadouro"].ToString();
                TxtBox_Numero.Text = dt.Rows[0]["Numero"].ToString();
                TxtBox_Comple.Text = dt.Rows[0]["Complemento"].ToString();
                TxtBox_Bairro.Text = dt.Rows[0]["Bairro"].ToString();
                TxtBox_Municipio.Text = dt.Rows[0]["Municipio"].ToString();
                TxtBox_Estado.Text = dt.Rows[0]["Estado"].ToString();
            }
        }

        private void Btn_BuscarCEP_Click(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void LocalizarCEP()
        {

            if (!string.IsNullOrWhiteSpace(mskdBox_CEP.Text))
            {
                using (var ws = new WsCep.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(mskdBox_CEP.Text);

                        TxtBox_Logadouro.Text = endereco.end;
                        TxtBox_Municipio.Text = endereco.cidade;
                        TxtBox_Estado.Text = endereco.uf;
                        TxtBox_Bairro.Text = endereco.bairro;
                    }
                    catch (Exception err)
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
        private void LimparCampos()
        {
            TxtBox_Logadouro.Clear();
            TxtBox_Bairro.Clear();
            TxtBox_Numero.Clear();
            TxtBox_Municipio.Clear();
            TxtBox_Comple.Clear();
            TxtBox_Estado.Clear();
            mskdBox_CEP.Clear();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            string CEP = mskdBox_CEP.Text;
            string Logradouro = TxtBox_Logadouro.Text;
            string Bairro = TxtBox_Bairro.Text;
            string Municipio = TxtBox_Municipio.Text;
            string Estado = TxtBox_Estado.Text;
            string Numero = TxtBox_Numero.Text;
            string Complemento = TxtBox_Comple.Text;

            Cliente.Endereco enderecoCliente = new Cliente.Endereco
            {
                CEP = CEP,
                Logradouro = Logradouro,
                Bairro = Bairro,
                Municipio = Municipio,
                Estado = Estado,
                Numero = Numero,
                Complemento = Complemento
            };

            //enderecoService.UpdateEndereco(enderecoCliente);
        }
    }
}
