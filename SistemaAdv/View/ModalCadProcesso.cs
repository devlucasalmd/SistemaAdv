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
    public partial class ModalCadProcesso : Form
    {
        public ModalCadProcesso()
        {
            InitializeComponent();
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else
            {
                Opacity += .03;
            }

            int y = TelaCadProcesso.parentY += 3;
            this.Location = new Point(TelaCadProcesso.parentX + 220, y);
            if (y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }

        int i;
        private void ModalCadProcesso_Load(object sender, EventArgs e)
        {
            i = TelaCadProcesso.parentY + 150;
            this.Location = new Point(TelaCadProcesso.parentX + 160, TelaCadProcesso.parentY + 150);
        }


    }
}
