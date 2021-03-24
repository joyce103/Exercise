using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            string N;
            for(int i = 0; i < 10; i++)
            {
                N = Console.ReadLine();
                A[i] = int.Parse(N);
            }
            int max = A[0];
            int min = A[0];
            int d = 0;
            int d1 = 0;
            for(int j = 0; j < 10; j++)
            {
               if (max < A[j])
               {
                    max = A[j];
                    d = j;
               }
               else if (min > A[j])
               {
                    min = A[j];
                    d1 = j;
               }
                
            }
            Console.WriteLine("最大值為:{0} 位置為:{1} 最小值為:{2} 位置為:{3}", max, d , min , d1);
        }
    }
}
