
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習7
{
    class Program
    {
        static void Main(string[] args)
        {
            double W=0;
            double H=0;
            double BMI=0;
            string N;
            bool A = false;
            bool B = false;
            while (A == false)
            {
                try
                {
                    Console.WriteLine("請輸入身高(m)");
                    N = Console.ReadLine();
                    H = double.Parse(N);
                    A = true;
                }
                catch
                {
                    Console.WriteLine("輸入錯誤請重新輸入");
                }
            }
            while (B == false)
            {
                try
                {
                    Console.WriteLine("請輸入體重(kg)");
                    N = Console.ReadLine();
                    W = double.Parse(N);
                    B = true;
                }
                catch
                {
                    Console.WriteLine("輸入錯誤請重新輸入");
                }
            }
            BMI = W / (H * H);
            Console.WriteLine("BMI={0}", BMI);
        }
    }
}
