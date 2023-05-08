using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque
{
    public class Metodos
    {
        public static void printMenu()
        {
            Console.Clear();
            Console.WriteLine("#### Controle de estoque de DVDs da Blockbuster ####\n");
            Console.WriteLine("|   [1] Novo              |  [4] Entrada Estoque   |");
            Console.WriteLine("|   [2] Listar Produtos   |  [5] Saída Estoque     |");
            Console.WriteLine("|   [3] Remover Produtos  |  [0] Sair              |");
        }

        public static void Novo(List<Filme> estoqueFilmes, ref int idAdicional)
        {
            Console.WriteLine("\n###### Adicionando novo filme ao estoque ######\n");
            Console.Write("Título                   : ");
            string? nome = Console.ReadLine();
            //Console.Write("ID                       : ");
            //int iD = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidade               : ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Preço                    : ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ano                      : ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Classificação Indicativa : ");
            string? classificacao = Console.ReadLine();
            Console.Write("Duração (em minutos)     : ");
            int minutos = Convert.ToInt32(Console.ReadLine());

            Filme filmeAdicionado = new Filme(nome, idAdicional, quantidade, preco, ano, classificacao, minutos);
            estoqueFilmes.Add(filmeAdicionado);
            idAdicional++;
            string sID = String.Format("{0:D8}", filmeAdicionado.ID);
            Console.WriteLine($"\n{filmeAdicionado.Nome} adicionado ao estoque. ID = {sID}.");

            estoqueFilmes.Sort((s1,s2) => s1.Nome.CompareTo(s2.Nome));
            Console.WriteLine("Estoque ordenado por ordem alfabética...");

            Console.ReadKey();
        }
        public static void Listar(List<Filme> estoqueFilmes)
        {
            Console.WriteLine("\n###### Lista de filmes em estoque ######\n");
            if(estoqueFilmes.Count() < 1)
            {
                Console.WriteLine("Nenhum filme adicionado ao sistema!");
            }
            else
            {  
                Console.WriteLine("|Título                        |ID                  |Qtd.  |Preço    |");
                foreach (Filme filme in estoqueFilmes)
                {
                    string sPreco = String.Format("{0:C2}", filme.Preco);
                    string sID = String.Format("{0:D8}", filme.ID);
                    if (filme.Nome.Length >= 30)
                    {
                        string sNome = filme.Nome.Substring(0, 26) + "...";
                        Console.WriteLine(String.Format("|{0,-30}|{1,-20}|{2,-6}|{3,-9}|", sNome, sID, filme.Quantidade, sPreco));
                    }
                    else
                        Console.WriteLine(String.Format("|{0,-30}|{1,-20}|{2,-6}|{3,-9}|", filme.Nome, sID, filme.Quantidade, sPreco));

                }
            }
            Console.ReadKey();
        }
        public static void Remover(List<Filme> estoqueFilmes)
        {
            Console.ReadKey();
        }
        public static void Entrada(List<Filme> estoqueFilmes)
        {
            Console.ReadKey();
        }
        public static void Saida(List<Filme> estoqueFilmes)
        {
            Console.ReadKey();
        }
    }
}
