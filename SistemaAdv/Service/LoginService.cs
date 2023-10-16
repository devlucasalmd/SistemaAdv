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
        
        public void Login(string user, string pass)
        {
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT * FROM Funcionarios WHERE UserName = '" + user + "' AND Senha = '" + pass +"'";

            try
            {
               sqlCommand.ExecuteNonQuery();
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
