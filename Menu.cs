using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_3_M
{
    public partial class telaMenuCadastroP : Form
    {

        public telaMenuCadastroP()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registroDispositivos telaMenuCadastroP = new registroDispositivos();
            telaMenuCadastroP.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            excluirDispositivo telaMenuCadastroP = new excluirDispositivo();
            telaMenuCadastroP.Show();
           
        }
    }
}
