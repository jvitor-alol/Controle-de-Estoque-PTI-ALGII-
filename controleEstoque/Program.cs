namespace controleEstoque
{
    internal class Program
    {
        enum Option { Sair, Novo, Listar, Remover, Entrada, Saida }

        static void Main(string[] args)
        {
            bool endProgram = false;
            Option select;
            int idAdicional = 1;

            List<Filme> estoqueFilmes = new List<Filme>();

            do
            {
                Metodos.printMenu();
                Console.Write("\nOpção: ");
                select = (Option)Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case Option.Sair:
                        endProgram = true;
                        break;
                    case Option.Novo:
                        Metodos.Novo(estoqueFilmes, ref idAdicional);
                        break;
                    case Option.Listar:
                        Metodos.Listar(estoqueFilmes);
                        break;
                    case Option.Remover:
                        Metodos.Remover(estoqueFilmes);
                        break;
                    case Option.Entrada:
                        Metodos.Entrada(estoqueFilmes);
                        break;
                    case Option.Saida:
                        Metodos.Saida(estoqueFilmes);
                        break;
                    default:
                        Console.Write("Opção invalida!");
                        Console.ReadKey();
                        break;
                }
            } while (!endProgram);

            Console.WriteLine("\n###### Fechando o programa... ######");
            Console.ReadKey();
        }
    }
}



/*
 __                                                    
|  \                                                   
| ▓▓____   ______   _______  _______ __    __ _______  
| ▓▓    \ /      \ /       \/       \  \  |  \       \ 
| ▓▓▓▓▓▓▓\  ▓▓▓▓▓▓\  ▓▓▓▓▓▓▓  ▓▓▓▓▓▓▓ ▓▓  | ▓▓ ▓▓▓▓▓▓▓\
| ▓▓  | ▓▓ ▓▓  | ▓▓\▓▓    \ \▓▓    \| ▓▓  | ▓▓ ▓▓  | ▓▓
| ▓▓__/ ▓▓ ▓▓__/ ▓▓_\▓▓▓▓▓▓\_\▓▓▓▓▓▓\ ▓▓__/ ▓▓ ▓▓  | ▓▓
| ▓▓    ▓▓\▓▓    ▓▓       ▓▓       ▓▓\▓▓    ▓▓ ▓▓  | ▓▓
 \▓▓▓▓▓▓▓  \▓▓▓▓▓▓ \▓▓▓▓▓▓▓ \▓▓▓▓▓▓▓  \▓▓▓▓▓▓ \▓▓   \▓▓
 
*/
