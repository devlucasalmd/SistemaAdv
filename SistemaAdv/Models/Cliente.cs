using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaAdv.Models
{
    internal class Cliente
    {
        public string CPF;
        public string Nome;
        public string RG;
        public string Telefone;
        public string Email;
        public string EstadoCivil;
        public string DataNasc;
        public string Profissao;
        public string Pis;
        public string Nacionalidade;
        public string Posicao;
        public string Natureza;
        public Endereco EnderecoCliente;

        public Cliente(string cpf, string nome, string rg, string telefone, string email, string estadoCivil,
                      string dataNascimento, string profissao, string pis, string nacionalidade,
                      string posicao, string natureza, Endereco endereco)
        {
            CPF = cpf;
            Nome = nome;
            RG = rg;
            Telefone = telefone;
            Email = email;
            EstadoCivil = estadoCivil;
            DataNasc = dataNascimento;
            Profissao = profissao;
            Pis = pis;
            Nacionalidade = nacionalidade;
            Posicao = posicao;
            Natureza = natureza;
            EnderecoCliente = endereco;
        }

        //Isso é igual a um Struct
        public class Endereco
        {
            public string CEP { get; set; }
            public string Logradouro { get; set; }
            public string Bairro { get; set; }
            public string Municipio { get; set; }
            public string Estado { get; set; }
            public string Numero { get; set; }
            public string Complemento { get; set; }
        }
    }
}
