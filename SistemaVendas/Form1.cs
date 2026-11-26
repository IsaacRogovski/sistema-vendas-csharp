using Microsoft.Data.SqlClient;
using SistemaVendas.Dados;

namespace SistemaVendas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();

            formCliente.MdiParent = this;

            formCliente.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategoria formCategoria = new FormCategoria();

            formCategoria.MdiParent = this;

            formCategoria.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();

            formProduto.MdiParent = this;

            formProduto.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void exibirAtivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void fecharTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja sair?",
                "Confirmar saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobre formSobre = new FormSobre();

            formSobre.MdiParent = this;

            formSobre.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conexao = Conexao.ObterConexao();

                conexao.Open();

                MessageBox.Show("Conexão com o banco realizada com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao conectar com o banco:\n" + ex.Message
                );
            }
        } 
    }
}
