using System;

namespace DesafiosDeCodigoIntermediariosCSharp
{


    #region Aumento de Salario

    //class Program
    //{

    //    static void Main(string[] args)
    //    {

    //        double salario = 0.00;
    //        double reajuste = 0.00;
    //        double novoSalario = 0.00;
    //        double percentual = 0.00;

    //        salario = Convert.ToDouble(Console.ReadLine());

    //        //TODO: Complete os espaços em branco com uma possível solução para o problema:

    //        if ( salario < 0 )
    //        {
    //            return;

    //        }
    //        else if ( salario <= 400.00 )
    //        {
    //            percentual = 15;
    //            reajuste =  salario * percentual / 100;
    //            novoSalario = salario + reajuste;


    //        }
    //        else if (salario <= 800.00)
    //        {
    //            percentual = 12;
    //            reajuste = salario * percentual / 100;
    //            novoSalario = salario + reajuste;

    //        }
    //        else if (salario <= 1200.00)
    //        {
    //            percentual = 10;
    //            reajuste = salario * percentual / 100;
    //            novoSalario = salario + reajuste;

    //        }
    //        else if (salario<= 2000.00)
    //        {
    //            percentual = 7;
    //            reajuste = salario * percentual / 100;
    //            novoSalario = salario + reajuste;

    //        }
    //        else
    //        {
    //            percentual = 4;
    //            reajuste = salario * percentual / 100;
    //            novoSalario = salario + reajuste;

    //        }

    //        Console.WriteLine("Novo salario: {0:0.00}", salario + (percentual * salario / 100));
    //        Console.WriteLine("Reajuste ganho: {0:0.00}", percentual * salario / 100);
    //        Console.WriteLine("Em percentual: {0} %", percentual );

    //    }
    //}
    #endregion

    #region ExercicioUmMaisVezesNumArray

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        int n = int.Parse(Console.ReadLine());

    //        int[] num = new int[n];

    //        // TODO: Crie as outras condições necessárias para a resolução do desafio:
    //        for (int i = 0; i < num.Length; i++)
    //        {
    //            num[i] = int.Parse(Console.ReadLine());
    //        }
    //        Array.Sort(num);
    //        Console.WriteLine(MajorityElement(num));

    //    }
    //    public static int MajorityElement(int[] nums)
    //    {
    //        int major = 0;
    //        int provisoryCount = 0;
    //        int count = 0;
    //        foreach(var item in nums)
    //        {


    //            for(int i = 0; i < nums.Length; i++)
    //            {
    //                if(nums[i] == item)
    //                {
    //                    provisoryCount++;
    //                }
    //            }

    //            if(provisoryCount > count)
    //            {
    //                major = item;
    //                count = provisoryCount;
    //                provisoryCount = 0;
    //            }
    //        }

    //        return major;

    //    }
    //}
    #endregion
}
