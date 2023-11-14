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
        public string CEP;
        public string Logradouro; 
        public string Bairro;
        public string Municipio;
        public string Estado;
        public string Numero;
        public string Complemento;

        public Cliente(string cpf, string nome, string rg, string telefone, string email, string estadoCivil,
                      string dataNascimento, string profissao, string pis, string nacionalidade,
                      string posicao, string natureza, string cep, string logradouro, string bairro,
                      string municipio, string estado, string numero, string complemento)
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
            CEP = cep;
            Logradouro = logradouro;
            Bairro = bairro;
            Municipio = municipio;
            Estado = estado;
            Numero = numero;
            Complemento = complemento;
            //Endereco = endereco;

        }

        //public string CPF { get; set; }
        //public string Nome { get; set; }
        //public string RG { get; set; }
        //public string Telefone { get; set; }
        //public string Email { get; set; }
        //public string EstadoCivil { get; set; }
        //public string DataNascimento { get; set; }
        //public string Profissao { get; set; }
        //public string Pis { get; set; }
        //public string Nacionalidade { get; set; }
        //public string Posicao { get; set; }
        //public string Natureza { get; set; }
        //public Endereco Endereco { get; set; }

        //public class Endereco
        //{
        //    public string CEP { get; set; }
        //    public string Logradouro { get; set; }
        //    public string Bairro { get; set; }
        //    public string Municipio { get; set; }
        //    public string Estado { get; set; }
        //    public string Numero { get; set; }
        //    public string Complemento { get; set; }
        //}

        // Construtor
        //public Pessoa(string cpf, string nome, string rg, string telefone, string email, string estadoCivil,
        //              string dataNascimento, string profissao, string pis, string nacionalidade,
        //              string posicao, string natureza, Endereco endereco)
        //{
        //CPF = cpf;
        //Nome = nome;
        //RG = rg;
        //Telefone = telefone;
        //Email = email;
        //EstadoCivil = estadoCivil;
        //DataNascimento = dataNascimento;
        //Profissao = profissao;
        //Pis = pis;
        //Nacionalidade = nacionalidade;
        //Posicao = posicao;
        //Natureza = natureza;
        //Endereco = endereco;
        //}
    }     
}
