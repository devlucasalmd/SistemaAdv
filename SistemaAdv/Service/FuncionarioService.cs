﻿using SistemaAdv.Models;
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

        public DataTable GetFuncionario(int id)
        {
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();

            sqlCommand.CommandText = @"select * from funcionarios where Id = 1";

            //sqlCommand.Parameters.AddWithValue("@id", id);

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

        public bool UpdateFuncionario(Funcionario novoFuncionario)
        {
            try
            {
                connection.OpenConnection();

                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"Update Funcionarios SET Nome = teste, UserName = teste, Senha = teste, Email = teste, Cargo = teste, Status = teste, Data = teste WHERE Id = 1"
                ;

               // sqlCommand.Parameters.AddWithValue("@Nome", novoFuncionario.Nome);
               // sqlCommand.Parameters.AddWithValue("@UserName", novoFuncionario.UserName);
               // sqlCommand.Parameters.AddWithValue("@Senha", novoFuncionario.Senha);
               // sqlCommand.Parameters.AddWithValue("@Email", novoFuncionario.Email);
               // sqlCommand.Parameters.AddWithValue("@Cargo", novoFuncionario.Cargo);
               // sqlCommand.Parameters.AddWithValue("@Status", novoFuncionario.Status);
               // sqlCommand.Parameters.AddWithValue("@Data", novoFuncionario.Data);

                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public bool DeleteFuncionario(int id)
        {
            try
            {
                connection.OpenConnection();
                sqlCommand.Connection = connection.ReturnConnection();

                sqlCommand.CommandText = @"Update Funcionarios SET status = inativo WHERE Id = @id";
                sqlCommand.Parameters.AddWithValue("@id", id);
                return true;
            }
            catch
            {
                return false;
            }            
         }

        public DataTable FilterFuncionario(string cargo)
        {
            string filtro = cargo;
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT * FROM Funcionarios ";

            if (!string.IsNullOrEmpty(cargo))
            {
                sqlCommand.CommandText += @"WHERE Cargo = @Cargo";
            }
            if (sqlCommand.Parameters.Contains("@Cargo"))
            {
                sqlCommand.Parameters.Clear();
            }

            sqlCommand.Parameters.AddWithValue("@Cargo", filtro);


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
    