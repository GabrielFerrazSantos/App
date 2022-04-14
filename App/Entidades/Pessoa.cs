using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entidades
{
    public class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }

        public Pessoa(long Id, string Nome, int Idade, string Telefone, string Cidade)
        { 
            this.Id = Id;
            this.Nome = Nome;
            this.Idade = Idade;
            this.Telefone = Telefone;
            this.Cidade = Cidade;
        }

        public override string ToString()
        {
            return $"Id: {Id};Nome: {Nome};Idade: {Idade};Telefone: {Telefone};Cidade: {Cidade}";
        }
    }
}