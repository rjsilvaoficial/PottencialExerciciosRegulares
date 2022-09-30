using System;
using System.Collections.Generic;

namespace TiposEspeciaisNoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? desejaEmail = null;


            if(desejaEmail.HasValue && desejaEmail.Value)
            {
                Console.WriteLine("Deseja email");

            }
            else
            {
                Console.WriteLine("Não deseja");
            }

            //Tipos anônimos servem para gerar "tuplas" somente leitura


            var tipoAnonimo = new { Id = 1, Nome = "MeuNome" };

            MeuArray<string> meuArrayGenerico = new MeuArray<string>();

            meuArrayGenerico.AddElemento("PrimeiroObjeto");

            Console.WriteLine($"{meuArrayGenerico[0]}");

            int meuNumero = 3;
            bool par = meuNumero.EhPar();
            string resultado = par ? "é par" : "não é par";
            Console.WriteLine(resultado);

        }
    }

}
