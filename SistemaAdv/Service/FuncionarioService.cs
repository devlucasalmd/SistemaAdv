using SistemaAdv.Models;
using SistemaAdv.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaAdv.Service
{
    internal class FuncionarioService
    {
        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();

        //retornar int para devolver id do funcionario, para setar permissão
        public void CadastrarFuncionario(Funcionario novoFuncionario)
        {
                connection.OpenConnection();

                // Criar um novo objeto Funcionario com os dados fornecidos.
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"INSERT INTO Funcionarios VALUES (@Nome, @UserName, @Senha, @Email, @Cargo, @Status, @Data)"
                ;

                sqlCommand.Parameters.AddWithValue("@Nome", novoFuncionario.Nome);
                sqlCommand.Parameters.AddWithValue("@UserName", novoFuncionario.UserName);
                sqlCommand.Parameters.AddWithValue("@Senha", novoFuncionario.Senha);
                sqlCommand.Parameters.AddWithValue("@Email", novoFuncionario.Email);
                sqlCommand.Parameters.AddWithValue("@Cargo", novoFuncionario.Cargo);
                sqlCommand.Parameters.AddWithValue("@Status", novoFuncionario.Status);
                sqlCommand.Parameters.AddWithValue("@Data", novoFuncionario.Data);
         
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