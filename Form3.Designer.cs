﻿namespace TCC_3_M
{
    partial class txt_telaInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CadastroP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CadastroP
            // 
            this.btn_CadastroP.Location = new System.Drawing.Point(173, 75);
            this.btn_CadastroP.Name = "btn_CadastroP";
            this.btn_CadastroP.Size = new System.Drawing.Size(94, 81);
            this.btn_CadastroP.TabIndex = 0;
            this.btn_CadastroP.Text = "Cadastro Produto";
            this.btn_CadastroP.UseVisualStyleBackColor = true;
            this.btn_CadastroP.Click += new System.EventHandler(this.btn_CadastroP_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cadastro Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "Estoque";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(295, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 83);
            this.button4.TabIndex = 3;
            this.button4.Text = "Descarte";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txt_telaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_CadastroP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "txt_telaInicio";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CadastroP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}