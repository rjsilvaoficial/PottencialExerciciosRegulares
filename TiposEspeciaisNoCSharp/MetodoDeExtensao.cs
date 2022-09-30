using System;
using System.Collections.Generic;
using System.Text;

namespace TiposEspeciaisNoCSharp
{
    //Precisamos criar uma classe estática
    //Ela servirá para abrigar os métodos de extensão desejados (separação de responsabilidades ver depois)
    public static class MetodoDeExtensao
    {

        //Dentro da classe estática serão criados os métodos de extensão
        //o this antes do tipo no parametro indica qual a classe recebendo o método de extensão
        //Restante é padrão
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }



    }
}
