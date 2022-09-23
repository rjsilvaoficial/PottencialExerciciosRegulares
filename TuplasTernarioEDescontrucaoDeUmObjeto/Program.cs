using System;
using System.Linq;

namespace TuplasTernarioEDescontrucaoDeUmObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int Id, string Nome) tupla = (1, "Jose");
            Console.WriteLine($" O id da tupla é {tupla.Id} e o Nome é :{tupla.Nome}");

            LeituraArquivo myReader = new LeituraArquivo();

            (bool sucesso, string[] linhas,int quantidadeLinhas ) tst = myReader.LerArquivo(@"Arquivos/File1.txt");



            Console.WriteLine($"Sucesso na leitura de arquivo é : {tst.sucesso} " +
                $"e a contagem de linhas é: {tst.quantidadeLinhas}");

            if(tst.linhas.Count() > 0)
            {
                foreach (var item in tst.linhas)
                {
                    Console.WriteLine(item);
                }
            }

            



        }
    }
}
