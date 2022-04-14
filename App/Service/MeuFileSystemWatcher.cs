using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.View;

namespace App.Service
{
    public class MeuFileSystemWatcher : FileSystemWatcher
    {
        public Tela Tela { get; set; }
        public MeuFileSystemWatcher(string caminho, Tela tela) : base(caminho)
        {
            this.Tela = tela;
        }
    }
}
