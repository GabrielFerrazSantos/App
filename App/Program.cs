using App;
using App.Entidades;
using App.Service;
using App.View;
namespace App
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            Tela tela = new Tela();
            tela.ShowDialog();
        }
    }
}