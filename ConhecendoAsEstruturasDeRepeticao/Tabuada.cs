using System;
using System.Collections.Generic;
using System.Text;

namespace ConhecendoAsEstruturasDeRepeticao
{
    public static class Tabuada
    {
        public static void CalcularTabuadaUsandoFor()
        {
            Console.WriteLine("Você selecionou tabuada!");
            Console.WriteLine();
            Console.Write("Digite o número do qual deseja saber a tabuada:");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{input} x {i} = {input * i}");
            }
            Console.ReadKey();
            Console.Clear();

        }

        public static void CalcularTabuadaUsandoForComSalto()
        {
            Console.WriteLine("Você selecionou tabuada com salto!");
            Console.WriteLine();
            Console.Write("Digite o número do qual deseja saber a tabuada sem multiplicação pelos pares: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine($"{input} x {i} = {input * i}");

            }

            Console.ReadKey();
            Console.Clear();
        }

    }
}
