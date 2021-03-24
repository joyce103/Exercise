using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習
{
    class Program
    {
        static bool Check(byte[] array, int count)  //檢查是否有相同的數字
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i] == array[count]) //有數字相同，回傳true
                    return true;
            }
            return false; //沒有數字相同，回傳false
        }

        static void Main(string[] args)
        {
            //bool A = false;
            //bool B = false;
            //bool C = false;
            //double a, b, c;
            //string N;
            //while (A == false)
            //{
            //    try
            //    {
            //        Console.WriteLine("請輸入一次");
            //        N = Console.ReadLine();
            //        a = double.Parse(N);
            //        A = true;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("請重新輸入");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("加油");
            //    }
            //}
            //while (B == false)
            //{
            //    try
            //    {
            //        Console.WriteLine("請輸入二次");
            //        N = Console.ReadLine();
            //        b = double.Parse(N);
            //        B = true;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("請重新輸入");
            //    }
            //}
            //while (C == false)
            //{
            //    try
            //    {
            //        Console.WriteLine("請輸入常數");
            //        N = Console.ReadLine();
            //        c = double.Parse(N);
            //        C = true;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("請重新輸入");
            //    }
            //}
            //string InputData;
            //try
            //{
            //    Console.WriteLine("請輸入三角形第一邊的邊長：");

            //    InputData = Console.ReadLine();
            //    a = double.Parse(InputData);
            //    if (a < 0) throw new Exception("三角形第一邊邊長為負"); //若輸入負數則丟出錯誤訊息
            //    Console.WriteLine("請輸入三角形第二邊的邊長：");
            //    InputData = Console.ReadLine();
            //    b = double.Parse(InputData);
            //    if (b < 0) throw new Exception("三角形第二邊邊長為負");
            //    Console.WriteLine("請輸入三角形第三邊的邊長：");
            //    InputData = Console.ReadLine();
            //    c = double.Parse(InputData);
            //    if (c < 0) throw new Exception("三角形第三邊邊長為負");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);  //輸出後結束程式return
            //    return;
            //}
            //Random rn = new Random();  //宣告並建立亂數產生器物件實體
            //                           //Random rn = new Random(1); //宣告並建立亂數產生器物件實體
            //                           // 並以數值1做為其亂數種子
            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(rn.Next().ToString()); //產生一個介於0到
            //    //int.MaxValue之間的亂數
            //    //Console.WriteLine(rn.Next(49).ToString()); //產生一個介於0到48之間的亂數
            //    Console.WriteLine(rn.Next(1, 50).ToString()); //產生一個介於1到49之間的亂數
            //}
            byte[] lot = new byte[7]; //宣告一個7個數字的byte陣列
            Random rn = new Random();

            int i = 0;
            while (i < 7)
            {
                lot[i] = (byte)(rn.Next(1, 50)); //產生一個介於1-49間的數字
                if (!Check(lot, i))  //檢查是否有相同數字，若有則重新產生一個
                {
                    i++;
                }
            }
            foreach (byte x in lot)  //印出樂透號碼
            {
                Console.Write("{0} ", x);
            }


        }
    }
}
