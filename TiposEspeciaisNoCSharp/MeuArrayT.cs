using System;
using System.Collections.Generic;
using System.Text;

namespace TiposEspeciaisNoCSharp
{
    class MeuArrayT<T>
    {
        //Um membro privado não deve ter um set também privado
        //Há conflito de acessibilidade neste caso
        //O static viabiliza o acesso ao campo privado na instanciação do T[]
        private static int _Tamanho { get; set; }

        public MeuArrayT(int tamanho)
        {
            _Tamanho = tamanho;
        }

        //Qual tipo da prop? É o T[], portanto um array de T
        public T[] VetorInterno = new T[_Tamanho];

        public T this[int index]
        {
            get { return VetorInterno[index]; }
            set { VetorInterno[index] = value; }
        }
    }
}
