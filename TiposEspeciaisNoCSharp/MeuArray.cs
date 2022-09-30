using System;
using System.Collections.Generic;
using System.Text;

namespace TiposEspeciaisNoCSharp
{
    class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] arrayGenerico = new T[capacidade];


        public void AddElemento(T elemento)
        {
            if(contador + 1 < 11)
            {
                arrayGenerico[contador] = elemento;
            }
            contador++;

        }

        //T é o tipo a ser retornado (mesmo da classe onde a propriedade está)
        //this informa que o próprio tipo será usado aqui
        //Neste caso a instância de MeuArray<T>
        //Ex: meuArray[0] onde meuArray é o this e 0 o int index
        public T this[int index]
        {
            get { return arrayGenerico[index]; }
            set { arrayGenerico[index] = value; }
        }


    }
}
