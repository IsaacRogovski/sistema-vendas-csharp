using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
        }

        private void FormSobre_Load(object sender, EventArgs e)
        {
            richTextBoxSobre.BorderStyle = BorderStyle.None;
            richTextBoxSobre.Text = @"Sistema desenvolvido para atividade aula de programação orientada objeto.

Desenvolvido por:
Isaac da Silva Rogovski

Versão: 1.0.0

© 2026";
        }
    }
}
