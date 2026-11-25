namespace SistemaVendas
{
    partial class FormProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            label5 = new Label();
            label3 = new Label();
            textBoxPrecoProduto = new TextBox();
            label2 = new Label();
            textBoxNomeProduto = new TextBox();
            label1 = new Label();
            textBoxCodigoProduto = new TextBox();
            comboBoxCategoriaProduto = new ComboBox();
            buttonNovoProduto = new Button();
            buttonSalvarProduto = new Button();
            buttonAlterarProduto = new Button();
            buttonConsultarProduto = new Button();
            buttonFecharProduto = new Button();
            buttonExcluirProduto = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 140);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 21;
            label5.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 100);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 18;
            label3.Text = "Preço";
            // 
            // textBoxPrecoProduto
            // 
            textBoxPrecoProduto.Location = new Point(153, 97);
            textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            textBoxPrecoProduto.Size = new Size(100, 23);
            textBoxPrecoProduto.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 60);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 16;
            label2.Text = "Nome";
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.Location = new Point(153, 57);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(100, 23);
            textBoxNomeProduto.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 14;
            label1.Text = "Código do Produto";
            // 
            // textBoxCodigoProduto
            // 
            textBoxCodigoProduto.Location = new Point(153, 22);
            textBoxCodigoProduto.Name = "textBoxCodigoProduto";
            textBoxCodigoProduto.Size = new Size(100, 23);
            textBoxCodigoProduto.TabIndex = 13;
            // 
            // comboBoxCategoriaProduto
            // 
            comboBoxCategoriaProduto.FormattingEnabled = true;
            comboBoxCategoriaProduto.Location = new Point(153, 137);
            comboBoxCategoriaProduto.Name = "comboBoxCategoriaProduto";
            comboBoxCategoriaProduto.Size = new Size(100, 23);
            comboBoxCategoriaProduto.TabIndex = 12;
            // 
            // buttonNovoProduto
            // 
            buttonNovoProduto.Location = new Point(28, 186);
            buttonNovoProduto.Name = "buttonNovoProduto";
            buttonNovoProduto.Size = new Size(75, 23);
            buttonNovoProduto.TabIndex = 36;
            buttonNovoProduto.Text = "Novo";
            buttonNovoProduto.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarProduto
            // 
            buttonSalvarProduto.Enabled = false;
            buttonSalvarProduto.Location = new Point(109, 215);
            buttonSalvarProduto.Name = "buttonSalvarProduto";
            buttonSalvarProduto.Size = new Size(75, 23);
            buttonSalvarProduto.TabIndex = 37;
            buttonSalvarProduto.Text = "Salvar";
            buttonSalvarProduto.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarProduto
            // 
            buttonAlterarProduto.Enabled = false;
            buttonAlterarProduto.Location = new Point(190, 186);
            buttonAlterarProduto.Name = "buttonAlterarProduto";
            buttonAlterarProduto.Size = new Size(75, 23);
            buttonAlterarProduto.TabIndex = 39;
            buttonAlterarProduto.Text = "Alterar";
            buttonAlterarProduto.UseVisualStyleBackColor = true;
            // 
            // buttonConsultarProduto
            // 
            buttonConsultarProduto.Location = new Point(109, 186);
            buttonConsultarProduto.Name = "buttonConsultarProduto";
            buttonConsultarProduto.Size = new Size(75, 23);
            buttonConsultarProduto.TabIndex = 38;
            buttonConsultarProduto.Text = "Consultar";
            buttonConsultarProduto.UseVisualStyleBackColor = true;
            // 
            // buttonFecharProduto
            // 
            buttonFecharProduto.Location = new Point(190, 215);
            buttonFecharProduto.Name = "buttonFecharProduto";
            buttonFecharProduto.Size = new Size(75, 23);
            buttonFecharProduto.TabIndex = 41;
            buttonFecharProduto.Text = "Fechar";
            buttonFecharProduto.UseVisualStyleBackColor = true;
            buttonFecharProduto.Click += buttonFecharProduto_Click;
            // 
            // buttonExcluirProduto
            // 
            buttonExcluirProduto.Enabled = false;
            buttonExcluirProduto.Location = new Point(28, 215);
            buttonExcluirProduto.Name = "buttonExcluirProduto";
            buttonExcluirProduto.Size = new Size(75, 23);
            buttonExcluirProduto.TabIndex = 40;
            buttonExcluirProduto.Text = "Excluir";
            buttonExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 262);
            Controls.Add(buttonFecharProduto);
            Controls.Add(buttonExcluirProduto);
            Controls.Add(buttonAlterarProduto);
            Controls.Add(buttonConsultarProduto);
            Controls.Add(buttonSalvarProduto);
            Controls.Add(buttonNovoProduto);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBoxPrecoProduto);
            Controls.Add(label2);
            Controls.Add(textBoxNomeProduto);
            Controls.Add(label1);
            Controls.Add(textBoxCodigoProduto);
            Controls.Add(comboBoxCategoriaProduto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private TextBox textBoxRGCliente;
        private Label label3;
        private TextBox textBoxPrecoProduto;
        private Label label2;
        private TextBox textBoxNomeProduto;
        private Label label1;
        private TextBox textBoxCodigoProduto;
        private ComboBox comboBoxCategoriaProduto;
        private Button buttonNovoProduto;
        private Button buttonSalvarProduto;
        private Button buttonAlterarProduto;
        private Button buttonConsultarProduto;
        private Button buttonFecharProduto;
        private Button buttonExcluirProduto;
    }
}