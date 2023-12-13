using SistemaAdv.Models;
using SistemaAdv.View;
using System;
using System.Collections.Generic;
using System.Data;
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

        private EnderecoService enderecoService;

        //retornar int para devolver id do funcionario, para setar permissão
        public void CreateCliente(Cliente novoCliente)
        {
            //if (ClienteExiste(novoCliente.CPF))
            //{
            //   MessageBox.Show("Erro: CPF já existe na base de dados.");
            //}

            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();

            sqlCommand.CommandText = @"INSERT INTO ClientesFisicos VALUES (@CPF, @Nome, @RG, @Telefone, @Email, @EstadoCivil,
            @DataNasc, @Profissao, @Pis, @Nacionalidade, @Posicao, @Natureza)";

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
            EnderecoService enderecoService = new EnderecoService();  // Certifique-se de inicializar a instância corretamente
            enderecoService.CreateEndereco(novoCliente.EnderecoCliente);
            MessageBox.Show(
            "Cadastrado com Sucesso",
            "CADASTRO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
        }

        public bool UpdateCliente(Cliente novoCliente)
        {
                connection.OpenConnection();

                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = @"UPDATE ClientesFisicos SET Nome = @Nome, RG = @RG, Telefone = @Telefone, Email = @Email, EstadoCivil = @EstadoCivil,
                            DataNasc = @DataNasc, Profissao = @Profissao, Pis = @Pis, Nacionalidade = @Nacionalidade, Posicao = @Posicao, Natureza = @Natureza
                            WHERE CPF = @CPF";

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


            //EnderecoService enderecoService = new EnderecoService();  // Certifique-se de inicializar a instância corretamente
            //enderecoService.UpdateEndereco(novoCliente.EnderecoCliente);


            try
            {
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }


        }


        //public bool ClienteExiste(string cpf)
        //{
        //    // Verificar se o CPF já existe na tabela ClientesFisicos
        //    sqlCommand.CommandText = "SELECT COUNT(*) FROM ClientesFisicos WHERE CPF = @CPF";
        //    sqlCommand.Parameters.AddWithValue("@CPF", cpf);
        //    int count = 1;
        //    return count > 0;
        //}

        public DataTable ReadCliente()
        {
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "SELECT * FROM ClientesFisicos";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand.CommandText, sqlCommand.Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao ler colaborador no banco.\n"
                    + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public bool DeleteCliente(string cpf)
        {
            try
            {
                connection.OpenConnection();
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = @"DELETE FROM ClientesFisicos WHERE CPF = @cpf";
                sqlCommand.Parameters.AddWithValue("@cpf", cpf);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
                return false;
            }
        }

        public DataTable FilterClienteFisico()
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand.CommandText, sqlCommand.Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao ler colaborador no banco.\n"
                    + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public DataTable ReadCliente(string cpf)
        {
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = @"select * from ClientesFisicos where CPF = @cpf";

            sqlCommand.Parameters.AddWithValue("@CPF", cpf);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao ler colaborador no banco.\n"
                    + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}