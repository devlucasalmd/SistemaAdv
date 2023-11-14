using SistemaAdv.Models;
using SistemaAdv.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaAdv.Service
{
    internal class ClienteService
    {
        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();

        //retornar int para devolver id do funcionario, para setar permissão
        public void CreateCliente(Cliente novoCliente)
        {
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();

            sqlCommand.CommandText = @"INSERT INTO ClientesFisicos VALUES (@CPF, @Nome, @RG, @Telefone, @Email, @EstadoCivil,
            @DataNasc, @Profissao, @Pis, @Nacionalidade, @Posicao, @Natureza, @CEP, @Logradouro, @Bairro, @Municipio,
            @Estado, @Numero, @Complemento)";            
                
            sqlCommand.Parameters.AddWithValue("@CPF", novoCliente.CPF);
            sqlCommand.Parameters.AddWithValue("@Nome", novoCliente.Nome);
            sqlCommand.Parameters.AddWithValue("@RG", novoCliente.RG);
            sqlCommand.Parameters.AddWithValue("@Telefone", novoCliente.Telefone);
            sqlCommand.Parameters.AddWithValue("@Email", novoCliente.Email);
            sqlCommand.Parameters.AddWithValue("@EstadoCivil", novoCliente.EstadoCivil);
            sqlCommand.Parameters.AddWithValue("@DataNasc", novoCliente.DataNasc);
            sqlCommand.Parameters.AddWithValue("@Profissao", novoCliente.Profissao);
            sqlCommand.Parameters.AddWithValue("@Pis", novoCliente.Pis);
            sqlCommand.Parameters.AddWithValue("@Nacionalidade", novoCliente.Nacionalidade);
            sqlCommand.Parameters.AddWithValue("@Posicao", novoCliente.Posicao);
            sqlCommand.Parameters.AddWithValue("@Natureza", novoCliente.Natureza);
            sqlCommand.Parameters.AddWithValue("@CEP", novoCliente.CEP);
            sqlCommand.Parameters.AddWithValue("@Logradouro", novoCliente.Logradouro);
            sqlCommand.Parameters.AddWithValue("@Bairro", novoCliente.Bairro);
            sqlCommand.Parameters.AddWithValue("@Municipio", novoCliente.Municipio);
            sqlCommand.Parameters.AddWithValue("@Estado", novoCliente.Estado);
            sqlCommand.Parameters.AddWithValue("@Numero", novoCliente.Numero);
            sqlCommand.Parameters.AddWithValue("@Complemento", novoCliente.Complemento);

            try
            {
                //Insere o cliente
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir colaborador no banco.\n"
                    + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
            
            MessageBox.Show(
            "Cadastrado com Sucesso",
            "CADASTRO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
        }
    }
}