
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            int a = str.Length;
            for(int i=a-1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            //Console.Write(a);
        }
    }
}
