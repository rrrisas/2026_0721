
    using System.ComponentModel;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace _0824
    {
        public class Program
        {
            static void Main(string[] args)
            {
                //2.1
                //Console.WriteLine("Hello, World!");
                //2.1.2
                //int x = 11;
                //Console.WriteLine("x = " + x);
                //2.1.3
                //int x = 13 + 17;
                //Console.WriteLine(x);
                //2.1.4
                //Console.WriteLine(13 * 17);
                //2.2.1
                //string s = Console.ReadLine();
                //Console.WriteLine(s);
                //2.2.2
                //int x = int.Parse(Console.ReadLine());
                //Console.WriteLine(x);
                //2.2.3
                //int a = int.Parse(Console.ReadLine());
                //int b = int.Parse(Console.ReadLine());
                //Console.WriteLine((a + b)/2);
                //2.2.4
                //Console.WriteLine("現在の年齢を入力してください");
                //int a = int.Parse(Console.ReadLine());
                //Console.WriteLine(a * 365);
                //2.3.1
                //int a = int.Parse(Console.ReadLine());
                //int b = int.Parse(Console.ReadLine());
                //int c = M2_3_1(a,b);
                //2.3.2
                //int a = int.Parse(Console.ReadLine());
                //int b = int.Parse(Console.ReadLine());
                //int c = M2_3_2(a,b);
                //2.3.3
                //M2_3_3();
                //2.3.4
                //M2_3_4();
                //2.3.5
                //int a = int.Parse(Console.ReadLine());
                //int b = int.Parse(Console.ReadLine());
                //int c = M2_3_5(a,b);
                //2.3.6
                //while(true){ 
                //Console.WriteLine("1:まぐろ");
                //Console.WriteLine("2:えび");
                //Console.WriteLine("3:タコ");
                //Console.WriteLine("4:いか");
                //Console.WriteLine("5:こはだ");
                //    Console.WriteLine();
                //    Console.WriteLine("好きな寿司の番号を入力してください");
                //    Console.WriteLine();
                //    int a = int.Parse(Console.ReadLine());

                //    switch (a)
                //    {
                //        case 1:
                //            Console.WriteLine();
                //            Console.WriteLine("マグロ<゜)))彡");
                //            Console.WriteLine();

                //            break;
                //        case 2:
                //            Console.WriteLine();
                //            Console.WriteLine("エビ🦐");
                //                Console.WriteLine();
                //            break;
                //        case 3:
                //            Console.WriteLine();
                //            Console.WriteLine("タコＣ:。ミ");
                //            Console.WriteLine();
                //            break;
                //        case 4:
                //            Console.WriteLine();
                //            Console.WriteLine("イカ🦑");
                //            Console.WriteLine();
                //            break;
                //        case 5:
                //            Console.WriteLine();
                //            Console.WriteLine("イカダ🐡");
                //            Console.WriteLine();
                //            break;
                //    }
                //}
                //2_4_1
                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine("SPAM");
                //}
                //2_4_2
                //for(int i = 1; i < 10; i++)
                //{
                //    Console.WriteLine($"{i}の段：{3 * i}");
                //}
                //2_4_3
                //int c = 0;
                //for(int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine("数字を入力してください");
                //    int a = int.Parse(Console.ReadLine());
                //    c += a;
                //}
                //Console.WriteLine(c / 10);
                //2_4_4
                //M2_4_4();
                //2_4_5
                //M2_4_5();
                //2.5.1
                //M2_5_1();
                //2.5.2
                //M2_5_2();
                //2.5.3
                //int[,] kuku = new int[9, 9];

                //for (int i = 0; i < 9; i++)
                //{
                //    for (int j = 0; j < 9; j++)
                //    {
                //        kuku[i, j] = (i + 1) * (j + 1);
                //        Console.Write("{0,2} ", kuku[i, j]);
                //    }
                //    Console.WriteLine();
                //}
                //2.5.4
                //int[] a = new int[10];
                //for(int i = 0; i <10; i++)
                //{
                //    Console.WriteLine("整数を入力してください");
                //    int b = int.Parse(Console.ReadLine());
                //    a[i] = b; 
                //}
                //a.Sort();
                //foreach(int s in a)
                //{
                //    Console.WriteLine(s);
                //}
                //2.6.1
                //int a = int.Parse(Console.ReadLine());
                //int b = M2_6_1(a);
                //Console.WriteLine(b);
                //2.6.2
                //Console.Write("数字を入力してください");
                //int a = int.Parse(Console.ReadLine());
                //Console.Write("数字を入力してください");
                //int b = int.Parse(Console.ReadLine());
                //int c = M2_6_2(a, b);
                //Console.WriteLine(c);
                //2.6.3
                //Console.Write("数字を入力してください");
                //int a = int.Parse(Console.ReadLine());
                //Console.Write("数字を入力してください");
                //int b = int.Parse(Console.ReadLine());
                //int c = M2_6_3(a,b);
                //Console.WriteLine(c);
                //2.6.4
                M2_6_4();
            }
            public static void M2_6_4()
            {
                int c = 0;
                int[] b = new int[5];
                int d = 0;
                int min = int.MaxValue;

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("数字を入力してください");
                    int a = int.Parse(Console.ReadLine());
                    c += a;
                    if (d < a)
                    {
                        d = a;
                    }
                    else if (a < min)
                    {
                        min = a;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"最大値:{d}");
                Console.WriteLine();
                Console.WriteLine($"最小値:{min}");
                Console.WriteLine();
                Console.WriteLine($"平均値:{c / 5}");
            }

            public static int M2_6_3(int x, int y)
            {
                return (x + y) / 2;
            }
            public static int M2_6_2(int x, int y)
            {
                if (x > y)
                {
                    return x;
                }
                else if (y > x)
                {
                    return y;
                }
                return 0;
            }
            public static int M2_6_1(int x)
            {
                return x * x;
            }
            public static int M2_3_1(int x, int y)
            {
                if (x > y)
                {
                    Console.WriteLine("xはｙより大きい");
                    return 1;
                }

                return 0;

            }

            public static int M2_3_2(int x, int y)
            {
                if (x > y)
                {
                    Console.WriteLine("ｘはｙより大きい");
                    return 1;
                }
                else if (x < y)
                {
                    Console.WriteLine("yはxより大きい");
                    return 1;
                }
                else
                {
                    Console.WriteLine("ｘとｙは等しい");
                    return 1;
                }
                return 0;
            }

            public static void M2_3_3()
            {
                int c = int.Parse(Console.ReadLine());
                if (c % 2 == 0)
                {
                    Console.WriteLine("偶数です");
                }
                else
                {
                    Console.WriteLine("奇数です");
                }
            }
            public static void M2_3_4()
            {
                int x = int.Parse(Console.ReadLine());
                if (80 <= x)
                {
                    Console.WriteLine("たいへんよくできました");
                    Console.WriteLine("優");
                }
                if (80 >= x && 60 <= x)
                {
                    Console.WriteLine("よくできました");
                }
                if (80 >= x && 70 <= x)
                {
                    Console.WriteLine("良");
                }
                if (70 >= x && 60 <= x)
                {
                    Console.WriteLine("可");
                }
                else if (60 <= x)
                {
                    Console.WriteLine("合格");
                }
                else if (60 >= x)
                {
                    Console.WriteLine("不合格");
                    Console.WriteLine("残念でした");
                    Console.WriteLine("不可");
                }
            }
            public static int M2_3_5(int x, int y)
            {
                if (x < y && x % 2 == 0 && y % 2 == 0)
                {
                    Console.WriteLine("xはyより小さく、かつ、xとyはともに偶数である");
                    return 1;
                }
                if (x == y && x < 0 && y < 0)
                {
                    Console.WriteLine("xとyは等しく、かつ、負の数である");
                    return 1;
                }
                if (x < y || x % 2 == 0)
                {
                    Console.WriteLine("xはyより小さい、または、xは偶数である");
                    return 1;
                }
                if (x <= 10 && x >= 100 && y >= 10 && y <= 100)
                {
                    Console.WriteLine("xは10以下または100以上で、かつ、yは10以上かつ100以下である");
                    return 1;
                }
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("xもyも負の数である、ではない");
                    return 1;
                }
                return 0;
            }

            public static void M2_4_4()
            {
                int k = 0;
                int h = 0;

                for (int i = 1; i < 10; i++)
                {
                    Console.Write($"{i}回表、巨人の得点を入力してください：");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write($"{i}回裏、阪神の得点を入力してください：");
                    int c = int.Parse(Console.ReadLine());
                    k += b;
                    h += c;
                }
                Console.WriteLine();
                Console.WriteLine($"巨人；{k}点、阪神：{h}点");
                Console.WriteLine();
                if (k > h)
                {
                    Console.WriteLine("巨人の勝ち");
                }
                else
                {
                    Console.WriteLine("阪神の勝ち");
                }
            }

            public static void M2_4_5()
            {
                int b = 0;
                int c = 0;
                for (int i = 0; i < 99; i++)
                {
                    Console.WriteLine("ストライクの場合は１、ボールの場合は２を入力してください、ファウルの場合は3を入力してください");
                    int a = int.Parse(Console.ReadLine());
                    if (a == 1)
                    {
                        b += a;
                        if (b == 3)
                        {
                            break;
                        }
                    }
                    else if (a == 3 && b < 2)
                    {
                        b += 1;
                    }
                    else if (a == 2)
                    {
                        c += 1;
                        if (c == 4)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine($"{c}ボール、{b}ストライク");
            }
            public static void M2_5_1()
            {
                int[] a = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("数字を入力してください");
                    int b = int.Parse(Console.ReadLine());
                    a[i] = b;
                }
                foreach (int c in a)
                {
                    Console.WriteLine(2 * c);
                }
            }
            public static void M2_5_2()
            {
                int[] d = new int[10];
                int[] e = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("数字を入力してください");
                    int a = int.Parse(Console.ReadLine());
                    d[i] = a;
                }
                Console.WriteLine();
                Console.WriteLine("偶数");
                Console.WriteLine();
                foreach (int f in d)
                {
                    if (f % 2 == 0)
                    {
                        Console.WriteLine(f);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("奇数");
                Console.WriteLine();
                foreach (int f in d)
                {
                    if (f % 2 == 1)
                    {
                        Console.WriteLine(f);
                    }
                }

            }
        }
    }


