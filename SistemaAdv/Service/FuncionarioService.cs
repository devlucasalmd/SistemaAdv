using SistemaAdv.Models;
using SistemaAdv.View;
using System;
using System.Collections.Generic;
using System.Data;
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
        public void CreateFuncionario(Funcionario novoFuncionario)
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

        public DataTable ReadFuncionarios()
        {
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT * FROM Funcionarios";
     
            

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


        public DataTable FilterFuncionario(TelaCadUser txt)
        {
            var txt = TelaCadUser txt;
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT * FROM Funcionarios
                                        WHERE CARGO LIKE '%{txt}'";

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
}
    
    }
}