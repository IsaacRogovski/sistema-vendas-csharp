namespace SistemaVendas
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            vendasToolStripMenuItem = new ToolStripMenuItem();
            realizarVendaToolStripMenuItem = new ToolStripMenuItem();
            janelasToolStripMenuItem = new ToolStripMenuItem();
            organizarToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            cascataToolStripMenuItem = new ToolStripMenuItem();
            exibirAtivasToolStripMenuItem = new ToolStripMenuItem();
            fecharTodasToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, vendasToolStripMenuItem, janelasToolStripMenuItem, sistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, categoriaToolStripMenuItem, produtosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Image = Properties.Resources.do_utilizador;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(125, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Image = Properties.Resources.camadas;
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(125, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Image = Properties.Resources.cubo;
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(125, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // vendasToolStripMenuItem
            // 
            vendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { realizarVendaToolStripMenuItem });
            vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            vendasToolStripMenuItem.Size = new Size(56, 20);
            vendasToolStripMenuItem.Text = "Vendas";
            // 
            // realizarVendaToolStripMenuItem
            // 
            realizarVendaToolStripMenuItem.Image = Properties.Resources.carrinho_de_compras;
            realizarVendaToolStripMenuItem.Name = "realizarVendaToolStripMenuItem";
            realizarVendaToolStripMenuItem.Size = new Size(149, 22);
            realizarVendaToolStripMenuItem.Text = "Realizar Venda";
            // 
            // janelasToolStripMenuItem
            // 
            janelasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { organizarToolStripMenuItem, exibirAtivasToolStripMenuItem, fecharTodasToolStripMenuItem });
            janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            janelasToolStripMenuItem.Size = new Size(56, 20);
            janelasToolStripMenuItem.Text = "Janelas";
            // 
            // organizarToolStripMenuItem
            // 
            organizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { horizontalToolStripMenuItem, verticalToolStripMenuItem, cascataToolStripMenuItem });
            organizarToolStripMenuItem.Name = "organizarToolStripMenuItem";
            organizarToolStripMenuItem.Size = new Size(143, 22);
            organizarToolStripMenuItem.Text = "Organizar";
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(129, 22);
            horizontalToolStripMenuItem.Text = "Horizontal";
            horizontalToolStripMenuItem.Click += horizontalToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(129, 22);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // cascataToolStripMenuItem
            // 
            cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            cascataToolStripMenuItem.Size = new Size(129, 22);
            cascataToolStripMenuItem.Text = "Cascata";
            cascataToolStripMenuItem.Click += cascataToolStripMenuItem_Click;
            // 
            // exibirAtivasToolStripMenuItem
            // 
            exibirAtivasToolStripMenuItem.Name = "exibirAtivasToolStripMenuItem";
            exibirAtivasToolStripMenuItem.Size = new Size(143, 22);
            exibirAtivasToolStripMenuItem.Text = "Exibir Ativas";
            exibirAtivasToolStripMenuItem.Click += exibirAtivasToolStripMenuItem_Click;
            // 
            // fecharTodasToolStripMenuItem
            // 
            fecharTodasToolStripMenuItem.Name = "fecharTodasToolStripMenuItem";
            fecharTodasToolStripMenuItem.Size = new Size(143, 22);
            fecharTodasToolStripMenuItem.Text = "Fechar Todas";
            fecharTodasToolStripMenuItem.Click += fecharTodasToolStripMenuItem_Click;
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem, sairToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(104, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(104, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.IFSP1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Vendas";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem realizarVendaToolStripMenuItem;
        private ToolStripMenuItem janelasToolStripMenuItem;
        private ToolStripMenuItem organizarToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripMenuItem cascataToolStripMenuItem;
        private ToolStripMenuItem fecharTodasToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem exibirAtivasToolStripMenuItem;
    }
}
