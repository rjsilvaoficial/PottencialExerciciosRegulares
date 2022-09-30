using System;
using System.Collections.Generic;
using System.Text;

namespace TiposEspeciaisNoCSharp
{
    class MeuArray2<T> // aqui digo que a classe será de um tipo T
    {
        //private pq não quero ninguém mexendo aqui toda hora
        //O static pq do contrário não consigo acessar a prop para construir o VetorInterno
        private static int _TamanhoDoVetorInterno { get; set; }
        public MeuArray2(int tamanhoDoVetorInterno)
        {
            _TamanhoDoVetorInterno = tamanhoDoVetorInterno;
        }

        public T[] VetorInterno = new T[_TamanhoDoVetorInterno];

        //Essa é uma sintaxe um pouco incomum para nós até então
        //Mas trata-se de uma propriedade
        //this é a minhaInstancia
        //[int i] é o índice que busco trabalhar
        //Nota mental: pq diabos o carinha da ms não configurou então NomeDaClasse<T> e incluiu o [] para tipos genéricos vetor?
        //Funciona, mas é uma tremenda escrita incongruente, padronização meu povo? já viram?
        public T this[int i]
        {
            get { return VetorInterno[i]; }
            set { VetorInterno[i] = value; }
        }


    }
}
