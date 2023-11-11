using SistemaAdv.Models;
using SistemaAdv.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdv.Service
{
    internal class ProcessoService
    {
        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();

        //retornar int para devolver id do funcionario, para setar permissão
        public void CreateProcesso(Processo novoProcesso)
        {
            connection.OpenConnection();

            // Criar um novo objeto Funcionario com os dados fornecidos.
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Processos VALUES (@, @, @, @, @, @, @)"
            ;

            //sqlCommand.Parameters.AddWithValue("@", novoProcesso.);
            //sqlCommand.Parameters.AddWithValue("@", novoProcesso.);
            //sqlCommand.Parameters.AddWithValue("@", novoProcesso.);
            //sqlCommand.Parameters.AddWithValue("@", novoProcesso.);
            //sqlCommand.Parameters.AddWithValue("@", novoProcesso.);
            //sqlCommand.Parameters.AddWithValue("@", novoProcesso.);
            //sqlCommand.Parameters.AddWithValue("@", novoProcesso.);

            try
            {
                //Insere o cliente
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir processo no banco.\n"
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
