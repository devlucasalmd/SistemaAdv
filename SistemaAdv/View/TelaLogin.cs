using SistemaAdv.Models;
using SistemaAdv.Service;
using SistemaAdv.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SistemaAdv
{
    public partial class TelaLogin : Form
    {
        private LoginService loginService;
        public ModalCadUser modalCadUser;

        public object ModalCalUser { get; private set; }

        public TelaLogin()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void LimparCampos()
        {
            TxtBox_UserName.Clear();
            TxtBox_Password.Clear();
        }

        private string CriptografarSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            var user = TxtBox_UserName.Text;
            string pass = TxtBox_Password.Text;
            string senhaCrip = CriptografarSenha(pass);
            string senhaArm = loginService.GetPassword(user);

            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("O campo do Usuario não pode estar vazio");
            }

            else if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("A senha não pode estar vazia");
            }

            
            try
            {
                //string senhaCriptografada = ModalCalUser.CriptografarSenha(pass);

                if (loginService.UserExists(user))
                {
                    if (loginService.ValidatePassword(user, pass))
                    {
                        if(senhaCrip == senhaArm)
                        {
                            TelaInicial telaInicial = new TelaInicial();
                            telaInicial.Show();
                            LimparCampos();
                            loginService.IsLoggedIn = true;
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta.");
                        LimparCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado.");
                    LimparCampos();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LnkLbl_EsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPassPanel.Visible = true;
        }

        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            //if(TxtBox_Email.Text == @Email)
            if(string.IsNullOrEmpty(TxtBox_Email.Text))
            {
                MessageBox.Show(
                    "Insira um email");
            }
            else
            {
                MessageBox.Show(
                   "Senha enviada para o email");
                TxtBox_Email.Clear();
                forgotPassPanel.Visible = false;
            }
        }

        private void Btn_ClosePanel_Click(object sender, EventArgs e)
        {
            forgotPassPanel.Visible = false;
        }
    }
}
