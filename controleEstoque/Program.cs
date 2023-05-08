namespace controleEstoque
{
    internal class Program
    {
        enum Option { Sair, Novo, Listar, Remover, Entrada, Saida}

        static void Main(string[] args)
        {
            bool endProgram = false;
            int select = -1;

            List<Filme> estoqueFilmes = new List<Filme>();

            do
            {
                Metodos.printMenu();
                select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case (int)Option.Sair:
                        endProgram = true;
                        break;
                    case (int)Option.Novo:
                        Metodos.Novo(estoqueFilmes);
                        break;
                    case (int)Option.Listar:
                        Metodos.Listar(estoqueFilmes);
                        break;
                    case (int)Option.Remover:
                        Metodos.Remover(estoqueFilmes);
                        break;
                    case (int)Option.Entrada:
                        Metodos.Entrada(estoqueFilmes);
                        break;
                    case (int)Option.Saida:
                        Metodos.Saida(estoqueFilmes);
                        break;
                    default:
                        Console.Write("Opção invalida! ");
                        Console.ReadKey();
                        break;
                }
            } while (!endProgram);

            Console.WriteLine("\n\nFechando o programa...");
            Console.ReadKey();
        }
    }
}