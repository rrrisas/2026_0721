using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.IO;
using System.Reflection.Metadata;
using System.IO.Enumeration;
using System.Text;
using System.Linq.Expressions;

namespace _2026_0721
{
    internal class Program
    {
        static async Task Main(string[] args)
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
            //Console.Write("登録する動物の数を入力: ");
            //int N = int.Parse(Console.ReadLine());

            //List<Animal> animals = new List<Animal>();
            //Dictionary<string, int> counts = new Dictionary<string, int>();

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"{i + 1} 行目（例: Dog ポチ 3）: ");
            //    string a = Console.ReadLine();

            //    string[] parts = a.Split(' ');
            //    string type = parts[0];
            //    string name = parts[1];
            //    int age = int.Parse(parts[2]);

            //    Animal b = null;

            //    if (type == "Dog")
            //        b = new Dog2(name, age);
            //    else if (type == "Cat")
            //        b = new Cat(name, age);
            //    else if (type == "Bird")
            //        b = new Bird(name, age);
            //    else
            //    {
            //        Console.WriteLine("不明な種類です。");
            //        continue;
            //    }

            //    animals.Add(b);

            //    if (!counts.ContainsKey(type))
            //        counts[type] = 0;

            //    counts[type]++;
            //}

            //Console.WriteLine("プロフィールと鳴き声");
            //foreach (Animal a in animals)
            //{
            //    a.Speak();
            //    a.ShowProfile();

            //    if (a is IPlayable p)
            //    {
            //        p.Play();
            //    }

            //    Console.WriteLine();
            //}

            //Console.WriteLine("種類別頭数");
            //foreach (var h in counts)
            //{
            //    Console.WriteLine($"{h.Key}: {h.Value} 匹");
            //}

            //3.1.1
            //Student student = new Student();
            //student.Name = "長嶋";
            //student.Age = 15;
            //student.ShowProfile();

            //3.2.1

            //Season season = Season.Summer;
            //Console.WriteLine(season);

            //3.2.2
            //Console.WriteLine("0－3までの数字を入力してください");
            //int a = int.Parse(Console.ReadLine());

            //Season s = (Season)a;

            //Console.WriteLine(s);

            //3.3.1

            //Point p = new Point();
            //p.x = 5;
            //p.y = 10;
            //p.ShowPoint();

            //M2_4_5();

            //3.4.1

            //Counter a = new Counter();
            //Counter b = new Counter();
            //Counter c = new Counter();

            //Console.WriteLine(Counter.GetCount());

            //3.5.1

            //List<int> ani = new List<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("数字を入力してください");
            //    int a = int.Parse(Console.ReadLine());
            //    ani.Add(a);
            //}

            //Console.WriteLine("    ");

            //foreach(int a in ani)
            //{
            //    Console.WriteLine(a);
            //}

            //3.5.2
            //List<string> name = new List<string>();

            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("名前を入力してください");
            //    string a = Console.ReadLine();
            //    name.Add(a);
            //}
            //Console.WriteLine("   ");
            //foreach(string a in name)
            //{
            //    Console.WriteLine(a);
            //}

            //3.6.1
            //Dictionary<string, int> a = new Dictionary<string, int>();

            //a.Add("a",4);
            //a.Add("b", 7);
            //a.Add("c", 5);

            //foreach(var o in a)
            //{
            //    Console.WriteLine($"{o.Key}: {o.Value} ");
            //}

            //3.7.1

            //School.Teacher t = new School.Teacher();
            //t.name = "田中先生";

            //School.Student s = new School.Student();
            //s.name = "里咲";

            //t.ShowProfile();
            //s.ShowProfile();

