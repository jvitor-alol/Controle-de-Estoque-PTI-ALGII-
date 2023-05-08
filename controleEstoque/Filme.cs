using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque
{
    public class Filme
    {
        public string? Nome { get; set; }
        public int ID { get; set; }
        public int Quantidade { get; set;}
        public double Preco { get; set; }
        public int Ano { get; set; }
        public string? Classificacao { get; set;}
        public int Minutos { get; set;}

        public Filme(string? nome, int iD, int quantidade, double preco, int ano, string? classificacao, int minutos)
        {
            Nome = nome;
            ID = iD;
            Quantidade = quantidade;
            Preco = preco;
            Ano = ano;
            Classificacao = classificacao;
            Minutos = minutos;
        }
                
    }
}
