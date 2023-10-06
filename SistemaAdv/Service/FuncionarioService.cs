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
            try
            {
                connection.OpenConnection();

                // Criar um novo objeto Funcionario com os dados fornecidos.
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"INSERT INTO TB_User VALUES 
            (@name, @job, @email, @cpf, @gender)"
                ;

                sqlCommand.Parameters.AddWithValue("@name", novoFuncionario.Nome);
                sqlCommand.Parameters.AddWithValue("@job", txbJob.Text);
                sqlCommand.Parameters.AddWithValue("@email", txbEmail.Text);
                sqlCommand.Parameters.AddWithValue("@cpf", mtbCPF.Text);
                sqlCommand.Parameters.AddWithValue("@gender", cmbGender.Text);
                

                MessageBox.Show("Funcionário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            

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
ClearFields();
UpdateListView();

MessageBox.Show(
    "Cadastrado com Sucesso",
    "CADASTRO",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
    );
        }
    }
