using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NugetSerializarEAtributosCSharp
{
    class Venda
    {
        public Venda()
        {

        }
        public Venda(int id, string produto, decimal preco)
        {
            Id = id;
            NomeProduto = produto;
            Preco = preco;
        }

        public int Id { get; set; }

        [JsonProperty("Nome_Produto")]
        public string NomeProduto { get; set; }

        public decimal Preco { get; set; }
    }
}

