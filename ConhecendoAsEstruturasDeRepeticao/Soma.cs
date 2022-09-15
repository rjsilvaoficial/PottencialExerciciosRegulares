using System;
using System.Collections.Generic;
using System.Text;

namespace ConhecendoAsEstruturasDeRepeticao
{
    public static class Soma
    {
        public static void SomarComDoWhile()
        {
            Console.WriteLine("Você selecionou Somar com do while!");
            Console.WriteLine();
            Console.Write("Digite um número e aperte enter para acrescentar na soma (0 - para ver o resultado)");
            Console.WriteLine();
            int resultado = 0;
            int numeroInputado = 0;
            do
            {
                numeroInputado = Convert.ToInt32(Console.ReadLine());
                resultado += numeroInputado;

            }
            while (numeroInputado != 0);

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
