using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAdv.Models
{
    internal class Funcionario
    {
        public string Id;
        public string Nome;
        public string UserName;
        public string Senha;
        public string Email;
        public string Cargo;
        public string Status;
        public DateTime Data;

        // CREATE
        public Funcionario( string nome, string userName, string senha, string email, string cargo, string status, DateTime data)
        {
            Nome = nome;
            UserName = userName;
            Senha = senha;
            Email = email;
            Cargo = cargo;
            Status = status;
            Data = data;
        }

        // READ
        public Funcionario(string id, string nome, string userName, string senha, string email, string cargo, string status, DateTime data): 
                this(nome, userName, senha, email, cargo, status, data)
        {
            Id = id;
        }


    }
}
