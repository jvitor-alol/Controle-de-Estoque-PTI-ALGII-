using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque
{
    public class Filme
    {
        public string? nome;
        private int id;
        public int quantidade;
        public double preco;
        public int ano;
        private string? classificacao;
        public int duracao;

        public Filme (string? aNome, int aID, int aQuantidade, double aPreco, int aAno, string? aClassificacao, int aDuracao)
        {
            nome = aNome;
            ID = aID;
            quantidade = aQuantidade;
            preco = aPreco;
            ano = aAno;
            Classificacao = aClassificacao;
            duracao = aDuracao;
        }
        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string? Classificacao 
        { 
            get { return classificacao; } 
            set 
            {
                if (value == "L" || value == "10" || value == "12" || value == "14" || value == "16" || value == "18")
                {
                    classificacao = value;
                }
                else
                    classificacao = "18";
            } 
        }
    }
}
