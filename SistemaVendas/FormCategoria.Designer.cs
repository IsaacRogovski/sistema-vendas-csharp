namespace SistemaVendas
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            label2 = new Label();
            textBoxNomeCategoria = new TextBox();
            label1 = new Label();
            textBoxCodigoCategoria = new TextBox();
            buttonFecharCategoria = new Button();
            buttonExcluirCategoria = new Button();
            buttonAlterarCategoria = new Button();
            buttonConsultarCategoria = new Button();
            buttonSalvarCategoria = new Button();
            buttonNovoCategoria = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 83);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // textBoxNomeCategoria
            // 
            textBoxNomeCategoria.Location = new Point(155, 80);
            textBoxNomeCategoria.Name = "textBoxNomeCategoria";
            textBoxNomeCategoria.Size = new Size(100, 23);
            textBoxNomeCategoria.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 48);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 7;
            label1.Text = "Código da Categoria";
            // 
            // textBoxCodigoCategoria
            // 
            textBoxCodigoCategoria.Location = new Point(155, 45);
            textBoxCodigoCategoria.Name = "textBoxCodigoCategoria";
            textBoxCodigoCategoria.Size = new Size(100, 23);
            textBoxCodigoCategoria.TabIndex = 6;
            // 
            // buttonFecharCategoria
            // 
            buttonFecharCategoria.Location = new Point(180, 164);
            buttonFecharCategoria.Name = "buttonFecharCategoria";
            buttonFecharCategoria.Size = new Size(75, 23);
            buttonFecharCategoria.TabIndex = 53;
            buttonFecharCategoria.Text = "Fechar";
            buttonFecharCategoria.UseVisualStyleBackColor = true;
            buttonFecharCategoria.Click += buttonFecharCategoria_Click;
            // 
            // buttonExcluirCategoria
            // 
            buttonExcluirCategoria.Enabled = false;
            buttonExcluirCategoria.Location = new Point(99, 164);
            buttonExcluirCategoria.Name = "buttonExcluirCategoria";
            buttonExcluirCategoria.Size = new Size(75, 23);
            buttonExcluirCategoria.TabIndex = 52;
            buttonExcluirCategoria.Text = "Excluir";
            buttonExcluirCategoria.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarCategoria
            // 
            buttonAlterarCategoria.Enabled = false;
            buttonAlterarCategoria.Location = new Point(180, 135);
            buttonAlterarCategoria.Name = "buttonAlterarCategoria";
            buttonAlterarCategoria.Size = new Size(75, 23);
            buttonAlterarCategoria.TabIndex = 51;
            buttonAlterarCategoria.Text = "Alterar";
            buttonAlterarCategoria.UseVisualStyleBackColor = true;
            // 
            // buttonConsultarCategoria
            // 
            buttonConsultarCategoria.Location = new Point(99, 135);
            buttonConsultarCategoria.Name = "buttonConsultarCategoria";
            buttonConsultarCategoria.Size = new Size(75, 23);
            buttonConsultarCategoria.TabIndex = 50;
            buttonConsultarCategoria.Text = "Consultar";
            buttonConsultarCategoria.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarCategoria
            // 
            buttonSalvarCategoria.Enabled = false;
            buttonSalvarCategoria.Location = new Point(18, 164);
            buttonSalvarCategoria.Name = "buttonSalvarCategoria";
            buttonSalvarCategoria.Size = new Size(75, 23);
            buttonSalvarCategoria.TabIndex = 49;
            buttonSalvarCategoria.Text = "Salvar";
            buttonSalvarCategoria.UseVisualStyleBackColor = true;
            // 
            // buttonNovoCategoria
            // 
            buttonNovoCategoria.Location = new Point(18, 135);
            buttonNovoCategoria.Name = "buttonNovoCategoria";
            buttonNovoCategoria.Size = new Size(75, 23);
            buttonNovoCategoria.TabIndex = 48;
            buttonNovoCategoria.Text = "Novo";
            buttonNovoCategoria.UseVisualStyleBackColor = true;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 220);
            Controls.Add(buttonFecharCategoria);
            Controls.Add(buttonExcluirCategoria);
            Controls.Add(buttonAlterarCategoria);
            Controls.Add(buttonConsultarCategoria);
            Controls.Add(buttonSalvarCategoria);
            Controls.Add(buttonNovoCategoria);
            Controls.Add(label2);
            Controls.Add(textBoxNomeCategoria);
            Controls.Add(label1);
            Controls.Add(textBoxCodigoCategoria);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBoxNomeCategoria;
        private Label label1;
        private TextBox textBoxCodigoCategoria;
        private Button buttonFecharCategoria;
        private Button buttonExcluirCategoria;
        private Button buttonAlterarCategoria;
        private Button buttonConsultarCategoria;
        private Button buttonSalvarCategoria;
        private Button buttonNovoCategoria;
    }
}