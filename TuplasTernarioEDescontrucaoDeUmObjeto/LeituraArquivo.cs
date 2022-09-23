using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TuplasTernarioEDescontrucaoDeUmObjeto
{
    internal class LeituraArquivo
    {
        public (bool sucesso, string[] linhas, int quantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                //O ReadAllLines já divide o arquivo linha a linha e atribui ao array.
                string[] Linhas = File.ReadAllLines(caminho);
                return (true, Linhas, Linhas.Count());

            }
            catch (Exception ex)
            {
                return (false, new string[0], 0);
            }

        }
    }
}
