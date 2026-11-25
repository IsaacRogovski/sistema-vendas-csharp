namespace SistemaVendas
{
    partial class FormSobre
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
            richTextBoxSobre = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxSobre
            // 
            richTextBoxSobre.Dock = DockStyle.Fill;
            richTextBoxSobre.Location = new Point(0, 0);
            richTextBoxSobre.Name = "richTextBoxSobre";
            richTextBoxSobre.ReadOnly = true;
            richTextBoxSobre.Size = new Size(346, 211);
            richTextBoxSobre.TabIndex = 0;
            richTextBoxSobre.Text = "";
            // 
            // FormSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 211);
            Controls.Add(richTextBoxSobre);
            Name = "FormSobre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre";
            Load += FormSobre_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxSobre;
    }
}