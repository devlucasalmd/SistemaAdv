using Correios.Net;
using SistemaAdv.Models;
using SistemaAdv.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaAdv.View
{
    public partial class ModalCadCliente : Form
    {

        private ClienteService clienteService;
        private EnderecoService enderecoService;
        int cpf;

        public ModalCadCliente(int cpf)
        {
            InitializeComponent();
            clienteService = new ClienteService();
            this.cpf = cpf;
            if (cpf != 0)
            {
                DataTable dt = new DataTable();
                dt = clienteService.ReadCliente(cpf);
                TxtBox_Natureza.Text = dt.Rows[0]["Natureza"].ToString();
                TxtBox_Email.Text = dt.Rows[0]["Email"].ToString();
                TxtBox_Telefone.Text = dt.Rows[0]["Telefone"].ToString();
                TxtBox_Name.Text = dt.Rows[0]["Nome"].ToString();
                TxtBox_PIS.Text = dt.Rows[0]["Pis"].ToString();
                TxtBox_Nacionalidade.Text = dt.Rows[0]["Nacionalidade"].ToString();
                TxtBox_Profissao.Text = dt.Rows[0]["Profissao"].ToString();
                mskdBox_CPF.Text = dt.Rows[0]["CPF"].ToString();
                mskdBox_RG.Text = dt.Rows[0]["RG"].ToString();
                TxtBox_PosicaoCliente.Text = dt.Rows[0]["Posicao"].ToString();
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
        private void LimparCampos()
        {
            TxtBox_Natureza.Clear();
            TxtBox_Email.Clear();
            TxtBox_Telefone.Clear();
            TxtBox_Name.Clear();
            TxtBox_PIS.Clear();
            TxtBox_Nacionalidade.Clear();
            TxtBox_Profissao.Clear();
            TxtBox_Logadouro.Clear();
            TxtBox_Bairro.Clear();
            TxtBox_Numero.Clear();
            TxtBox_Municipio.Clear();
            TxtBox_Comple.Clear();
            TxtBox_Estado.Clear();
            mskdBox_CEP.Clear();
            mskdBox_CPF.Clear();
            mskdBox_RG.Clear();
            TxtBox_PosicaoCliente.Clear();
            cmbBox_EstadoCivil.SelectedIndex = -1; // Limpa a seleção do ComboBox
            dtTime_DataNasc.Value = DateTime.Now; // Define a data atual
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }


        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            DateTime dataEscolhida = dtTime_DataNasc.Value.Date;
            string dataFormatada = dtTime_DataNasc.Value.ToString("yyyy-MM-dd");
            
            string CPF = mskdBox_CPF.Text;
            string Nome = TxtBox_Name.Text;
            string RG = mskdBox_RG.Text;
            string Telefone = TxtBox_Telefone.Text;
            string Email = TxtBox_Email.Text;
            string EstadoCivil = cmbBox_EstadoCivil.Text;
            string DataNasc = dataFormatada;
            string Profissao = TxtBox_Profissao.Text;
            string Pis = TxtBox_PIS.Text;
            string Nacionalidade = TxtBox_Nacionalidade.Text;
            string Posicao = TxtBox_PosicaoCliente.Text;
            string Natureza = TxtBox_Natureza.Text;
            string CEP = mskdBox_CEP.Text;
            string Logradouro = TxtBox_Logadouro.Text;
            string Bairro = TxtBox_Bairro.Text;
            string Municipio = TxtBox_Municipio.Text ;
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

            var novocliente = new Cliente(CPF, Nome,  RG,  Telefone,  Email,  EstadoCivil,
                       DataNasc,  Profissao,  Pis,  Nacionalidade,
                       Posicao,  Natureza, enderecoCliente);


            if (VerificarCampos())
            {
                    clienteService.CreateCliente(novocliente);
            }                

            //else { MessageBox.Show("Erro"); }
            LimparCampos();
            this.Close();
        }

        private bool VerificarCampos()
        {
            if (string.IsNullOrEmpty(TxtBox_Natureza.Text))
            {
                MessageBox.Show("O campo da Natureza não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_Email.Text))
            {
                MessageBox.Show("O campo do Email não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_Telefone.Text))
            {
                MessageBox.Show("O campo do Telefone não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_Name.Text))
            {
                MessageBox.Show("O campo do Nome não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_PIS.Text))
            {
                MessageBox.Show("O campo do PIS não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_Nacionalidade.Text))
            {
                MessageBox.Show("O campo da Nacionalidade não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_Profissao.Text))
            {
                MessageBox.Show("O campo da Profissão não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_Logadouro.Text))
            {
                MessageBox.Show("O campo do Logradouro não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_Bairro.Text))
            {
                MessageBox.Show("O campo do Bairro não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_Numero.Text))
            {
                MessageBox.Show("O campo do Número não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_Municipio.Text))
            {
                MessageBox.Show("O campo do Município não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_Comple.Text))
            {
                MessageBox.Show("O campo do Complemento não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_Estado.Text))
            {
                MessageBox.Show("O campo do Estado não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(mskdBox_CEP.Text))
            {
                MessageBox.Show("O campo do CEP não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(mskdBox_CPF.Text))
            {
                MessageBox.Show("O campo do CPF não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(mskdBox_RG.Text))
            {
                MessageBox.Show("O campo do RG não pode estar vazio");
                return false;
            }
            else if (string.IsNullOrEmpty(TxtBox_PosicaoCliente.Text))
            {
                MessageBox.Show("O campo da Posição do Cliente não pode estar vazio");
                return false;
            }
            else if (cmbBox_EstadoCivil.SelectedItem == null)
            {
                MessageBox.Show("Selecione um estado civil");
                return false;
            }
            else if (dtTime_DataNasc.Value == DateTime.Now)
            {
                MessageBox.Show("Selecione uma data de nascimento válida");
                return false;
            }

            return true;
        }


        //public bool ValidarCPf()
        //{
        //    int[] multi1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2, };
        //    int[] multi2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        //    string cpf = mskdBox_CPF.Text;
        //    string auxCPF;
        //    string digito;
        //    int soma;
        //    int resto;

        //    cpf = cpf.Trim();
        //    cpf = cpf.Replace(".", "").Replace("-", "");

        //    auxCPF = cpf.Substring(0, 9);

        //    soma = 0;


        //    for (int i = 0; i < 9; i++)
        //    {
        //        soma += int.Parse(auxCPF[i].ToString()) * multi1[1];
        //    }

        //    resto = soma % 11;

        //    if (resto < 2)

        //    {
        //        resto = 0;
        //    }
        //    else
        //    {
        //        resto = 11 - resto;
        //    }

        //    digito = resto.ToString();
        //    auxCPF = auxCPF + digito;

        //    soma = 0;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        soma += int.Parse(auxCPF[i].ToString()) * multi2[1];
        //    }

        //    resto = soma % 11;

        //    if (resto < 2)

        //    {
        //        resto = 0;
        //    }
        //    else
        //    {
        //        resto = 11 - resto;
        //    }

        //    auxCPF = auxCPF + resto;

        //    if (cpf == auxCPF)
        //    {
        //        MessageBox.Show("Certo");
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("eRRO" + cpf + " " + auxCPF);
        //        return false;
        //    }
        //}

        public bool ValidarCpf()
        {
            string cpf = mskdBox_CPF.Text;
            string auxCPF;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            auxCPF = cpf.Substring(0, 9);
            if (cpf.Length != 11)
                return false;
            else
            {
                int soma = 0;
                for (int i = 0; i < 9; i++)
                    soma += (Convert.ToInt32(cpf[i]) - 48) * (10 - i);

                int digito = (11 - (soma % 11)) > 9 ? 0 : 11 - (soma % 11);
                if (digito == Convert.ToInt32(cpf[9] - 48))
                {
                    soma = 0;
                    for (int i = 0; i < 10; i++)
                        soma += (Convert.ToInt32(cpf[i]) - 48) * (11 - i);

                    digito = (11 - (soma % 11)) > 9 ? 0 : 11 - (soma % 11);
                    if (digito == Convert.ToInt32(cpf[10] - 48))
                    {
                        MessageBox.Show("Certo");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("eRRO" + cpf + " " + auxCPF);
                        return false;
                    }

                }
                return false;
                
            }
        }

            private void mskdBox_CPF_Leave(object sender, EventArgs e)
        {
            if (!ValidarCpf()) { MessageBox.Show("CPf invalido"); }
        }
    }
}
