using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int prime = 0;
            string N = Console.ReadLine();
            a = int.Parse(N);
            for(int i = 2; i < a; i++)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count = 1;
                    }
                }
                if (count==0)
                {
                    Console.WriteLine(i);
                    prime++;
                }
            }
            Console.WriteLine("質數共有:{0}",prime);
        }
    }
}
