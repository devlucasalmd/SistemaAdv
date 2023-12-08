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

namespace SistemaAdv.Service
{
    internal class EnderecoService
    {
        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();

        //retornar int para devolver id do funcionario, para setar permissão
        public void CreateEndereco(Cliente.Endereco novoEndereco)
        {
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();

            sqlCommand.CommandText = @"INSERT INTO Enderecos (CEP, Logradouro, Bairro, Municipio, Estado, Numero, Complemento) 
                                            VALUES (@CEP, @Logradouro, @Bairro, @Municipio, @Estado, @Numero, @Complemento)";
            {
                sqlCommand.Parameters.AddWithValue("@CEP", novoEndereco.CEP);
                sqlCommand.Parameters.AddWithValue("@Logradouro", novoEndereco.Logradouro);
                sqlCommand.Parameters.AddWithValue("@Bairro", novoEndereco.Bairro);
                sqlCommand.Parameters.AddWithValue("@Municipio", novoEndereco.Municipio);
                sqlCommand.Parameters.AddWithValue("@Estado", novoEndereco.Estado);
                sqlCommand.Parameters.AddWithValue("@Numero", novoEndereco.Numero);
                sqlCommand.Parameters.AddWithValue("@Complemento", novoEndereco.Complemento);

                sqlCommand.ExecuteNonQuery();
            }
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir endereco no banco.\n"
                    + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public DataTable GetEndereco(int id)
        {
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = @"select * from Enderecos where Id = @id";

            sqlCommand.Parameters.AddWithValue("@id", id);

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


        //public DataTable ReadEndereco(cpf)
        //{
        //    connection.OpenConnection();
        //    sqlCommand.Connection = connection.ReturnConnection();
        //    sqlCommand.Parameters.Clear();
        //    sqlCommand.CommandText = @"select * from Funcionarios where CPF = @cpf";

        //    sqlCommand.Parameters.AddWithValue("@CPF", cpf);

        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        return dt;

        //    }
        //    catch (Exception err)
        //    {
        //        throw new Exception("Erro: Problemas ao ler colaborador no banco.\n"
        //            + err.Message);
        //    }
        //    finally
        //    {
        //        connection.CloseConnection();
        //    }
        //}

        public bool UpdateEndereco(Cliente.Endereco novoEndereco)
        {
                connection.OpenConnection();

                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = @"Update  Enderecos (CEP, Logradouro, Bairro, Municipio, Estado, Numero, Complemento) 
                                            VALUES (@CEP, @Logradouro, @Bairro, @Municipio, @Estado, @Numero, @Complemento)";
                    sqlCommand.Parameters.AddWithValue("@CEP", novoEndereco.CEP);
                    sqlCommand.Parameters.AddWithValue("@Logradouro", novoEndereco.Logradouro);
                    sqlCommand.Parameters.AddWithValue("@Bairro", novoEndereco.Bairro);
                    sqlCommand.Parameters.AddWithValue("@Municipio", novoEndereco.Municipio);
                    sqlCommand.Parameters.AddWithValue("@Estado", novoEndereco.Estado);
                    sqlCommand.Parameters.AddWithValue("@Numero", novoEndereco.Numero);
                    sqlCommand.Parameters.AddWithValue("@Complemento", novoEndereco.Complemento);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir endereco no banco.\n"
                    + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
            return true;
        }
    }
 } 