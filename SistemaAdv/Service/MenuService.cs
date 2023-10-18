using SistemaAdv.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAdv.Service
{
    internal class MenuService
    {
        public MenuService()
        {

            // public TelaCadProcesso OpenTelaProcesso()
            
            TelaCadProcesso telaCadProcesso = new TelaCadProcesso();
                telaCadProcesso.Show();
           
        
        }
    }
}
