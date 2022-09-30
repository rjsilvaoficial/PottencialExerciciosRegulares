using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NugetSerializarEAtributosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Venda() { Id = 1, NomeProduto = "Teclado", Preco = 50.00M };
            var p2 = new Venda() { Id = 2, NomeProduto = "Mouse", Preco = 30.00M };

            List<Venda> pessoas = new List<Venda>();

            pessoas.Add(p1);
            pessoas.Add(p2);

            string serializado = JsonConvert.SerializeObject(pessoas, Formatting.Indented);

            File.WriteAllText("Arquivos/vendas.json", serializado);

            Console.WriteLine(serializado);

            string desserializado = File.ReadAllText("Arquivos/vendas.json");

            var listaDesserializada = JsonConvert.DeserializeObject<List<Venda>>(desserializado);

            var listaAnonima = listaDesserializada.Select(item => new { item.Id, item.NomeProduto });

            foreach(var item in listaAnonima)
            {
                Console.WriteLine(item);
            }

        }
    }
}
