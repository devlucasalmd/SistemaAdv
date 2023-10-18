using SistemaAdv.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdv.Service
{
    internal class LoginService
    {
        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();

        public bool UserExists(string user)
        {
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();

            try
            {
                sqlCommand.CommandText = @"SELECT COUNT(*) FROM Funcionarios WHERE UserName = @user";
                sqlCommand.Parameters.AddWithValue("@user", user);

                int count = (int)sqlCommand.ExecuteScalar();
                return count > 0;
                //sqlCommand.ExecuteNonQuery();
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
            public bool ValidatePassword(string user, string pass)
            {
                connection.OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection.ReturnConnection();

                try
                {
                    sqlCommand.CommandText = "SELECT COUNT(*) FROM Funcionarios WHERE UserName = @user AND Senha = @pass";
                    sqlCommand.Parameters.AddWithValue("@user", user);
                    sqlCommand.Parameters.AddWithValue("@pass", pass);

                    int count = (int)sqlCommand.ExecuteScalar();

                    return count > 0; // Se houver pelo menos um registro correspondente, a senha está correta.
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro: Problemas ao validar a senha.\n" + err.Message);
                    return false;
                }
                finally
                {
                    connection.CloseConnection();
                }
            }

        }

    }
