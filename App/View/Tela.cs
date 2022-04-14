using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Service;
using App.Entidades;

namespace App.View
{
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();
        }

        private void Tela_Load(object sender, EventArgs e)
        {

        }

        private void CarregaParentes(List<Parentes> listaParentes)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("IdParentes");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Idade");
            dt.Columns.Add("Parentesco");

            foreach (Parentes parentes in listaParentes)
            {
                DataRow linha = dt.NewRow();

                linha["Id"] = parentes.Id;
                linha["IdParentes"] = parentes.IdParentes;
                linha["Nome"] = parentes.Nome;
                linha["Idade"] = parentes.Idade;
                linha["Parentesco"] = parentes.Parentesco;

                dt.Rows.Add(linha);
            }

            dataGridView2.Invoke(new Action(() => dataGridView2.DataSource = dt));
        }

        private void CarregaPessoas(List<Pessoa> listaPessoas)
        {
            Console.WriteLine("teste");
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Idade");
            dt.Columns.Add("Telefone");
            dt.Columns.Add("Cidade");

            foreach (Pessoa pessoa in listaPessoas)
            {
                DataRow linha = dt.NewRow();

                linha["Id"] = pessoa.Id;
                linha["Nome"] = pessoa.Nome;
                linha["Idade"] = pessoa.Idade;
                linha["Telefone"] = pessoa.Telefone;
                linha["Cidade"] = pessoa.Cidade;

                dt.Rows.Add(linha);
            }

            dataGridView1.Invoke(new Action(() => dataGridView1.DataSource = dt));
        }


        private void BotaoArquivo_Click(object sender, EventArgs e)
        {
            FileDialog.Title = "Selecione um arquivo";
            FileDialog.ShowDialog();
            string caminho = FileDialog.FileName;
            int indicePasta = caminho.LastIndexOf("\\");
            string pasta = caminho.Substring(0, indicePasta);

            MeuFileSystemWatcher watcher = new MeuFileSystemWatcher(pasta, this);
            watcher.NotifyFilter = NotifyFilters.Attributes
                     | NotifyFilters.CreationTime
                     | NotifyFilters.DirectoryName
                     | NotifyFilters.FileName
                     | NotifyFilters.LastAccess
                     | NotifyFilters.LastWrite
                     | NotifyFilters.Security
                     | NotifyFilters.Size;

            watcher.Changed += OnChanged;

            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

            if (caminho.Contains("Parentes.txt"))
            {
                CarregaParentes(Leitura.LerParentes(caminho));
            }
            else
            {
                CarregaPessoas(Leitura.LerCadastro(caminho));
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedCells[0].OwningRow;
            string id = row.Cells[0].Value.ToString();

            foreach (DataGridViewRow parenteRow in dataGridView2.Rows)
            {
                dataGridView2.CurrentCell = null;
                parenteRow.Visible = true;
            }

            foreach (DataGridViewRow parenteRow in dataGridView2.Rows)
            {
                if (!parenteRow.Cells[0].Value.Equals(id))
                {
                    dataGridView2.CurrentCell = null;
                    parenteRow.Visible = false;
                }
            }
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            string caminho = e.FullPath;

            if (sender is MeuFileSystemWatcher)
            {
                MeuFileSystemWatcher fileWatcher = sender as MeuFileSystemWatcher;
                Tela tela = fileWatcher.Tela;

                if (caminho.Contains("Parentes.txt"))
                {
                    tela.CarregaParentes(Leitura.LerParentes(caminho));
                }
                else
                {
                    tela.CarregaPessoas(Leitura.LerCadastro(caminho));
                }
            }
        }
    }
}
