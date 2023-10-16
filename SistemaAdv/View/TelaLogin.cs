using SistemaAdv.Models;
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

        private void Btn_Login_Click(object sender, EventArgs e)
        {
             var user = TxtBox_UserName.Text;
             var pass = TxtBox_Password.Text;
          
            loginService.Login(user, pass);

            // TelaInicial telaInicial = new TelaInicial();
            //telaInicial.Show(); 
            
        }
    }
}
