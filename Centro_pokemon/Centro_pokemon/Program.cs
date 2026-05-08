using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.AccessControl;

namespace Centro_pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 6)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@"
██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║
██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║
██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n1 - Cadastro de Pokemon");
                Console.WriteLine("\n2 - Cadastro de Pokebola");
                Console.WriteLine("\n3 - Cadastro de Treinadores");
                Console.WriteLine("\n4 - Cadastro de Cidades");
                Console.WriteLine("\n5 - Cadastro de Ginásios");
                Console.WriteLine("\n6 - Sair");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n Digite a opção escolhida");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());  


                switch (opcao)
                {
                    case 1:
                        CadastroPokemon();
                        break;
                    case 2:
                        CadastroPokebola();
                        break;
                    case 3:
                        CadastroTreinadores();
                        break;
                    case 4:
                        CadastroCidades();
                        break;
                    case 5:
                        CadastroGinasios();
                        break;
                    case 6:
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n Opção inválida, tente novamente");
                        Console.ResetColor();
                        Thread.Sleep(1300); //pausa na programação por 1.3 segundos para o usuário ler a mensagem
                        break;



                }
            }
        }
        static void CadastroPokemon()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗   
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║   
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░ 
");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("\n Nome do Pokemon: ");
            string nomePokemon = Console.ReadLine();

            Console.WriteLine("\nStatus do Pokemon: ");
            string statusPokemon = Console.ReadLine();

            Console.WriteLine("\n QTD de Golpes do Pokemon: ");
            int qtdGolpes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdGolpes; i++)
            {
                Console.WriteLine($"\n Golpe {i}: ");
                string nomeGolpe = Console.ReadLine();
            }

            Console.WriteLine("\n Quantidade de Evolução do Pokemon: ");
            int qtdEvolucao = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdEvolucao; i++)
            {
                Console.WriteLine($"\n evolucão {i} do pokemon:");
                string NameEVO = Console.ReadLine();
            }

            Console.WriteLine("\nQual o elemento do seu pokemon: ");
            string elementoPokemon = Console.ReadLine();


            Console.WriteLine("\n Quantas fraqueza tem seu pokemon: ");
            int qtdFraqueza = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdFraqueza; i++)
            {
                Console.WriteLine($"\n Fraqueza {i} do pokemon:");
                string nomeFraqueza = Console.ReadLine();
            }

            Console.WriteLine("Qual a raridade do seu pokemon? ");
            string raridadepokemon = Console.ReadLine();

            Console.WriteLine("\n Qual a altura do seu pokemon? ");
            double alturaPokemon = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Qual o peso do seu pokemon? ");
            double pesoPokemon = double.Parse(Console.ReadLine());

            Console.WriteLine("\n O Pokemon foi cadastrado com sucesso!");



            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Thread.Sleep(7000);


        }

        static void CadastroPokebola()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.WriteLine(@"◓ 
██████╗░░█████╗░██╗░░██╗███████╗██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝
██████╔╝██║░░██║█████═╝░█████╗░░██████╦╝██║░░██║██║░░░░░███████║╚█████╗░
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██╔══██╗██║░░██║██║░░░░░██╔══██║░╚═══██╗
██║░░░░░╚█████╔╝██║░╚██╗███████╗██████╦╝╚█████╔╝███████╗██║░░██║██████╔╝
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═════╝░░╚════╝░╚══════╝╚═╝░░╚═╝╚═════╝░ ◓");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;


            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nQual sua Pokebola:");
            string nomePokebola = Console.ReadLine();
            Console.WriteLine("\nQual a cor da sua pokebola? ");
            string corPokebola = Console.ReadLine();
            Console.WriteLine("\nQual a chance de captura dela? ");
            string forçaPokebola = Console.ReadLine();
            Thread.Sleep(1500);
        }



        static void CadastroTreinadores()
        {
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
████████╗██████╗░███████╗██╗███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░███████╗░██████╗
╚══██╔══╝██╔══██╗██╔════╝██║████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝
░░░██║░░░██████╔╝█████╗░░██║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝█████╗░░╚█████╗░
░░░██║░░░██╔══██╗██╔══╝░░██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗██╔══╝░░░╚═══██╗
░░░██║░░░██║░░██║███████╗██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║███████╗██████╔╝
░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Qual o nome do seu treinador: ");
            string nomeTreinador = Console.ReadLine();

            Console.WriteLine("Quantos pokemons ele tem? ");
            int qtdpokemon = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdpokemon; i++)
            {
                Console.WriteLine($"\n Pokemon {i} do treinador:");
                string nomePokemon = Console.ReadLine();
            }



            Console.WriteLine("Quantas vitórias o treinador  tem na carreira? ");
            string ww = Console.ReadLine();



            Console.WriteLine("Qual a região de Origem do treinador  ?");
            string regiao = Console.ReadLine();

            Console.WriteLine("Qual a idade do treinador? ");
            string idade = Console.ReadLine();


            Thread.Sleep(2500);


        }









        static void CadastroCidades()
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
░█████╗░██╗██████╗░░█████╗░██████╗░███████╗░██████╗
██╔══██╗██║██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝
██║░░╚═╝██║██║░░██║███████║██║░░██║█████╗░░╚█████╗░
██║░░██╗██║██║░░██║██╔══██║██║░░██║██╔══╝░░░╚═══██╗
╚█████╔╝██║██████╔╝██║░░██║██████╔╝███████╗██████╔╝
░╚════╝░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░╚══════╝╚═════╝░");





            Console.WriteLine("\nQual a cidade que o treinador reside? ");
            string nomeCidade = Console.ReadLine();
            Console.WriteLine("\nQual região esta cidade fica: ");
            string regiao = Console.ReadLine();
            Thread.Sleep(2500);
        }
        static void CadastroGinasios()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
░██████╗░██╗███╗░░██╗░█████╗░░██████╗██╗░█████╗░
██╔════╝░██║████╗░██║██╔══██╗██╔════╝██║██╔══██╗
██║░░██╗░██║██╔██╗██║███████║╚█████╗░██║██║░░██║
██║░░╚██╗██║██║╚████║██╔══██║░╚═══██╗██║██║░░██║
╚██████╔╝██║██║░╚███║██║░░██║██████╔╝██║╚█████╔╝
░╚═════╝░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░╚═╝░╚════╝░");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nQual o Nome do Ginasio: ");
            string namegin = Console.ReadLine();


            Console.WriteLine("\nQual o nome do lider do Ginásio?");
            string nameLider = Console.ReadLine();
            Thread.Sleep(3500);

        }

    }
}




      

