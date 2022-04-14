using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entidades
{
    public class Parentes
    {
        public long Id { get; set; }
        public long IdParentes { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Parentesco { get; set; }

        public Parentes(long Id, long IdParentes, string Nome, int Idade, string Parentesco)
        {
            this.Id = Id;
            this.IdParentes = IdParentes;
            this.Nome = Nome;
            this.Idade = Idade;
            this.Parentesco = Parentesco;
        }

        public override string ToString()
        {
            return $"Id: {Id};IdParentes: {IdParentes}; Nome: {Nome};Idade: {Idade};Parentesco: {Parentesco}";
        }
    }
}