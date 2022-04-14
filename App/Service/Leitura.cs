using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App.Entidades;

namespace App.Service
{
    public class Leitura
    {
        public static List<Pessoa> LerCadastro(string caminho)
        {
            string[] linhas = System.IO.File.ReadAllLines(caminho);
            List<Pessoa> pessoaList = new List<Pessoa>();

            foreach (string linha in linhas)
            {
                if (linha.Equals(Constantes.Cabecalho))
                {
                    continue;
                }
                List<string> variaveis = new List<string>(Constantes.NumColunas);
                string[] dados = linha.Split(Constantes.Separador);

                for (int i = 0; i < Constantes.NumColunas; i++)
                {
                    variaveis.Add(dados[i]);
                }

                Pessoa pessoa = new Pessoa(long.Parse(variaveis[0]), variaveis[1], int.Parse(variaveis[2]), variaveis[3], variaveis[4]);
                pessoaList.Add(pessoa);
            }

            return pessoaList;
        }

        public static List<Parentes> LerParentes(string caminho)
        {
            string[] linhas = System.IO.File.ReadAllLines(caminho);
            List<Parentes> parentesList = new List<Parentes>();

            foreach (string linha in linhas)
            {
                if (linha.Equals(Constantes.CabecalhoParentes))
                {
                    continue;
                }
                List<string> variaveis = new List<string>(Constantes.NumColunas);
                string[] dados = linha.Split(Constantes.Separador);

                for (int i = 0; i < Constantes.NumColunas; i++)
                {
                    variaveis.Add(dados[i]);
                }

                Parentes parentes = new Parentes(long.Parse(variaveis[0]), long.Parse(variaveis[1]), (variaveis[2]), int.Parse(variaveis[3]), variaveis[4]);
                parentesList.Add(parentes);
            }

            return parentesList;
        }
    }
}
