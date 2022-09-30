using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDeCodigoIntermediario
{
    public static class ElementoMajoritário
    {

        public static void ExecutarCodigo()
        {

            //Recebendo o valor do tamanho do array que será utilizado na verificação
            int n = int.Parse(Console.ReadLine());

            //Redundante, mas para reforçar: o array passará a ter o tamanho de n
            int[] num = new int[n];

            //para um i igual à 0, enquanto o i tiver um valor menor que num.Length, o i será incrementado em 1
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(num);
            Console.WriteLine(MajorityElement(num));

        }
        private static int MajorityElement(int[] nums)
        {

            int major = 0;

            int provisoryCount = 0;
            int count = 0;

            foreach (var item in nums)
            {

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == item)
                    {
                        provisoryCount++;
                    }
                }

                
                if (provisoryCount > count)
                {
                    major = item;
                    count = provisoryCount;
                    provisoryCount = 0;
                }
            }

            return major;

        }
    }
}

