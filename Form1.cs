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
    public partial class txt_telaLog : Form
    {
        private txt_telaCadastro txt_telaLogin;

        public txt_telaLog()
        {
            InitializeComponent();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            txt_telaCadastro txt_telaLog = new txt_telaCadastro();
            txt_telaLog.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            txt_telaInicio txt_telaLog = new txt_telaInicio();
            txt_telaLog.Show();
        }
    }
}
