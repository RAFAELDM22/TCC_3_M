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
    public partial class txt_TelaCadastroP : Form
    {
        public txt_TelaCadastroP()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Registro_Dispositivos txt_TelaCadastroP = new Registro_Dispositivos();
            txt_TelaCadastroP.Show();
        }
    }
}
