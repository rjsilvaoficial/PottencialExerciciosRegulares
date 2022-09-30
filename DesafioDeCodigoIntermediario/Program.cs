using System;
using System.Threading;

namespace DesafioDeCodigoIntermediario
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            
            Console.WriteLine("Bem vindo aos desafios intermediários C# do bootcamp Pottencial!");
            Console.WriteLine();
            Console.WriteLine("Selecione uma opção para seguir:");
            Console.WriteLine();
            Console.WriteLine("1 - Exercício 1 : Elemento Majoritário");
            Console.WriteLine("0 - Encerrar aplicação");
            string opcao = "";
            do
            {
                opcao = Console.ReadLine();
                SelecionarOpcao(opcao);
            }
            while (opcao != "0");
        }
        static void SelecionarOpcao(string opcao)
        {
            switch (opcao)
            {
                case "0":
                    Environment.Exit(0); break;
                case "1":
                    ElementoMajoritário.ExecutarCodigo(); break;
                default:
                    Console.WriteLine("Selecione uma opção válida!"); break;
            }
        }
    }
}
