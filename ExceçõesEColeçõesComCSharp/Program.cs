using System;
using System.Collections.Generic;

namespace ExceçõesEColeçõesComCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fila();
            Pilha();
            Dictionary();
        }


        //FIFO
        static void Fila()
        {
            Console.WriteLine("Este é o funcionamento da fila: ");
            Queue<int> fila = new Queue<int>();

            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);

            foreach (int i in fila)
            {
                Console.WriteLine(i);
            }

            fila.Dequeue();
            Console.WriteLine();
            foreach (int i in fila)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Fila é FIFO!");

        }

        //LIFO
        static void Pilha()
        {
            Console.WriteLine("Este é o funcionamento da pilha: ");

            Stack<int> pilha = new Stack<int>();

            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);

            foreach (int i in pilha)
            {
                Console.WriteLine(i);
            }

            pilha.Pop();
            Console.WriteLine();
            foreach (int i in pilha)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Pilha é LIFO!");

        }

        //Dictionary
        static void Dictionary()
        {
            Console.WriteLine("Este é o funcionamento do dictionary:");
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("Um", 1);
            dictionary.Add("Dois", 1);
            dictionary.Add("Tres", 1);

            foreach(KeyValuePair<string, int> item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Cada item em um Dictionary guarda uma chave única para identificar o valor!");
            Console.WriteLine("Caso seja tentada inclusão um segundo valor para a chave exceção ocorrerá!");
            Console.WriteLine("Você pode alterar o conteúdo de uma chave, nunca duplicar a chave!");

            //Alterar conteúdo de uma chave
            dictionary["Um"] = 5;

            foreach (KeyValuePair<string, int> item in dictionary)
            {
                Console.WriteLine(item);
            }

            //Removendo chave e valor
            dictionary.Remove("Um");


        }
    }
}


