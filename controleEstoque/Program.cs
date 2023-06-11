namespace controleEstoque
{
    internal class Program
    {
        enum Option { Sair, Novo, Listar, Remover, Entrada, Saida }
        public static int idAdicional = 1;

        static void Main(string[] args)
        {
            bool endProgram = false;
            Option select;
            int opcao = 0; //temporario para testes com leitura e escrita de arquivos persistentes
            string caminhoAbsoluto = "~/Development/Controle-de-Estoque-PTI-ALGII-/controleEstoque/estoquePersist.txt";
            List<Filme> estoqueFilmes = new List<Filme>();

            //escolher usar base de dados ou não
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao){
                case 0:
                    //usa arquivo de texto
                    Console.WriteLine("Recuperando base de dados...");
                    lerEstoque(estoqueFilmes, caminhoAbsoluto, ref idAdicional);
                    break;
                case 1:
                    Console.WriteLine("Recriando base de dados...");
                    break;
                default:
                    Console.WriteLine("Opção invalida!!!");
                    endProgram = true;
                    break;
            }

            do
            {
                Metodos.printMenu();
                Console.Write("\nOpção: ");
                select = (Option)Convert.ToInt32(Console.ReadLine()); //testar depois sem o cast, creio que funcione

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

            Console.WriteLine("\n######## Salvando os dados... ########");
            salvarEstoque(estoqueFilmes, caminhoAbsoluto, idAdicional);

            Console.WriteLine("\n####### Fechando o programa... #######");
            Console.ReadKey();
        }

        private static void salvarEstoque(List<Filme> estoqueFilmes, string caminhoAbsoluto, int idAdicional)
        {
            //salvando base de dados no arquivo de texto
        }

        private static void lerEstoque(List<Filme> estoqueFilmes, string caminhoAbsoluto, ref int idAdicional)
        {
            //lendo arquivos do texto
            bool problemaArquivo = false;
            try{
                StreamReader sr = new StreamReader(caminhoAbsoluto);

            }
            catch (Exception e){
                
            }
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
