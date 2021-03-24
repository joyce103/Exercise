using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Windows Programming";
            string str2 = "IC238";
            string str3;
            string str4;
            str3 = Console.ReadLine();
            str4 = Console.ReadLine();
            int a = str3.CompareTo(str1);
            int b = str4.CompareTo(str2);
            if (a == 0 && b == 0)
            {
                Console.WriteLine("登入成功");
            }
            else
            {
                Console.WriteLine("登入失敗");
            }
        }
    }
}
