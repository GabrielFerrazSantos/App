namespace View
{
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Escolha um arquivo para leitura";
            openFileDialog1.ShowDialog();
            string Caminho = openFileDialog1.FileName;
        }
    }
}