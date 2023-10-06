using SistemaAdv.Models;
using SistemaAdv.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaAdv.View
{
    public partial class ModalCadUser : Form
    {

        private FuncionarioService funcionarioService;
        public ModalCadUser()
        {
            InitializeComponent();
            funcionarioService = new FuncionarioService();
        }


        //Limpar Campos
        private void LimparCampos()
        {
            TxtBox_Name.Clear();
            TxtBox_UserName.Clear();
            TxtBox_Password.Clear();
            TxtBox_Email.Clear();
            CmbBox_Cargo.ResetText();
            CmbBox_Status.ResetText();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            
            string Nome = TxtBox_Name.Text;
            string UserName = TxtBox_UserName.Text;
            string Senha = TxtBox_Password.Text;
            string Email = TxtBox_Email.Text;
            string Cargo = CmbBox_Cargo.Text;
            string Status = CmbBox_Status.Text;
            DateTime Data = DateTime.Now;

            var novoFuncionario = new Funcionario(Nome, UserName, Senha, Email, Cargo, Status, Data);
            funcionarioService.CadastrarFuncionario(novoFuncionario);
            LimparCampos();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Colocar est, sec, adm ou adv no campo UserName ao inserir o cargo no CmbBox_Cargo
    }
}
