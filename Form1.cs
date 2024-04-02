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
    public partial class telaLogin : Form
    {
        private telaCadastro txt_telaLogin;

        public telaLogin()
        {
            InitializeComponent();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            telaCadastro telaLogin = new telaCadastro();
            telaLogin.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            txt_telaInicio txt_telaLog = new txt_telaInicio();
            txt_telaLog.Show();
        }
    }
}
