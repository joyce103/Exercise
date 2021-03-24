using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string N;
            N = Console.ReadLine();
            a = int.Parse(N);
            int sum = 0;
            for(int i = 1; i <= a; i++)
            {
                sum += i * i;
            }
            Console.WriteLine("結果為:{0}",sum);
        }
    }
}
