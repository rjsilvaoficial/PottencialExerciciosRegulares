using System;
using System.Collections.Generic;
using System.Text;

namespace TuplasTernarioEDescontrucaoDeUmObjeto
{
    public class Pessoa
    {


        public Pessoa()
        {

        }
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        //Digere um objeto traduzindo-o numa tupla
        public void Deconstruct(out int id, out string nome)
        {
            id = Id;
            nome = Nome;
        }        
        

    }
}
