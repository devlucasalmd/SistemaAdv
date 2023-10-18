using SistemaAdv.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdv.View
{
    public partial class TelaCadCliente : Form
    {
        private MenuService menuService;

        public TelaCadCliente()
        {
            InitializeComponent();
        }

        private void Btn_Processos_Click(object sender, EventArgs e)
        {
            menuService.OpenTelaProcesso();
        }
    }
}
