﻿using System;
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
    public partial class txt_telaInicio : Form
    {
        public txt_telaInicio()
        {
            InitializeComponent();
        }

        private void btn_CadastroP_Click(object sender, EventArgs e)
        {
            txt_TelaCadastroP txt_telaInicio = new txt_TelaCadastroP();
            txt_telaInicio.Show();
        }
    }
}
