namespace App.View
{
    partial class Tela
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
            this.components = new System.ComponentModel.Container();
            this.BotaoArquivo = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pessoasLabel = new System.Windows.Forms.Label();
            this.parentesLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BotaoArquivo
            // 
            this.BotaoArquivo.Location = new System.Drawing.Point(12, 27);
            this.BotaoArquivo.Name = "BotaoArquivo";
            this.BotaoArquivo.Size = new System.Drawing.Size(154, 41);
            this.BotaoArquivo.TabIndex = 0;
            this.BotaoArquivo.Text = "Selecionar";
            this.BotaoArquivo.UseVisualStyleBackColor = true;
            this.BotaoArquivo.Click += new System.EventHandler(this.BotaoArquivo_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(App.Entidades.Pessoa);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(209, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(568, 181);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pessoasLabel
            // 
            this.pessoasLabel.AutoSize = true;
            this.pessoasLabel.Location = new System.Drawing.Point(211, 4);
            this.pessoasLabel.Name = "pessoasLabel";
            this.pessoasLabel.Size = new System.Drawing.Size(48, 15);
            this.pessoasLabel.TabIndex = 2;
            this.pessoasLabel.Text = "Pessoas";
            // 
            // parentesLabel
            // 
            this.parentesLabel.AutoSize = true;
            this.parentesLabel.Location = new System.Drawing.Point(209, 230);
            this.parentesLabel.Name = "parentesLabel";
            this.parentesLabel.Size = new System.Drawing.Size(65, 15);
            this.parentesLabel.TabIndex = 3;
            this.parentesLabel.Text = "Parentesco";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(209, 248);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(568, 181);
            this.dataGridView2.TabIndex = 4;
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.parentesLabel);
            this.Controls.Add(this.pessoasLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BotaoArquivo);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Tela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela";
            this.Load += new System.EventHandler(this.Tela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BotaoArquivo;
        private OpenFileDialog FileDialog;
        private BindingSource pessoaBindingSource;
        private DataGridView dataGridView1;
        private Label pessoasLabel;
        private Label parentesLabel;
        private DataGridView dataGridView2;
    }
}