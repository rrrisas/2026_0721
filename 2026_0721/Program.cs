using System.Reflection;
using System.Reflection.Metadata.Ecma335;
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
            //int n = int.Parse(Console.ReadLine());
            //int o = CalcTax(n);
            //Console.WriteLine(o);

            //最大値
            //int p = int.Parse(Console.ReadLine());
            //int q = int.Parse(Console.ReadLine());
            //int r = int.Parse(Console.ReadLine());

            //Console.WriteLine(GetMax(p, q, r));

            //2.3.1
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = Hennsuu(a, b);

            //2.3.2

            //int a = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int b = Suuchi(a, c);

            //2.3.3
            //int a = int.Parse(Console.ReadLine());
            //bool b = Seisuu(a);
            //if (b)
            //{
            //    Console.WriteLine("偶数");
            //}
            //else
            //{
            //    Console.WriteLine("奇数");
            //}

            //2.3.4
            // int a = int.Parse(Console.ReadLine());
            //Tennsuu(a);

            //2.3.4
            //int a = int.Parse(Console.ReadLine());
            //Test(a);

            //2.3.4
            //int a = int.Parse(Console.ReadLine());
            //Test2(a);

            //2.4.1
            //Spam();

            //2.4.2
            //Kuku();

            //2.4.3
            //Avg();

            //2.4.4
            // Giants();

            //2.4.5
            //counts();

            //2.5.1
            //Hairertsu();


            //Kuku2();

            //2.5.2

            //Hairertsu2();

            //2.5.3

            //int[,] kuku = new int[9, 9];
            //for (int i = 1; i < 10; i++)
            //{

            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write($"{i}×{j}={i * j}\t");
            //    }
            //    Console.WriteLine();

            //}

            //2.5.4
            //Seisuu2();

            //2.6.1
            //int a = int.Parse(Console.ReadLine());
            //int b = Nijou(a);
            //Console.WriteLine(b);

            //2.6.2
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = Avge(a, b);
            //Console.WriteLine(c);

            //2.6.3
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //int c = Max(a, b, d);
            //Console.WriteLine(c);

            //2.6.4
            //int[] a = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i + 1}回目");
            //    a[i] = int.Parse(Console.ReadLine());
            //}

            //int s = Mma(a);
            //Console.WriteLine($"入力された最大値は{s}です");

            //int[] a = new int[5];

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i + 1}回目");
            //    a[i] = int.Parse(Console.ReadLine());
            //}

            //int b = Mi(a);
            //Console.WriteLine($"入力された最小値は{b}です");

            //int[] a = new int[5];
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i + 1}回目");
            //    a[i] = int.Parse(Console.ReadLine());
            //}

            //int b = Avge(a);
            //Console.WriteLine($"入力された平均値は{b}です");
            //2.7.1.2.3
            //2.7.4
            //Dog dog = new Dog("ポチ", 4, "プードル");
            //dog.ShowProfile();
            //2.7.5
            //2.7.6

            //CoinCase coin = new CoinCase();

            //for (int i = 0; i < 10; i++)
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());
            //    coin.AddCoins(a, b);
            //}

            //Console.WriteLine($"500円：{coin.GetCount(500)} 枚");
            //Console.WriteLine($"100円：{coin.GetCount(100)} 枚");
            //Console.WriteLine($"50円：{coin.GetCount(50)} 枚");
            //Console.WriteLine($"10円：{coin.GetCount(10)} 枚");
            //Console.WriteLine($"5円：{coin.GetCount(5)} 枚");
            //Console.WriteLine($"1円：{coin.GetCount(1)} 枚");

            //Console.WriteLine("----------------------");

            //Console.WriteLine($"500円：{coin.GetAmount(500)} 円");
            //Console.WriteLine($"100円：{coin.GetAmount(100)} 円");
            //Console.WriteLine($"50円：{coin.GetAmount(50)} 円");
            //Console.WriteLine($"10円：{coin.GetAmount(10)} 円");
            //Console.WriteLine($"5円：{coin.GetAmount(5)} 円");
            //Console.WriteLine($"1円：{coin.GetAmount(1)} 円");

            //Console.WriteLine("----------------------");
            //Console.WriteLine($"総枚数：{coin.GetCount()}枚");
            //Console.WriteLine("----------------------");
            //Console.WriteLine($"総額：{coin.GetAmount()} 円");

            //2.7.7
            //Cat cat = new Cat("Mimi", 2);
            //cat.ShowProfile();
            //cat.Sleep();


            //2.7.9
            //Cat cat = new Cat("猫", 1);
            //cat.ShowProfile();
            //cat.Sleep();
            //Console.WriteLine("-------------------------------");
            //Dog2 dog = new Dog2("犬", 3);
            //dog.ShowProfile();
            //dog.Run();

            //2.7.10
            //Cat cat = new Cat("猫", 1);
            //cat.ShowProfile();
            //cat.Speak();
            //Console.WriteLine("--------------------------------");
            //Dog2 dog = new Dog2("犬", 1);
            //dog.ShowProfile();
            //dog.Speak();

            //2.7.11]
            //Animal[] animals = new Animal[4];
            //animals[0] = new Cat("ネコ", 1);
            //animals[1] = new Dog2("アトム", 3);
            //animals[2] = new Cat("クロ", 9);
            //animals[3] = new Dog2("クー", 5);

            //foreach (Animal a in animals)
            //{
            //    a.ShowProfile();
            //    a.Speak();
            //}



            //2.8.1

            //2.8.2
            //Animal dog = new Dog2("ポチ", 3);
            //Animal cat = new Cat("ミケ", 2);

            //Console.WriteLine(dog);
            //Console.WriteLine(cat);

            //2.8.3

            //List<Animal> animals = new List<Animal>();

            //animals.Add(new Dog2("ポチ", 4));
            //animals.Add(new Dog2("アトム",5));
            //animals.Add(new Cat("たま", 6));
            //animals.Add(new Cat("クロ",10));

            //foreach(Animal a in animals)
            //{
            //    Console.WriteLine(a);
            //    a.Speak();
            //}

            //2.8.4

            //List<Animal> animals = new List<Animal>
            //{
            //    new Dog2("ポチ", 4),
            //    new Cat("たま", 1),
            //    new Bird("ぴー", 7),
            //    new Dog2("アトム", 12),
            //    new Cat("ショーン", 5),
            //    new Bird("イチロー", 9),
            //};

            //foreach(Animal ani in animals)
            //{
            //    Console.WriteLine(ani);
            //    ani.Speak();

            //    if (ani is Bird b)
            //    {
            //        b.Fly();
            //    }

            //}

            //2.8.5

            //Animal dog = new Dog2("アトム", 12);
            //dog.Walk();
            //dog.Walk(3);

            //2.8.6
            //List<Animal> animals = new List<Animal>
            //{
            //    new Dog2("ポチ", 4),
            //    new Cat("たま", 1),
            //    new Bird("ぴー", 7),
            //    new Dog2("アトム", 12),
            //    new Cat("ショーン", 5),
            //    new Bird("イチロー", 9),
            //};
            //foreach (Animal a in animals)
            //{
            //    Console.WriteLine($"{a.Species}・{a.Name}・{a.Age}");
            //}

            //2.8.7
            //Animal cat = new Cat("ミケ", 2);
            //cat.ShowKind();

            //Cat cat1 = new Cat("ミケ", 2);
            //cat1.ShowKind();

            //2.8.8
            // ・キャスト失敗時は InvalidCastException が発生してプログラムが落ちる（危険）
            // ・成功時は Run() が呼ばれる
            //Animal a = new Dog2("アトム", 12);
            //((Dog2)a).Run();

            // ・キャスト失敗時は null が返る（例外は出ない）
            // ・nullチェックすれば安全に Run() を呼べる
            //Animal a = new Dog2("アトム", 12);
            //(a as Dog2).Run();

            // ・キャスト成功時だけ d.Run() が呼ばれる
            // ・失敗時は何もしない（例外なし）
            // ・null を扱わないので as より安全で読みやすい
            //Animal a = new Dog2("アトム", 12);
            //if (a is Dog d2)
            //{
            //    d2.Run();
            //}

            //2.8.9
            //List<Animal> animals = new List<Animal>
            //{
            //    new Dog2("ポチ", 4),
            //    new Cat("たま", 1),
            //    new Bird("ぴー", 7),
            //    new Dog2("アトム", 12),
            //    new Cat("ショーン", 5),
            //    new Bird("イチロー", 9),
            //};

            //foreach(Animal a in animals)
            //{
            //    a.DoDaily();
            //}

            //2.8.10

            //List<IPlayable> animal = new List<IPlayable>
            //{
            //    new Dog2("ポチ", 4),
            //    new Cat("たま", 1),
            //    new Bird("ぴー", 7),
            //    new Dog2("アトム", 12),
            //    new Cat("ショーン", 5),
            //    new Bird("イチロー", 9),
            //};

            //foreach (IPlayable a in animal)
            //{
            //    //if(a is IPlayable b)
            //   // {
            //        a.Play();
            //    //
            //}

            //List<Animal> animals = new List<Animal>
            //{
            //    new Dog2("ポチ", 4),
            //    new Cat("たま", 1),
            //    new Bird("ぴー", 7),
            //    new Dog2("アトム", 12),
            //    new Cat("ショーン", 5),
            //    new Bird("イチロー", 9),
            //};

            //foreach (Animal a in animals)
            //{
            //    //if(a is IPlayable b)
            //    // {
            //    a.Speak();
            //    //
            //}

            //2.8.11
            Console.WriteLine("登録する頭数を入力してください");
            int a = int.Parse(Console.ReadLine());

            List<Animal> dog = new List<Animal>();
            List<Animal> cat = new List<Animal>();
            List<Animal> bird = new List<Animal>();

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("種類、名称、年齢を入力してください");
                string b = Console.ReadLine();

                string[] c = b.Split();

                string type = c[0];
                string name = c[1];
                int age = int.Parse(c[2]);

                if(type == "Dog")
                {
                    dog.Add();
                }

            }


            //Console.WriteLine("お好きな寿司を選んでください");
            //Console.WriteLine("1:まぐろ 2:えび 3:こはだ 4:あなご 5:いくら");

            //int a = int.Parse(Console.ReadLine());
            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("1:まぐろ→ 今日のあなたはリーダー運が好調です。積極的に行動しましょう！");
            //        break;

            //    case 2:
            //        Console.WriteLine("2:えび→ 周囲との協力が運気アップの鍵です。困ったときは相談してみましょう！");
            //        break;

            //    case 3:
            //        Console.WriteLine("3:こはだ→ 新しい知識を身につけるのに最適な一日です。");
            //        break;

            //    case 4:
            //        Console.WriteLine("4:あなご→ 焦らずゆっくり進めることで良い結果につながります。");
            //        break;

            //    case 5:
            //        Console.WriteLine("5:いくら→ 思わぬ幸運が舞い込むかもしれません。チャンスを逃さないようにしましょう！");
            //        break;
            //}
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
                return (x * x * 3.14);
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
                return (a + b);
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
                return (int)Math.Floor(price * 1.1);
            }

            static int GetMax(int a, int b, int c)
            {
                return Math.Max(a, Math.Max(b, c));
            }

            //static int CalcTax(int price, int a)
           // {
               // return (int)Math.Floor(price * 1.1);
           // }

            //static int CalcDamage(int attac, int defense)
            //{
            //return   

            static int Suuchi(int x, int y)
            {
                if (x > y)
                {
                    Console.WriteLine("xはyより大きい");
                    return 1;
                }
                else if (x < y)
                {
                    Console.WriteLine("xはyより小さい");
                    return -1;
                }
                Console.WriteLine("xとyは等しい");
                return 0;
            }

            static int Hennsuu(int x, int y)
            {
                if (x > y)
                {
                    Console.WriteLine("xはyより大きい");
                    return 1;
                }
                return 0;
            }

            static bool Seisuu(int x)
            {
                if (x % 2 == 0)
                {
                    return true;
                }
                return false;
            }

            static void Tennsuu(int x)
            {
                if (x >= 60)
                {
                    Console.WriteLine("合格");
                    return;
                }
                Console.WriteLine("不合格");
            }

            static void Test(int x)
            {
                if (x >= 80)
                {
                    Console.WriteLine("合格");
                    return;
                }
                else if (x >= 60)
                {
                    Console.WriteLine("不合格");
                    return;
                }
                Console.WriteLine("残念でした");
            }

            static void Test2(int x)
            {
                if (x >= 80)
                {
                    Console.WriteLine("優");
                    return;
                }
                else if (x >= 70)
                {
                    Console.WriteLine("良");
                    return;
                }
                else if (x >= 60)
                {
                    Console.WriteLine("可");
                    return;
                }
                Console.WriteLine("不可");
            }

            static void Spam()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("SPAM");
                }
            }

            static void Kuku()
            {
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine(3 * i);
                }
            }

            static void Avg()
            {
                double a = 0;
                for (double i = 0; i < 10; i++)
                {
                    a += double.Parse(Console.ReadLine());
                }
                Console.WriteLine(Math.Truncate(a / 10));
            }

            static void Giants()
            {
                int a = 0;
                int b = 0;
                int c = 0;
                int d = 0;

                for (int i = 1; i < 10; i++)
                {

                    Console.WriteLine($"{i}表、巨人の得点は？");
                    a = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{i}裏、阪神の得点は？");
                    b = int.Parse(Console.ReadLine());

                    c += a;
                    d += b;
                }

                Console.WriteLine($"巨人{c}点 , 阪神：{d}点");

                if (c > d)
                {
                    Console.WriteLine("巨人の勝ち♪");
                    return;
                }
                else if (c < d)
                {
                    Console.WriteLine("阪神の勝ち");
                    return;
                }
                Console.WriteLine("引き分け");
            }
            static void counts()
            {
                int c = 0;
                int d = 0;

                for (int i = 0; i < 99; i++)
                {
                    Console.WriteLine("ストライク=1, ボール=2，ファウル=3 ?");
                    int a = int.Parse(Console.ReadLine());

                    if (a == 1)
                    {
                        c++;

                        if (c == 3)
                        {
                            break;
                        }
                    }
                    else if (a == 2)
                    {
                        d++;

                        if (d == 4)
                        {
                            break;
                        }
                    }
                    else if (a == 3)
                    {
                        if (c <= 1)
                        {
                            c++;
                        }
                    }

                }

                Console.WriteLine($"{d}ボール{c}ストライク");
            }

            static void Hairertsu()
            {
                int[] a = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(a[i] * 2);
                }
            }

            static void Hairertsu2()
            {
                int[] a = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("偶数 : ");
                for (int i = 0; i < 10; i++)
                {
                    if (a[i] % 2 == 0)
                    {
                        Console.Write($"{a[i]} ");
                    }
                }

                Console.WriteLine();

                Console.Write("奇数 : ");
                for (int i = 0; i < 10; i++)
                {
                    if (a[i] % 2 != 0)
                    {
                        Console.Write($"{a[i]} ");
                    }
                }
            }

        static void Seisuu2()
        {
            int[] a = new int[10];

            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 9; i++)
            {
                if (a[i] < a[i + 1])
                {
                    int b = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = b;
                }
                Console.WriteLine(i);
            }
        }
        static int Nijou(int x)
        {
            return x * x;
        }

        static int Avge(int x, int y)
        {
            return(x + y) / 2;
        }

        static int Max(int x, int y, int z)
        {
            return Math.Max(x,Math.Max(y, z));
        }

        static int Mma(int[] a)
        {
            int k = 0;
           for(int i = 0; i < 4; i++)
            {
                if (a[i] > a[i + 1])
                {
                    k = a[i];
                }
            }
           if(k < a[4])
            {
                k = a[4];
            }
            return k;
        }

        static int Mi(int[] a)
        {
            int min = 0;
            for(int i = 0; i < 5; i++)
            {
                if (a[min] > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }

        static int Avge(int[]a)
        {
            int b = 0;
            for (int i = 0; i< 5; i++)
            {
                b += a[i];
            }
            return b / 5;
        }

    }
}


   