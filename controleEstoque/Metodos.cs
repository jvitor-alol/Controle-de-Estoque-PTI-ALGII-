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
            Console.WriteLine("   | [1] Novo               [4] Entrada Estoque |   ");
            Console.WriteLine("   | [2] Listar Produtos    [5] Saída Estoque   |   ");
            Console.WriteLine("   | [3] Remover Produtos   [0] Sair            |   ");
        }

        public static void Novo(List<Filme> estoqueFilmes, ref int idAdicional)
        {
            Console.WriteLine("\n###### Adicionando novo filme ao estoque ######\n");
            Console.Write("Título                   : ");
            string? nome = Console.ReadLine();
            Console.Write("Quantidade               : ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Preço                    : ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ano                      : ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Classificação Indicativa : ");
            string? classificacao = Console.ReadLine();
            Console.Write("Duração (minutos)        : ");
            int minutos = Convert.ToInt32(Console.ReadLine());

            Filme filmeAdicionado = new Filme(nome, idAdicional, quantidade, preco, ano, classificacao, minutos);
            estoqueFilmes.Add(filmeAdicionado);
            idAdicional++;
            string sID = String.Format("{0:D8}", filmeAdicionado.ID);
            Console.WriteLine($"\n{filmeAdicionado.nome} adicionado ao estoque. ID = {sID}.");

            estoqueFilmes.Sort((s1,s2) => s1.nome.CompareTo(s2.nome));
            //Console.WriteLine("Estoque ordenado por ordem alfabética...");
            Console.Write("\nProsseguir...");
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
                Console.WriteLine("|            Título            |   ID   | Ano |Faixa Etária|Duração (minutos)| Qtd. |  Preço  |");
                foreach (Filme filme in estoqueFilmes)
                {
                    string sPreco = String.Format("{0:C2}", filme.preco);
                    string sID = String.Format("{0:D8}", filme.ID);
                    if (filme.nome?.Length < 30)
                        Console.WriteLine(String.Format($"|{filme.nome,-30}|{sID,-8}|{filme.ano,-5}|{filme.Classificacao,-12}|{filme.duracao,-17}|{filme.quantidade,-6}|{sPreco,-9}|"));
                    else
                    {
                        string sNome = filme.nome?.Substring(0, 26) + "..."; 
                        Console.WriteLine(String.Format($"|{sNome,-30}|{sID,-8}|{filme.ano,-5}|{filme.Classificacao,-12}|{filme.duracao,-17}|{filme.quantidade,-6}|{sPreco,-9}|"));
                    }

                }
            }
            Console.Write("\nProsseguir...");
            Console.ReadKey();
        }
        public static void Remover(List<Filme> estoqueFilmes)
        {
            Console.WriteLine("\n###### Remoção de filmes da lista ######\n");
            if (estoqueFilmes.Count() > 0)
            {
                Console.Write("Remover pelo título ou pelo ID do filme? [0/1] ");
                int select = Convert.ToInt32(Console.ReadLine());
                bool deletadoSucesso = false;

                switch (select)
                {
                    case 0:
                        Console.Write("Digite o título do filme a ser deletado: ");
                        string? nomeDeletado = Console.ReadLine();
                        foreach (Filme filme in estoqueFilmes)
                        {
                            if (string.Equals(filme.nome, nomeDeletado, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"\n{filme.nome} deletado do sistema.");
                                deletadoSucesso = estoqueFilmes.Remove(filme);
                                break;
                            }
                        }
                        if (!deletadoSucesso)
                            Console.WriteLine($"\nNenhum filme com o nome '{nomeDeletado}' encontrado...");
                        Console.Write("Prosseguir...");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Write("Digite o ID do filme a ser deletado: ");
                        int idDeletado = Convert.ToInt32(Console.ReadLine());
                        foreach (Filme filme in estoqueFilmes)
                        {
                            if (idDeletado == filme.ID)
                            {
                                Console.WriteLine($"\n{filme.nome} deletado do sistema.");
                                deletadoSucesso = estoqueFilmes.Remove(filme);
                                break;
                            }
                        }
                        if (!deletadoSucesso)
                            Console.WriteLine(String.Format($"\nID {idDeletado:D8} não encontrado..."));
                        Console.Write("Prosseguir...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Operação inválida... Voltando ao menu principal.");
                        Console.ReadKey();
                        break;
                }
            } 
            else
            {
                Console.WriteLine("Nenhum filme no sistema!");
                Console.Write("Prosseguir...");
                Console.ReadKey();
            }
        }
        public static void Entrada(List<Filme> estoqueFilmes)
        {
            Console.Write("\nProsseguir...");
            Console.ReadKey();
        }
        public static void Saida(List<Filme> estoqueFilmes)
        {
            Console.Write("\nProsseguir...");
            Console.ReadKey();
        }
    }
}
