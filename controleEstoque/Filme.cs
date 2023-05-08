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
        public int Quantidade { get; set;}
        public double Preco { get; set; }
        public int Ano { get; set; }
        public string? Classificacao { get; set;}
        public string? Diretor { get; set;}
    }
}
