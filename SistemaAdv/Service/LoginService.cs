using SistemaAdv.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdv.Service
{
    internal class LoginService
    {
        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();

        public bool isLoggedIn = false;

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        public void Logoff() 
        { 
            isLoggedIn = false;
        }

        public bool UserExists(string user)
        {
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();

            try
            {
                sqlCommand.CommandText = @"SELECT COUNT(*) FROM Funcionarios WHERE UserName = @user";
                sqlCommand.Parameters.Clear();
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
        //public static bool VerificarSenha(string senhaUsuario, string senhaArmazenada)
        //{
        //    using (SHA256 sha256 = SHA256.Create())
        //    {
        //        byte[] bytes = Encoding.UTF8.GetBytes(senhaUsuario);
        //        byte[] hashBytes = sha256.ComputeHash(bytes);
        //        string senhaUsuarioCriptografada = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

        //        // Comparando a senha criptografada do usuário com a senha armazenada no banco de dados
        //        return senhaUsuarioCriptografada == senhaArmazenada;
        //    }
        //}

        public bool ValidatePassword(string user, string pass)
        {
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();

            try
            {
                sqlCommand.CommandText = "SELECT COUNT(*) FROM Funcionarios WHERE UserName = @user AND Senha = @pass";
                sqlCommand.Parameters.Clear();

                sqlCommand.Parameters.AddWithValue("@user", user);
                sqlCommand.Parameters.AddWithValue("@pass", pass);

                int count = (int)sqlCommand.ExecuteScalar();

                return count > 0; // Se houver pelo menos um registro correspondente, a senha está correta.
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao validar usuario e senha", err);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
