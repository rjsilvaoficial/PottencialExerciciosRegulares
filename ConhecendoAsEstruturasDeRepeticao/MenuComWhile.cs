using System;
using System.Collections.Generic;
using System.Text;

namespace ConhecendoAsEstruturasDeRepeticao
{
    public static class MenuComWhile
    {
        public static void ApresentarInterfaceDeUsuario()
        {
            string opcao;
            bool exibirMenu = true;



            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine();
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Buscar cliente");
                Console.WriteLine("3 - Apagar cliente");
                Console.WriteLine("4 - Encerrar");
                Console.WriteLine("5 - Tabuada normal");
                Console.WriteLine("6 - Tabuada pulando pares");
                Console.WriteLine("7 - Somar com do while");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro de cliente");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Busca de cliente");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Apaga cliente");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Encerrar");
                        exibirMenu = false;
                        //Environment.Exit(0);
                        break;
                    case "5":
                        Console.WriteLine("Tabuada normal");
                        Tabuada.CalcularTabuadaUsandoFor();
                        break;
                    case "6":
                        Console.WriteLine("Tabuada pulando pares");
                        Tabuada.CalcularTabuadaUsandoForComSalto();
                        break;
                    case "7":
                        Console.WriteLine("Somar usando do while");
                        Soma.SomarComDoWhile();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
