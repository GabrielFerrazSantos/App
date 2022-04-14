using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela
{
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();
        }

        private void BotaoArquivo_Click(object sender, EventArgs e)
        {
            ArquivoDialog.Title = "Escolha um arquivo para leitura";
            ArquivoDialog.ShowDialog();
            string Caminho = ArquivoDialog.FileName;
        }
    }
}
