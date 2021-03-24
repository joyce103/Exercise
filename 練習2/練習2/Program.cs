using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[3];
            string N;
            for(int i = 0; i < 3; i++)
            {
                N = Console.ReadLine();
                A[i] = double.Parse(N);
            }
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (A[i] < A[j])
                    {
                        double B;
                        B = A[i];
                        A[i] = A[j];
                        A[j] = B
;                    }
                }
            }
            for(int i = 0; i < 3; i++)
            {
                Console.Write("{0} ",A[i]);
            }
        }
    }
}
