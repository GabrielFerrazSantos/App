namespace Tela
{
    public partial class Tela
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
            this.ArquivoDialog = new System.Windows.Forms.OpenFileDialog();
            this.BotaoArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoArquivo
            // 
            this.BotaoArquivo.Location = new System.Drawing.Point(335, 299);
            this.BotaoArquivo.Name = "BotaoArquivo";
            this.BotaoArquivo.Size = new System.Drawing.Size(135, 43);
            this.BotaoArquivo.TabIndex = 0;
            this.BotaoArquivo.Text = "Selecionar";
            this.BotaoArquivo.UseVisualStyleBackColor = true;
            this.BotaoArquivo.Click += new System.EventHandler(this.BotaoArquivo_Click);
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotaoArquivo);
            this.Name = "Tela";
            this.Text = "Tela";
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog ArquivoDialog;
        private Button BotaoArquivo;
    }
}