            //4.1.1
            //Console.WriteLine("整数を入力してください");
            //try
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"入力された整数は {n} です");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("整数を入力してください");
            //}

            //4.2.1

            //try
            //{
            //    StreamReader sr = new StreamReader("test.txt");
            //    Console.WriteLine("ファイルを開きました");
            //}
            //catch(FileNotFoundException)
            //{
            //    Console.WriteLine("ファイルが存在しません");
            //}
            //finally
            //{
            //    Console.WriteLine("処理を終了します");
            //}

            ////4.3.1

            //try
            //{
            //    int a = 2;
            //    int b = 0;
            //    int c = a / b;
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("0で割ることはできません");
            //}
            //try
            //{
            //    int[] nums = { 1, 2, 3 };
            //    Console.WriteLine(nums[5]);
            //}
            //catch(IndexOutOfRangeException)
            //{
            //    Console.WriteLine("配列の範囲外です");
            //}

            //4.4.1
            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    CheckAge(a);
            //}
            //catch(ArgumentOutOfRangeException)
            //{
            //    Console.WriteLine("入力が不正です");
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("整数を入力してください");
            //}

            //4.5.1
            //Console.WriteLine("分子と分母を入力してください");
            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());

            //    int c = a / b;

            //    Console.WriteLine(c);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0で割ることはできません");

            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("整数を入力してください");
            //}

            //4.6.1
            //int total = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    total += i;
            //}
            //Console.WriteLine("合計は" + total);

            //4.7.1

            //try
            //{
            //    Console.WriteLine("数値１を入力してください");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("数値２を入力してください");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine("演算子を入力してください");
            //    string c = Console.ReadLine();

            //    if(c == "+")
            //    {
            //        Console.WriteLine(a + b);
            //    }
            //    else if(c == "-")
            //    {
            //        Console.WriteLine(a - b);
            //    }
            //    else if(c == "*")
            //    {
            //        Console.WriteLine(a * b);
            //    }
            //    else if(c == "/")
            //    {
            //        Console.WriteLine(a / b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("不正な演算子です");
            //    }
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("数値を入力してください");
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("0で割ることはできません");
            //}

            //5.1.1


            //using (StreamWriter sw = new StreamWriter("output.txt"))
            //{
            //    sw.WriteLine("こんにちは");
            //    sw.WriteLine("こんにちは");
            //    sw.WriteLine("こんにちは");
            //}
            //Console.WriteLine("書き込みが完了しました");

            //5.2.1
            //using (StreamReader sr = new StreamReader("output.txt"))
            //{
            //    string Line;

            //    for (int i = 0; i < 3; i++)
            //    {
            //        Line = sr.ReadLine();
            //        Console.WriteLine(Line);
            //    }

            //}

            //5.3.1
            //string filePath = "append.txt";
            //string path = "append.txt";
            //string memo = "買い物";
            //string Line = $"{DateTime.Now:yyyy/MM/dd HH:mm}:{memo}";

            //using (StreamWriter sw = new StreamWriter(path, append: true))
            //{
            //    sw.WriteLine(Line);
            //}
            ////5.3.2
            //using (StreamWriter sw = new StreamWriter(path, append: false))
            //{
            //    sw.WriteLine("初期化しました");
            //}

            //string[] lines = File.ReadAllLines(path);

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}: {lines[i]}");
            //}

            //5.4.1

            //Console.WriteLine("読み込みたいファイル名を入力してください");
            //string a = Console.ReadLine();

            //if(!File.Exists(a))
            //{
            //    Console.WriteLine("存在しません");
            //    return;
            //}
            //try
            //{
            //    string[] lines = File.ReadAllLines(a);

            //    for (int i = 0; i < lines.Length; i++)
            //    {
            //        Console.WriteLine($"{i + 1}: {lines[i]}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("読み込み中にエラーが発生しました");
            //    Console.WriteLine(ex.Message);

            //}

            //5.5.1
            //string directoryPath = Path.Combine("data", "logs");
            //Directory.CreateDirectory(directoryPath);

            //string filePath = Path.Combine(directoryPath, "today.txt");

            //using(StreamWriter sw = new StreamWriter(filePath))
            //{
            //    sw.WriteLine("aa");
            //}

            //5.5.2

            //string a = "data";
            //string[] b = Directory.GetFiles(a);
            //if(b.Length == 0)
            //{
            //    Console.WriteLine("ファイルなし");
            //}
            //foreach(string c in b)
            //{
            //    FileInfo info = new FileInfo(c);
            //    Console.WriteLine(info.Name);
            //    Console.WriteLine(info.Length);
            //    Console.WriteLine(info.CreationTime);
            //}

            //5.6.1

            //string a = "quick.txt";

            //string[] data =
            //{
            //    "一行目",
            //    "二行目",
            //    "三行目",
            //};

            //File.WriteAllLines(a ,data);
            //string[] c = File.ReadAllLines(a);

            //for(int i = 0; i < c.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}:{c[i]}");
            //}

            //5.7.1
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //string u = "Users.csv";
            //string users = Console.ReadLine();
            //File.AppendAllText(u, users + Environment.NewLine,Encoding.GetEncoding("Shift_jis"));
            //using (StreamReader sr = new StreamReader(u))
            //{
            //    string[] a = File.ReadAllLines(u, Encoding.GetEncoding("Shift_jis"));

            //    foreach (string b in a)
            //    {
            //        string[] c = b.Split(',');

            //        if (c.Length != 2)
            //        {
            //            Console.WriteLine("想定外の列数です");
            //        }

            //        string d = c[0];
            //        string e = c[1];

            //        Console.WriteLine($"Name={d},Age={e}");
            //    }
            //}

            //5.7.2

            //string path = "users.csv";

            //string name;
            //int age;

            //Console.Write("Name を入力してください：");
            //name = Console.ReadLine();

            //while (true)
            //{
            //    Console.Write("Age を入力してください：");
            //    string input = Console.ReadLine();
            //    if (int.TryParse(input, out age))//int.TryParseはintかどうか確かめる
            //    {
            //        break;  
            //    }
            //    Console.WriteLine("Age は整数で入力してください");
            //}
            //using (StreamWriter sw = new StreamWriter(path, append: true))
            //{
            //    sw.WriteLine($"{name},{age}");
            //}
            //Console.WriteLine("CSV に追記しました");

            //5.8.1

            //List<User> users = new List<User>();
            //foreach(var a in File.ReadLines("users.csv")) 
            //{
            //    var s = a.Split(',');
            //    string name = s[0];
            //    int age = int.Parse(s[1]);

            //    users.Add(new User(name, age));
            //}

            //Console.WriteLine("すべてのユーザー");

            //foreach (User c in users)
            //{
            //    Console.WriteLine(c);
            //}

            //Console.WriteLine("降順");

            //var sortedNumbers = users.OrderByDescending(i => i);

            //Console.WriteLine(string.Join(",",sortedNumbers));

            //5.9.1
            //const int nameWidth = 20;
            //const int ageWidth = 5;

            //Console.WriteLine($"{"Name".PadRight(nameWidth)} {"Age".PadLeft(ageWidth)}");

            //Console.WriteLine(new string('-', nameWidth + ageWidth + 1));
            //foreach (var u in users)
            //{
            //    Console.WriteLine(
            //        $"{u.Name.PadRight(nameWidth)} {u.Age.ToString().PadLeft(ageWidth)}"
            //    );
            //}

            //5.10.1

            //string path = "utf8.txt";

            //using (var sw = new StreamWriter(path, append: false, Encoding.UTF8))
            //{
            //    sw.WriteLine("こんにちは");
            //    sw.WriteLine("UTF");
            //    sw.WriteLine("C#");
            //}

            //Console.WriteLine("書き込み完了");

            //using (var sr = new StreamReader(path, Encoding.UTF8))
            //{
            //    Console.WriteLine(" 読み込み結果 ");
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            //5.11

            //Logger.Log("起動しました");

            //try
            //{

            //    Logger.Log("ユーザー登録成功");

            //    throw new Exception("データベース接続エラー");
            //}
            //catch (Exception ex)
            //{
            //    Logger.Log("ERROR: " + ex.Message);
            //}
            //finally
            //{
            //    Logger.Log("終了します");
            //}

            //6.1.1.2
            //List<int> a = new List<int>();
            //int c = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("数字を入力してください");
            //    int b =  int.Parse(Console.ReadLine());
            //    a.Add(b);
            //    c += b;
            //}
            //Console.WriteLine("合計");
            //Console.WriteLine(c);
            //foreach (int d in a)
            //{
            //    Console.WriteLine("追加した整数");
            //    Console.WriteLine(d);
            //}
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

            List<int> a = new List<int>();
            for (int i = 0; i <5; i++)
            {
                int b = int.Parse(Console.ReadLine());
                a.Add(b);
            }
            foreach(int c in a)
            {
                Console.WriteLine(c);   
            }

        }


        //class Logger
        //{
        //    private static readonly string dir = "logs";
        //    private static readonly string path = Path.Combine(dir, "app.log");

        //    public static void Log(string message)
        //    {
        //        try
        //        {
        //            if (!Directory.Exists(dir))
        //            {
        //                Directory.CreateDirectory(dir);
        //            }
        //            string line = $"{DateTime.Now:yyyy-MM-ddTHH:mm:ss} {message}";

        //            using (var sw = new StreamWriter(path, append: true, Encoding.UTF8))
        //            {
        //                sw.WriteLine(line);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("ログ書き込み失敗: " + ex.Message);
        //        }


        public static void CheckAge(int age)
            {
                if (age < 0 || age >= 120)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    Console.WriteLine($"年齢は{age}歳です");
                }
            }

            struct Point
            {
                public int x { get; set; }
                public int y { get; set; }

                public void ShowPoint()
                {
                    Console.WriteLine($"x = {x} , y = {y}");
                }
            }
            enum Season
            {
                Spring,
                Summer,
                Autumn,
                Winter
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
                return (x + y) / 2;
            }

            static int Max(int x, int y, int z)
            {
                return Math.Max(x, Math.Max(y, z));
            }

            static int Mma(int[] a)
            {
                int k = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        k = a[i];
                    }
                }
                if (k < a[4])
                {
                    k = a[4];
                }
                return k;
            }

            static int Mi(int[] a)
            {
                int min = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (a[min] > a[i])
                    {
                        min = a[i];
                    }
                }
                return min;
            }

            static int Avge(int[] a)
            {
                int b = 0;
                for (int i = 0; i < 5; i++)
                {
                    b += a[i];
                }
                return b / 5;
            }

        public static void M2_4_5()
        {
            int b = 0;
            int c = 0;
            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine($"ストライクの場合は１、ボールの場合は２を入力,ファウルの場合は３を入力");
                int a = int.Parse(Console.ReadLine());

                if (a == 1)
                {
                    b++;
                }
                if (b == 3)
                {
                    break;
                }
            else if(a == 2)
                {
                    c++;
                }
                if(c == 4)
                {
                    break;
                }
                else if(a == 3 && b < 2)
                {
                    b++;
                }
            }
            Console.WriteLine($"{b}ストライク、{c}ボール");

        }


    }
    namespace School
    {
        class Teacher
        {
            public string name { get; set; }

            public void ShowProfile()
            {
                Console.WriteLine($"Teacher: {name}");
            }
        }

        class Student
        {
            public string name { get; set; }

            public void ShowProfile()
            {
                Console.WriteLine($"Student: {name}");
            }
        }
    }

        

    
}


