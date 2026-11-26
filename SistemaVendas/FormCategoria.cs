using SistemaVendas.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void buttonFecharCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsultarCategoria_Click(object sender, EventArgs e)
        {
            comboBoxTeste.DataSource = CategoriaDAO.Listar();
            comboBoxTeste.DisplayMember = "NM_CATEGORIA";
            comboBoxTeste.ValueMember = "ID_CATEGORIA";
        }
    }
}
