﻿using SistemaAdv.Models;
using SistemaAdv.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SistemaAdv
{
    public partial class TelaLogin : Form
    {
        private LoginService loginService;

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
        private void Btn_Login_Click(object sender, EventArgs e)
        {
             var user = TxtBox_UserName.Text;
             var pass = TxtBox_Password.Text;

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

                if (loginService.UserExists(user))
                {
                    if (loginService.ValidatePassword(user, pass))
                    {
                        TelaInicial telaInicial = new TelaInicial();
                        telaInicial.Show();                             
                        LimparCampos();
                        loginService.IsLoggedIn = true;
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
