using System.Reflection;
using System.Runtime.CompilerServices;

namespace _2026_0721
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    //2.1.1
        //    mondai2_1_1();

        //    //2.1.2
        //    mondai2_1_2();

        //    //2.1.3
        //    mondai2_1_3();
        //    //2.1.4
        //    mondai2_1_4();

        //    string s = "11";
        //    int x = 11;
        //    //int→stringにする
        //    s = x.ToString();
        //    //2.2.1
        //    mondai2_2_1();
        //    //2.2.2
        //    mondai2_2_2();
        //    //2.2.3
        //    int c = int.Parse(Console.ReadLine());
        //    int d = int.Parse(Console.ReadLine());
        //    mondai2_2_3(c,d);
        //    //2.2.4
        //    int e = int.Parse(Console.ReadLine());
        //    mondai2_2_4(e);
        //    //ex
        //    int f = Power(3);
        //    Console.WriteLine($"{f}");
        //    //
          
        //    int g = int.Parse(Console.ReadLine());
        //    aaa(g);
        //    Console.WriteLine(g);

        //    //
        //    double h = int.Parse(Console.ReadLine());
        //    double i = CircleArea(h);
        //    Console.WriteLine(i);

        //    //
        //    int j = int.Parse(Console.ReadLine());
        //    Time(j);
        //    Console.WriteLine(j);

        //    //練習
        //    int a = Calc(2, 3);
        //    Console.WriteLine($"{a}");
             
        //    //足し算
        //    int k = Add(4,5);
        //    Console.WriteLine($"{k}");

        //    //偶数判定
        //    int m = int.Parse(Console.ReadLine());
        //    bool l = IsEven(m);
        //    if (l)
        //    {
        //        Console.WriteLine("偶数");
        //    }
        //    else 
        //    {
        //        Console.WriteLine("奇数");
        //    }
            //税込み価格
            int n = int.Parse(Console.ReadLine());
            int o = CalcTax(n);
            Console.WriteLine(o);

            //最大値
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetMax(p, q, r));
                

    }
        static int Calc(int x, int y)
        {
            return (x + y);
        }

        static void mondai2_1_1() 
        {
            Console.WriteLine("Hello, World!");
        }
        static void mondai2_1_2()
        {
            int x = 11;
            Console.WriteLine($"x={x}");

        }
        static void mondai2_1_3()
        {
            int x = 13;
            int y = 17;
            Console.WriteLine($"x={x + y}");
        }
        static void mondai2_1_4()
        {
            Console.WriteLine(13 * 17);
        }

        static void mondai2_2_1() 
        {
            string s = Console.ReadLine();
            Console.WriteLine(s);
        }
        
        static void mondai2_2_2()
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x);
        }
        static void mondai2_2_3(int x, int y)
        {
            Console.WriteLine((x + y) / 2);
        }
        static void mondai2_2_4(int x)
        {
            Console.WriteLine(x * 365);
        }
        static int Power(int x) 
        {
            return (x * x);
        }
        static void aaa(int x)
        {
            if (x >= 10)
            {
                return;
            }
           Console.WriteLine("値が10以下です");
           
        }

        static double CircleArea(double x) 
        {
            return(x * x * 3.14);
        }

        static void Time(int x)
        {
            int hours = x / 3600;
            int minute = (x % 3600) / 60;
            int seconds = x % 60;

            Console.WriteLine($"{hours}時間{minute}分{seconds}秒");
        }

        static int Add(int a, int b) 
        {
            return(a + b);
        }

        static bool IsEven(int number) 
        {
            if (number % 2 == 0)
            {
                return true;
            }
            {
                return false;
            }
        }

        static int CalcTax(int price)
        {
            return(int)Math.Floor(price * 1.1);
        }

        static int GetMax(int a, int b, int c) 
        {
            return Math.Max(a,Math.Max(b, c));
        }

        static int CalcTax(int price, int a)
        {
            return (int)Math.Floor(price * 1.1);
        }

        static int CalcDamage(int attac, int defense)
        {
         return   
        }
    }

}