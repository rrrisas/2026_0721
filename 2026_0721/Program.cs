
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.IO;
using System.IO.Enumeration;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            //6.1.1 2
            //List<int> a = new List<int>();
            ////int c = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("リストに入れる数字を入力してください");
            //    int b = int.Parse(Console.ReadLine());
            //    a.Add(b);
            //    // c += b;
            //}
            ////Console.WriteLine(c);
            //Console.WriteLine("リストに格納された数字");
            //foreach (int c in a)
            //{
            //    Console.WriteLine("______");
            //    Console.WriteLine(c);
            //}
            //int total = 0;
            //for (int i = 0; i < a.Count; i++)
            //{
            //    total += a[i];
            //}

            //Console.WriteLine($"合計：{total}");

            //6.2.1
            //List<string> apple = new List<string>();

            //apple.Add("りんご");
            //apple.Add("ばなな");
            //apple.Add("みかん");

            //foreach (string f in apple)
            //{
            //    Console.WriteLine("フルーツ");
            //    Console.WriteLine(f);
            //}
            //Console.WriteLine("格納したいフルーツを入力してください");
            //string d = Console.ReadLine();
            //apple.Add(d);

            //foreach (string e in apple)
            //{
            //    Console.WriteLine("フルーツリスト");
            //    Console.WriteLine(e);
            //}

            //6.3.1

            //Dictionary<string, int> Country = new Dictionary<string, int>();

            //Country.Add("Japan", 125);
            //Country.Add("France", 67);
            //Country.Add("USA", 331);

            ////foreach(var C in Country)
            ////{
            ////    Console.WriteLine($"{C.Key}:{C.Value}");
            ////}

            ////6.3.2
            //Console.WriteLine("検索したい国名を入力してください");
            //string P = Console.ReadLine();

            //if (Country.ContainsKey(P))
            //{
            //    Console.WriteLine($"{P}の人口は{Country[P]}万人です");
            //}
            //else
            //{
            //    Console.WriteLine("登録されていません");
            //}

            //6.4.1

            //List<Student> students = new List<Student>();

            //students.Add(new Student { Name = "A", Score = 85 });
            //students.Add(new Student { Name = "B", Score = 95 });
            //students.Add(new Student { Name = "C", Score = 100 });

            //foreach (var a in students)
            //{
            //    Console.WriteLine($"{a.Name}:{a.Score}");
            //}

            //List<int> number = new List<int>();
            //number.Add(1);
            //number.Add(2);
            //number.Add(3);
            //number.Add(4);
            //number.Add(5);

            //var doubled = number.Select(n => n * 2);

            //foreach (int a in doubled)
            //{
            //    Console.WriteLine(a);
            //}

            //6.5.1
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(5);
            //numbers.Add(6);
            //numbers.Add(7);
            //numbers.Add(8);
            //numbers.Add(9);

            //var a = numbers.Where(n => n % 2 == 0);

            //foreach (int y in a)
            //{
            //    Console.WriteLine(y);
            //}

            //6.5.2
            //List<string> F = new List<string>();

            //F.Add("banana");
            //F.Add("apple");
            //F.Add("cherry");
            //F.Add("date");

            //var b = F.OrderBy(n => n);

            //foreach (string c in b)
            //{
            //    Console.WriteLine(c);
            //}

            //6.7.1
            //List<int> Ave = new List<int> { 80, 92, 75, 60, 45 };

            //var a = Ave.Average();
            //Console.WriteLine(a);

            //6.7.2

            //List<int> a = new List<int> { 80, 92, 75, 60, 45 };

            //var b = a.Count(n => n >= 70);

            //Console.WriteLine(b);

            //6.8.1
            //List<Student> a = new List<Student>();

            //a.Add(new Student { Name = "A", Score = 85 });
            //a.Add(new Student { Name = "B", Score = 45 });
            //a.Add(new Student { Name = "C", Score = 98 });
            //a.Add(new Student { Name = "As", Score = 9 });
            //a.Add(new Student { Name = "AE", Score = 92 });

            //var b = a.Where(n => n.Score >= 70 && n.Name.StartsWith("A"));

            //foreach (var s in b)
            //{
            //    Console.WriteLine($"{s.Name}:{s.Score}");
            //}

            //6.9.1

            //List<Student> st = new List<Student>();
            //st.Add(new Student { Name = "Alice", Score = 80 });
            //st.Add(new Student { Name = "Bob", Score = 75 });
            //st.Add(new Student { Name = "Charlie", Score = 80 });
            //st.Add(new Student { Name = "Dave", Score = 60 });

            //var g = st.GroupBy(n => n.Score);

            //foreach (var a in g)
            //{
            //    Console.WriteLine($"点数: {a.Key}");

            //    foreach (var n in a)
            //    {
            //        Console.WriteLine($" {n.Name}");
            //    }
            //}

            //6.10

            //List<Product> P = new List<Product>();

            //P.Add(new Product { Name = "キャベツ", Price = 100, Category = "野菜" });
            //P.Add(new Product { Name = "牛肉", Price = 1000, Category = "肉" });
            //P.Add(new Product { Name = "チョコ", Price = 10, Category = "お菓子" });
            //P.Add(new Product { Name = "キノコ", Price = 500, Category = "野菜" });
            //P.Add(new Product { Name = "豚肉", Price = 2000, Category = "肉" });

            //var a = P.Where(n => n.Price >= 1000);

            //Console.WriteLine("1000円以上の商品");
            //foreach (var b in a)
            //{
            //    Console.WriteLine(b.Name);
            //}

            //Console.WriteLine();

            //var d = P.GroupBy(n => n.Category);

            //foreach (var e in d)
            //{
            //    Console.WriteLine($"{e.Count()}");
            //}

            //Console.WriteLine();

            //var f = P.OrderByDescending(n => n.Price);
            //foreach (var w in f)
            //{
            //    Console.WriteLine(w.Name);
            //}

            //7.1.1//7.2.1

            //List<Employee> salary = new List<Employee>();

            //salary.Add(new PartTimeEmployee { Name = "A", Type = "アルバイト", HourlyWage = 3000, WorkedHours = 10 });
            //salary.Add(new FullTimeEmployee { Name = "B", Type = "正社員", BaseSalary = 350000, OvertimeHours = 10 });
            //salary.Add(new PartTimeEmployee { Name = "C", Type = "アルバイト", HourlyWage = 5000, WorkedHours = 12 });
            //salary.Add(new FullTimeEmployee { Name = "D", Type = "正社員", BaseSalary = 100000, OvertimeHours = 5 });

            //foreach (var t in salary)
            //{
            //    t.ShowProfile();

            //    Console.WriteLine($"月給は: {t.CalculateMonthlyPay()} 円です");
            //    Console.WriteLine();
            //}

            //7.4.1.7.7.1/7.7.8

            //List<IReportable> a = new List<IReportable>();

            //a.Add(new PartTimeEmployee { Name = "A", Type = "アルバイト", HourlyWage = 3000, WorkedHours = 10 });
            //a.Add(new FullTimeEmployee { Name = "B", Type = "正社員", BaseSalary = 350000, OvertimeHours = 10, ITaxStrategy = 20000});
            //a.Add(new PartTimeEmployee { Name = "C", Type = "アルバイト", HourlyWage = 5000, WorkedHours = 12 });
            //a.Add(new FullTimeEmployee { Name = "D", Type = "正社員", BaseSalary = 100000, OvertimeHours = 5, ITaxStrategy = 10000});

            //foreach (var c in a)
            //{
            //    Console.WriteLine(c.GenerateReport());
            //}

            //7.6
            //Employee emp = new FullTimeEmployee();

            //emp.CalculateMonthlyPay();

            //7.7.1

            //var emp = new FullTimeEmployee
            //{
            //    Name = "佐藤",
            //    Type = "正社員",
            //    BaseSalary = 300000,
            //    OvertimeHours = 10
            //};

            //emp.MonthlyRoutine();

            //7.8,1

            //var emp = new FullTimeEmployee
            //{
            //    Name = "A",
            //    Type = "正社員",
            //    BaseSalary = 300000
            //};

            //Console.WriteLine("一律10%課税");
            //emp.TaxStrategy = new FlatTaxStrategy();
            //Console.WriteLine($"手取り：{emp.CalculateMonthlyPay()} 円");

            //Console.WriteLine();

            //Console.WriteLine("段階税率課税SSS");
            //emp.TaxStrategy = new ProgressiveTaxStrategy();
            //Console.WriteLine($"手取り：{emp.CalculateMonthlyPay()} 円");

            //7.9.1

            //List<IPayable> a = new List<IPayable>();

            //a.Add(new PartTimeEmployee { Name = "A", Type = "アルバイト", HourlyWage = 3000, WorkedHours = 10, TaxStrategy = new ProgressiveTaxStrategy() });
            //a.Add(new FullTimeEmployee { Name = "B", Type = "正社員", BaseSalary = 350000, OvertimeHours = 10, TaxStrategy = new FlatTaxStrategy() });
            //a.Add(new PartTimeEmployee { Name = "C", Type = "アルバイト", HourlyWage = 5000, WorkedHours = 12 , TaxStrategy = new ProgressiveTaxStrategy() });
            //a.Add(new FullTimeEmployee { Name = "D", Type = "正社員", BaseSalary = 100000, OvertimeHours = 5, TaxStrategy = new FlatTaxStrategy() });

            //foreach(var b in a)
            //{
            //    b.Pay();
            //}

            //7.10.1
            //List<Employee> employees = new List<Employee>();

            //while (true)
            //{
            //    Console.WriteLine("１：社員追加");
            //    Console.WriteLine("２：残業登録");
            //    Console.WriteLine("３：税方式切り替え");
            //    Console.WriteLine("４：月次処理");
            //    Console.WriteLine("５：明細表示");
            //    Console.WriteLine("６：終了");

            //    int c = int.Parse(Console.ReadLine());

            //    switch (c)
            //    {
            //        case 1:
            //            Console.WriteLine("名前を入力してください");
            //            string na = Console.ReadLine();

            //            Console.WriteLine("種別を入力してください（正社員 / アルバイト）");
            //            string ty = Console.ReadLine();

            //            if (ty == "正社員")
            //            {
            //                Console.WriteLine("基本給を入力してください");
            //                decimal salary = decimal.Parse(Console.ReadLine());

            //                employees.Add(new FullTimeEmployee
            //                {
            //                    Name = na,
            //                    Type = "正社員",
            //                    BaseSalary = salary,
            //                    TaxStrategy = new FlatTaxStrategy()
            //                });

            //                Console.WriteLine($"{na}さん（正社員）を登録しました");
            //            }
            //            else if (ty == "アルバイト")
            //            {
            //                Console.WriteLine("勤務時間を入力してください");
            //                int hours = int.Parse(Console.ReadLine());

            //                Console.WriteLine("時給を入力してください");
            //                decimal rate = decimal.Parse(Console.ReadLine());

            //                employees.Add(new PartTimeEmployee
            //                {
            //                    Name = na,
            //                    Type = "アルバイト",
            //                    WorkedHours = hours,
            //                    HourlyWage = rate,
            //                    TaxStrategy = new FlatTaxStrategy()
            //                });

            //                Console.WriteLine($"{na}さん（アルバイト）を登録しました");
            //            }
            //            else
            //            {
            //                Console.WriteLine("正社員とアルバイト以外は登録できません");
            //            }
            //            break;

            //        case 2:
            //            Console.WriteLine("残業時間を登録する名前を入力してください");
            //            string namei = Console.ReadLine();

            //            var emp = employees.Find(e => e.Name == namei);

            //            if (emp == null)
            //            {
            //                Console.WriteLine("登録されていない名前です");
            //                break;
            //            }

            //            if (emp is IOvertimeEligible ot)
            //            {
            //                Console.WriteLine("残業時間を入力してください");
            //                int overT = int.Parse(Console.ReadLine());
            //                ot.AddOvertimeHours(overT);
            //                Console.WriteLine("残業時間を登録しました");
            //            }
            //            else
            //            {
            //                Console.WriteLine("アルバイトは残業時間を登録できません");
            //            }
            //            break;

            //        case 3:
            //            Console.WriteLine("全員分の税方式を変更：１、個人の税方式を変更：２");
            //            int num = int.Parse(Console.ReadLine());

            //            if (num == 1)
            //            {
            //                Console.WriteLine("一律課税：１、段階課税：２");
            //                int taxnum = int.Parse(Console.ReadLine());

            //                ITaxStrategy strategy =
            //                    taxnum == 1 ? new FlatTaxStrategy() : new ProgressiveTaxStrategy();

            //                foreach (var e in employees)
            //                    e.TaxStrategy = strategy;

            //                Console.WriteLine("全員の税方式を変更しました");
            //            }
            //            else if (num == 2)
            //            {
            //                Console.WriteLine("名前を入力してください");
            //                string namei2 = Console.ReadLine();

            //                var emp2 = employees.Find(e => e.Name == namei2);

            //                if (emp2 == null)
            //                {
            //                    Console.WriteLine("登録されていない名前です");
            //                    break;
            //                }

            //                Console.WriteLine("一律課税：１、段階課税：２");
            //                int taxnum2 = int.Parse(Console.ReadLine());

            //                emp2.TaxStrategy =
            //                    taxnum2 == 1 ? new FlatTaxStrategy() : new ProgressiveTaxStrategy();

            //                Console.WriteLine($"{namei2}さんの税方式を変更しました");
            //            }
            //            break;

            //        case 4:
            //            Console.WriteLine("月次処理開始");
            //            Console.WriteLine("-----------------");
            //            foreach (var e in employees)
            //            {
            //                e.MonthlyRoutine();

            //                if (e is IPayable payable)
            //                {
            //                    payable.Pay();
            //                }
            //            }
            //            Console.WriteLine("-------------------");
            //            Console.WriteLine("月次処理終了");
            //            break;

            //        case 5:
            //            Console.WriteLine("明細を表示する名前を入力してください");
            //            string nam = Console.ReadLine();
            //            var em = employees.Find(e => e.Name == nam);

            //            if (em == null)
            //            {
            //                Console.WriteLine("登録されていない名前です");
            //                break;
            //            }

            //            if (em is IReportable reportable)
            //            {
            //                reportable.GenerateReport();
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{nam}さんは明細を表示できません");
            //            }

            //            break;

            //        case 6:
            //            Console.WriteLine("終了します");
            //            return;
            //    }
            //}

            //8.1
            //try 
            //{ 

            //Console.WriteLine("数字を入力してください");

            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("演算子（+,-,*,/)を入力してください");

            //string e = Console.ReadLine();

            //Console.WriteLine("数字を入力してください");

            //int num2 = int.Parse(Console.ReadLine());

            //if(e == "+")
            //{
            //    Console.WriteLine("計算結果:"　+ num1 + num2);
            //}
            //else if (e == "-")
            //{
            //    Console.WriteLine("計算結果:" + (num1 - num2));
            //}
            //else if (e == "*")
            //{
            //    Console.WriteLine("計算結果:" + num1 * num2);
            //}
            //else if (e == "/")
            //{
            //    Console.WriteLine("計算結果:" + num1 / num2);
            //}
            //else
            //{
            //    Console.WriteLine("不正な演算子です");
            //}
            //}
            //catch (ArithmeticException)
            //{
            //    Console.WriteLine("0で割ることはできません");
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("数字を入力してください");
            //}

            //8.2
            //単語格納リスト

            //Dictionary<string, string> word = new Dictionary<string, string>();

            //while (true)
            //{

            //    Console.WriteLine("1:単語を登録");
            //    Console.WriteLine("2:一覧表示");
            //    Console.WriteLine("3:検索");

            //    int num = int.Parse(Console.ReadLine());

            //    switch (num)
            //    {
            //        //単語の登録
            //        case 1:
            //            Console.WriteLine("単語を入力してください");
            //            string word1 = Console.ReadLine();
            //            Console.WriteLine("単語の意味を入力してください");
            //            string word2 = Console.ReadLine();

            //            //リストに追加
            //            word.Add(word1, word2);

            //            Console.WriteLine("単語を登録しました");

            //            break;
            //        //単語の一覧表示
            //        case 2:

            //            Console.WriteLine("登録されている単語一覧");
            //            foreach(var W in word)
            //            {
            //                Console.WriteLine($"単語：{W.Key}、意味：{W.Value}");
            //            }

            //            break;
            //        //単語の検索
            //        case 3:

            //            Console.WriteLine("検索する単語を入力してください");

            //            string word3 = Console.ReadLine();

            //            string Serchkey = word3;

            //            if(word.ContainsKey(Serchkey))
            //            {
            //                Console.WriteLine($"単語：{Serchkey}、意味：{word[Serchkey]}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("単語が登録されていません");
            //            }

            //            break;
            //    }
            //}

            //    Dictionary<string, string> word = LoadCsv();

            //    while (true)
            //    {
            //        Console.WriteLine("1:単語を登録");
            //        Console.WriteLine("2:一覧表示");
            //        Console.WriteLine("3:検索");
            //        Console.WriteLine("4:終了（CSV保存）");

            //        int num = int.Parse(Console.ReadLine());

            //        switch (num)
            //        {
            //            case 1:
            //                Console.WriteLine("単語を入力してください");
            //                string word1 = Console.ReadLine();
            //                Console.WriteLine("単語の意味を入力してください");
            //                string word2 = Console.ReadLine();

            //                word[word1] = word2;
            //                Console.WriteLine("単語を登録しました");
            //                break;

            //            case 2:
            //                Console.WriteLine("登録されている単語一覧");
            //                foreach (var W in word)
            //                {
            //                    Console.WriteLine($"単語：{W.Key}、意味：{W.Value}");
            //                }
            //                break;

            //            case 3:
            //                Console.WriteLine("検索する単語を入力してください");
            //                string Serchkey = Console.ReadLine();

            //                if (word.ContainsKey(Serchkey))
            //                {
            //                    Console.WriteLine($"単語：{Serchkey}、意味：{word[Serchkey]}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("単語が登録されていません");
            //                }
            //                break;

            //            case 4:
            //                SaveCsv(word);
            //                return;
            //        }
            //    }
            //}

            //static void SaveCsv(Dictionary<string, string> word)
            //{
            //    using (var sw = new StreamWriter("word.csv"))
            //    {
            //        foreach (var w in word)
            //        {
            //            sw.WriteLine($"{w.Key},{w.Value}");
            //        }
            //    }
            //    Console.WriteLine("CSVに保存しました");
            //}

            //static Dictionary<string, string> LoadCsv()
            //{
            //    var word = new Dictionary<string, string>();

            //    if (!File.Exists("word.csv"))
            //        return word;

            //    foreach (var line in File.ReadAllLines("word.csv"))
            //    {
            //        var parts = line.Split(',');
            //        if (parts.Length == 2)
            //        {
            //            word[parts[0]] = parts[1];
            //        }
            //    }

            //    Console.WriteLine("CSVを読み込みました");
            //    return word;
            //}


            //8.3
            //リスト作成
            //List<Product> name = new List<Product>();
            //name.Add(new Product { Name = "人参", Price = 100, Category = "野菜" });
            //name.Add(new Product { Name = "鶏肉", Price = 500, Category = "肉" });
            //name.Add(new Product { Name = "じゃがりこ", Price = 150, Category = "お菓子" });
            //name.Add(new Product { Name = "牛乳", Price = 200, Category = "飲み物" });

            ////商品一覧表示
            //Console.WriteLine("商品一覧");
            //foreach (var pr in name)
            //{
            //    Console.WriteLine($"商品名：{pr.Name}、価格：{pr.Price}円、カテゴリー：{pr.Category}");
            //}
            //Console.WriteLine();

            ////価格高い順
            //var order = name.OrderByDescending(p => p.Price);
            //Console.WriteLine("価格の高い順");

            //foreach (var pri in order)
            //{
            //    Console.WriteLine($"商品名：{pri.Name}、価格：{pri.Price}円、カテゴリー：{pri.Category}");
            //}
            ////カテゴリごとにグループ化

            //Console.WriteLine();
            //var group = name.GroupBy(p => p.Category);
            //Console.WriteLine("カテゴリごとにグループ化");

            //foreach (var gr in group)
            //{
            //    Console.WriteLine($"カテゴリ：{gr.Key}");

            //    foreach (var item in gr)
            //    {
            //        Console.WriteLine($"  商品名：{item.Name}、価格：{item.Price}円");
            //    }
            //}


            //8.4

            //本を登録するクラスを別で作る、タイトル著者貸出状況のプロパティ作る、それをリストにする
            //  Dictionary<string, string> book = new Dictionary<string, string>();
            //  List<string> book2 = new List<string>();
            //  List<string> book3 = new List<string>();

            //  while (true)
            //  {
            //      Console.WriteLine("1:本を登録");
            //      Console.WriteLine("2:貸出");
            //      Console.WriteLine("3:返却");
            //      Console.WriteLine("4:一覧表示");

            //      int library = int.Parse(Console.ReadLine());

            //      switch (library)
            //      {
            //          case 1:
            //              //本の登録
            //              Console.WriteLine();
            //              Console.WriteLine("【登録する本のタイトルを入力してください】");
            //              string a = Console.ReadLine();
            //      Console.WriteLine("【登録する本の著者を入力してください】");
            //              string b = Console.ReadLine();

            //              book.Add(a,b);

            //              Console.WriteLine();
            //              Console.WriteLine("【登録が完了しました】");
            //              Console.WriteLine();
            //              Console.WriteLine($"タイトル：{a}、著者：{b}");
            //              Console.WriteLine();
            //              break;

            //case 2:
            //              Console.WriteLine();
            //              Console.WriteLine("【貸出する本のタイトルを入力してください】");
            //              string c = Console.ReadLine();

            //              if(book.ContainsKey(c))
            //              {
            //                  book2.Add(c);
            //                  book4.Add(c);
            //                  Console.WriteLine();
            //                  Console.WriteLine("【貸出登録が完了しました】");
            //                  Console.WriteLine($"タイトル：{c} ");
            //                  Console.WriteLine();
            //              }
            //              else
            //              {
            //                  Console.WriteLine();
            //                  Console.WriteLine("【本を登録してください】");
            //                  Console.WriteLine();
            //              }

            //              break;

            //          case 3:
            //              Console.WriteLine();
            //              Console.WriteLine("【返却する本のタイトルを入力してください】");
            //              string d = Console.ReadLine();
            //              Console.WriteLine();
            //              if (book2.Contains(d))
            //              {
            //                  book3.Add(d);
            //                  Console.WriteLine("【返却登録が完了しました】");
            //                  Console.WriteLine($"タイトル：{d}");
            //                  Console.WriteLine();
            //              }
            //              else
            //              {
            //                  Console.WriteLine("【本を登録してください】");
            //              }
            //              break;
            //          case 4:
            //              Console.WriteLine();
            //              Console.WriteLine("【一覧表示】");
            //              Console.WriteLine();

            //              foreach(var li in book)
            //              {

            //                  if (book3.Contains(li.Key) && book2.Contains(li.Key))
            //                  {
            //                      Console.WriteLine($"タイトル：{li.Key}、著者：{li.Value}、貸出状況：利用可能");
            //                  }
            //                  else if (book2.Contains(li.Key))
            //                  {
            //                      Console.WriteLine($"タイトル：{li.Key}、著者：{li.Value}、貸出状況：貸出中");
            //                  }
            //                  else
            //                  {
            //                      Console.WriteLine($"タイトル：{li.Key}、著者：{li.Value}、貸出状況：利用可能");
            //                  }
            //              }
            //              Console.WriteLine();

            //              break;

            //}
            //}     
            //Library library = new Library();
            //library.Run();


                //List<Veding> a = new List<Veding>();
                //a.Add(new Veding { number = 1, name = "コーラ", price = 170, stock = 10 });
                //a.Add(new Veding { number = 2, name = "お茶", price = 150, stock = 20 });
                //a.Add(new Veding { number = 3, name = "コーヒー", price = 160, stock = 25 });
                //a.Add(new Veding { number = 4, name = "紅茶", price = 130, stock = 15 });
                //a.Add(new Veding { number = 5, name = "りんごジュース", price = 120, stock = 5 });
                //a.Add(new Veding { number = 6, name = "ポカリ", price = 180, stock = 30 });

                //Machin vm = new Machin(a); 

                //while (true)
                //{
                //    Console.WriteLine("=== 商品一覧 ===");
                //    foreach (var b in a)
                //    {
                //        Console.WriteLine($"{b.number}：{b.name}、{b.price}円、在庫：{b.stock}");
                //    }

                //    Console.WriteLine();
                //    Console.WriteLine("1: お金を入れる");
                //    Console.WriteLine("2: 商品を購入する");
                //    Console.WriteLine("3: 返金する");
                //    Console.WriteLine("4: 終了する");
                //    Console.Write("選択: ");

                //    int c = int.Parse(Console.ReadLine());
                //    Console.WriteLine();

                //    try
                //    {
                //        switch (c)
                //        {
                //            case 1:
                //                Console.WriteLine("お金を入れてください（10/50/100/500/1000）");
                //                int money = int.Parse(Console.ReadLine());
                //                vm.InsertMoney(money);
                //                break;

                //            case 2:
                //                Console.Write("商品番号: ");
                //                int num = int.Parse(Console.ReadLine());
                //                vm.Buy(num);
                //                break;

                //            case 3:
                //                vm.Refund();
                //                break;

                //            case 4:
                //                Console.WriteLine("終了します");
                //                Console.WriteLine($"総売上: {vm.GetSales()}円");
                //                return;

                //            default:
                //                Console.WriteLine("不正な入力です");
                //                break;
                //        }
                //    }
                //    catch (FormatException)
                //    {
                //        Console.WriteLine("数字を入力してください");
                //    }

                //    Console.WriteLine();
                //}
         }
        

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


//public static void CheckAge(int age)
//    {
//        if (age < 0 || age >= 120)
//        {
//            throw new ArgumentOutOfRangeException();
//        }
//        else
//        {
//            Console.WriteLine($"年齢は{age}歳です");
//        }
//    }

//struct Point
//{
//    public int x { get; set; }
//    public int y { get; set; }

//    public void ShowPoint()
//    {
//        Console.WriteLine($"x = {x} , y = {y}");
//    }
//}
//enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}
//static int Calc(int x, int y)
//{
//    return (x + y);
//}

//static void mondai2_1_1()
//{
//    Console.WriteLine("Hello, World!");
//}
//            static void mondai2_1_2()
//            {
//                int x = 11;
//                Console.WriteLine($"x={x}");

//            }
//            static void mondai2_1_3()
//            {
//                int x = 13;
//                int y = 17;
//                Console.WriteLine($"x={x + y}");
//            }
//            static void mondai2_1_4()
//            {
//                Console.WriteLine(13 * 17);
//            }

//            static void mondai2_2_1()
//            {
//                string s = Console.ReadLine();
//                Console.WriteLine(s);
//            }

//            static void mondai2_2_2()
//            {
//                int x = int.Parse(Console.ReadLine());
//                Console.WriteLine(x);
//            }
//            static void mondai2_2_3(int x, int y)
//            {
//                Console.WriteLine((x + y) / 2);
//            }
//            static void mondai2_2_4(int x)
//            {
//                Console.WriteLine(x * 365);
//            }
//            static int Power(int x)
//            {
//                return (x * x);
//            }
//            static void aaa(int x)
//            {
//                if (x >= 10)
//                {
//                    return;
//                }
//                Console.WriteLine("値が10以下です");

//            }

//            static double CircleArea(double x)
//            {
//                return (x * x * 3.14);
//            }

//            static void Time(int x)
//            {
//                int hours = x / 3600;
//                int minute = (x % 3600) / 60;
//                int seconds = x % 60;

//                Console.WriteLine($"{hours}時間{minute}分{seconds}秒");
//            }

//            static int Add(int a, int b)
//            {
//                return (a + b);
//            }

//            static bool IsEven(int number)
//            {
//                if (number % 2 == 0)
//                {
//                    return true;
//                }
//                {
//                    return false;
//                }
//            }

//            static int CalcTax(int price)
//            {
//                return (int)Math.Floor(price * 1.1);
//            }

//            static int GetMax(int a, int b, int c)
//            {
//                return Math.Max(a, Math.Max(b, c));
//            }

//            //static int CalcTax(int price, int a)
//            // {
//            // return (int)Math.Floor(price * 1.1);
//            // }

//            //static int CalcDamage(int attac, int defense)
//            //{
//            //return   

//            static int Suuchi(int x, int y)
//            {
//                if (x > y)
//                {
//                    Console.WriteLine("xはyより大きい");
//                    return 1;
//                }
//                else if (x < y)
//                {
//                    Console.WriteLine("xはyより小さい");
//                    return -1;
//                }
//                Console.WriteLine("xとyは等しい");
//                return 0;
//            }

//            static int Hennsuu(int x, int y)
//            {
//                if (x > y)
//                {
//                    Console.WriteLine("xはyより大きい");
//                    return 1;
//                }
//                return 0;
//            }

//            static bool Seisuu(int x)
//            {
//                if (x % 2 == 0)
//                {
//                    return true;
//                }
//                return false;
//            }

//            static void Tennsuu(int x)
//            {
//                if (x >= 60)
//                {
//                    Console.WriteLine("合格");
//                    return;
//                }
//                Console.WriteLine("不合格");
//            }

//            static void Test(int x)
//            {
//                if (x >= 80)
//                {
//                    Console.WriteLine("合格");
//                    return;
//                }
//                else if (x >= 60)
//                {
//                    Console.WriteLine("不合格");
//                    return;
//                }
//                Console.WriteLine("残念でした");
//            }

//            static void Test2(int x)
//            {
//                if (x >= 80)
//                {
//                    Console.WriteLine("優");
//                    return;
//                }
//                else if (x >= 70)
//                {
//                    Console.WriteLine("良");
//                    return;
//                }
//                else if (x >= 60)
//                {
//                    Console.WriteLine("可");
//                    return;
//                }
//                Console.WriteLine("不可");
//            }

//            static void Spam()
//            {
//                for (int i = 0; i < 10; i++)
//                {
//                    Console.WriteLine("SPAM");
//                }
//            }

//            static void Kuku()
//            {
//                for (int i = 1; i <= 9; i++)
//                {
//                    Console.WriteLine(3 * i);
//                }
//            }

//            static void Avg()
//            {
//                double a = 0;
//                for (double i = 0; i < 10; i++)
//                {
//                    a += double.Parse(Console.ReadLine());
//                }
//                Console.WriteLine(Math.Truncate(a / 10));
//            }

//            static void Giants()
//            {
//                int a = 0;
//                int b = 0;
//                int c = 0;
//                int d = 0;

//                for (int i = 1; i < 10; i++)
//                {

//                    Console.WriteLine($"{i}表、巨人の得点は？");
//                    a = int.Parse(Console.ReadLine());

//                    Console.WriteLine($"{i}裏、阪神の得点は？");
//                    b = int.Parse(Console.ReadLine());

//                    c += a;
//                    d += b;
//                }

//                Console.WriteLine($"巨人{c}点 , 阪神：{d}点");

//                if (c > d)
//                {
//                    Console.WriteLine("巨人の勝ち♪");
//                    return;
//                }
//                else if (c < d)
//                {
//                    Console.WriteLine("阪神の勝ち");
//                    return;
//                }
//                Console.WriteLine("引き分け");
//            }
//            static void counts()
//            {
//                int c = 0;
//                int d = 0;

//                for (int i = 0; i < 99; i++)
//                {
//                    Console.WriteLine("ストライク=1, ボール=2，ファウル=3 ?");
//                    int a = int.Parse(Console.ReadLine());

//                    if (a == 1)
//                    {
//                        c++;

//                        if (c == 3)
//                        {
//                            break;
//                        }
//                    }
//                    else if (a == 2)
//                    {
//                        d++;

//                        if (d == 4)
//                        {
//                            break;
//                        }
//                    }
//                    else if (a == 3)
//                    {
//                        if (c <= 1)
//                        {
//                            c++;
//                        }
//                    }

//                }

//                Console.WriteLine($"{d}ボール{c}ストライク");
//            }

//            static void Hairertsu()
//            {
//                int[] a = new int[10];
//                for (int i = 0; i < 10; i++)
//                {
//                    a[i] = int.Parse(Console.ReadLine());
//                }
//                for (int i = 0; i < 10; i++)
//                {
//                    Console.WriteLine(a[i] * 2);
//                }
//            }

//            static void Hairertsu2()
//            {
//                int[] a = new int[10];
//                for (int i = 0; i < 10; i++)
//                {
//                    a[i] = int.Parse(Console.ReadLine());
//                }

//                Console.Write("偶数 : ");
//                for (int i = 0; i < 10; i++)
//                {
//                    if (a[i] % 2 == 0)
//                    {
//                        Console.Write($"{a[i]} ");
//                    }
//                }

//                Console.WriteLine();

//                Console.Write("奇数 : ");
//                for (int i = 0; i < 10; i++)
//                {
//                    if (a[i] % 2 != 0)
//                    {
//                        Console.Write($"{a[i]} ");
//                    }
//                }
//            }

//            static void Seisuu2()
//            {
//                int[] a = new int[10];

//                for (int i = 0; i < 10; i++)
//                {
//                    a[i] = int.Parse(Console.ReadLine());
//                }
//                for (int i = 0; i < 9; i++)
//                {
//                    if (a[i] < a[i + 1])
//                    {
//                        int b = a[i];
//                        a[i] = a[i + 1];
//                        a[i + 1] = b;
//                    }
//                    Console.WriteLine(i);
//                }
//            }
//            static int Nijou(int x)
//            {
//                return x * x;
//            }

//            static int Avge(int x, int y)
//            {
//                return (x + y) / 2;
//            }

//            static int Max(int x, int y, int z)
//            {
//                return Math.Max(x, Math.Max(y, z));
//            }

//            static int Mma(int[] a)
//            {
//                int k = 0;
//                for (int i = 0; i < 4; i++)
//                {
//                    if (a[i] > a[i + 1])
//                    {
//                        k = a[i];
//                    }
//                }
//                if (k < a[4])
//                {
//                    k = a[4];
//                }
//                return k;
//            }

//            static int Mi(int[] a)
//            {
//                int min = 0;
//                for (int i = 0; i < 5; i++)
//                {
//                    if (a[min] > a[i])
//                    {
//                        min = a[i];
//                    }
//                }
//                return min;
//            }

//            static int Avge(int[] a)
//            {
//                int b = 0;
//                for (int i = 0; i < 5; i++)
//                {
//                    b += a[i];
//                }
//                return b / 5;
//            }

//        public static void M2_4_5()
//        {
//            int b = 0;
//            int c = 0;
//            for (int i = 0; i < 99; i++)
//            {
//                Console.WriteLine($"ストライクの場合は１、ボールの場合は２を入力,ファウルの場合は３を入力");
//                int a = int.Parse(Console.ReadLine());

//                if (a == 1)
//                {
//                    b++;
//                }
//                if (b == 3)
//                {
//                    break;
//                }
//            else if(a == 2)
//                {
//                    c++;
//                }
//                if(c == 4)
//                {
//                    break;
//                }
//                else if(a == 3 && b < 2)
//                {
//                    b++;
//                }
//            }
//            Console.WriteLine($"{b}ストライク、{c}ボール");

//        }


//    }
//    namespace School
//    {
//        class Teacher
//        {
//            public string name { get; set; }

//            public void ShowProfile()
//            {
//                Console.WriteLine($"Teacher: {name}");
//            }
//        }

//        class Student
//        {
//            public string name { get; set; }

//            public void ShowProfile()
//            {
//                Console.WriteLine($"Student: {name}");
//            }
//        }
//    }




//}
// using System.ComponentModel;
//using System.Security.AccessControl;
//using System.Security.Cryptography.X509Certificates;
//2.8.3
//List<Animal> dc = new List<Animal>();
//dc.Add(new Dog("アトム",4));
//dc.Add(new Cat("み", 4));

//foreach(Animal a in dc)
//{
//    Console.WriteLine(a);
//    a.Speak();
//}
//2.8.4

//List<Animal> dcb = new List<Animal>();
//dcb.Add(new Dog("アトム",4));
//dcb.Add(new Cat("み", 4));
//dcb.Add(new Bird("み", 4));
//foreach(Animal a in dcb)
//{
// Console.WriteLine(a);
//    if (a is Bird b) { b.Fly(); }
//    a.Speak();

//}

//2.8.5
//Dog dog = new Dog("アトム",5);
//Cat cat = new Cat("ミケ", 5);
//Bird bird = new Bird("ピー",4);

//Animal a = new Dog("アトム",5);
//a.walk();
//a.walk(3);

//2.8.6

//List<Animal> animals = new List<Animal>()
//{
//    new Dog("ポチ", 3),
//    new Cat("ミケ", 2),
//    new Bird("ピーちゃん", 1)
//};

//foreach (Animal a in animals)
//{
//    Console.WriteLine($"{a.Species} : {a.Name}, {a.Age}");
//}

//2.8.7

//Cat cat = new Cat("猫",3);
//cat.Showkaind():

//2.8.8

//2.8.9
//List<Animal> a = new List<Animal>();
//a.Add(new Dog("犬",4));
//a.Add(new Cat("猫", 5));
//a.Add(new Bird("鳥", 6));

//foreach(Animal b in a)
//{

//    b.DoDaily();
//}

//2.8.10
//List<IPlayable> a = new List<IPlayable>();
//a.Add(new Dog("犬", 4));
//a.Add(new Cat("猫", 5));
//a.Add(new Bird("鳥", 6));
//foreach (IPlayable b in a)
//{
//    b.play();
//}
//List<Animal> b = new List<Animal>();
//b.Add(new Dog("犬", 4));
//b.Add(new Cat("猫", 5));
//b.Add(new Bird("鳥", 6));
//foreach (Animal c in b)
//{
//    c.Speak();
//}

//2.8.11
//int counts = 0;
//Dictionary<string, int> ani = new Dictionary<string, int>();
//List<Animal> anim = new List<Animal>();
//Console.WriteLine("登録する頭数を教えてください。");
//int b = int.Parse(Console.ReadLine());
//for (int i = 0; i < b; i++)
//{
//    Console.WriteLine("種類、名称、年齢を入力してください");
//    string a = Console.ReadLine();
//    string[] parts = a.Split(' ');
//    string type = parts[0];
//    string name = parts[1];
//    int age = int.Parse(parts[2]);
//    Animal d = null;
//    if (type == "Dog")
//        d = new Dog(name, age);
//    else if (type == "Cat")
//        d = new Cat(name, age);
//    else if (type == "Bird")
//        d = new Bird(name, age);
//    else
//    {
//        Console.WriteLine("不明な種類です。");
//        continue;
//    }
//    anim.Add(d);
//    if (!ani.ContainsKey(type))
//        ani[type] = 0;

//    ani[type]++;
//}
//foreach (Animal a in anim)
//{
//    a.Speak();
//    a.ShowProfile();


//    if (a is IPlayable p)
//    {
//        a.Play();
//    }

//    Console.WriteLine();
//}

//Console.WriteLine("--- 種類別頭数 ---");
//foreach (var kv in ani)
//{
//    Console.WriteLine($"{kv.Key}: {kv.Value} 匹");
//}

//namespace _0824
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
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
            //M2_6_4();
        //}
    //    public static void M2_6_4()
    //    {
    //        int c = 0;
    //        int[] b = new int[5];
    //        int d = 0;
    //        int min = int.MaxValue;

    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine("数字を入力してください");
    //            int a = int.Parse(Console.ReadLine());
    //            c += a;
    //            if (d < a)
    //            {
    //                d = a;
    //            }
    //            else if (a < min)
    //            {
    //                min = a;
    //            }
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine($"最大値:{d}");
    //        Console.WriteLine();
    //        Console.WriteLine($"最小値:{min}");
    //        Console.WriteLine();
    //        Console.WriteLine($"平均値:{c / 5}");
    //    }

    //    public static int M2_6_3(int x, int y)
    //    {
    //        return (x + y) / 2;
    //    }
    //    public static int M2_6_2(int x, int y)
    //    {
    //        if (x > y)
    //        {
    //            return x;
    //        }
    //        else if (y > x)
    //        {
    //            return y;
    //        }
    //        return 0;
    //    }
    //    public static int M2_6_1(int x)
    //    {
    //        return x * x;
    //    }
    //    public static int M2_3_1(int x, int y)
    //    {
    //        if (x > y)
    //        {
    //            Console.WriteLine("xはｙより大きい");
    //            return 1;
    //        }

    //        return 0;

    //    }

    //    public static int M2_3_2(int x, int y)
    //    {
    //        if (x > y)
    //        {
    //            Console.WriteLine("ｘはｙより大きい");
    //            return 1;
    //        }
    //        else if (x < y)
    //        {
    //            Console.WriteLine("yはxより大きい");
    //            return 1;
    //        }
    //        else
    //        {
    //            Console.WriteLine("ｘとｙは等しい");
    //            return 1;
    //        }
    //        return 0;
    //    }

    //    public static void M2_3_3()
    //    {
    //        int c = int.Parse(Console.ReadLine());
    //        if (c % 2 == 0)
    //        {
    //            Console.WriteLine("偶数です");
    //        }
    //        else
    //        {
    //            Console.WriteLine("奇数です");
    //        }
    //    }
    //    public static void M2_3_4()
    //    {
    //        int x = int.Parse(Console.ReadLine());
    //        if (80 <= x)
    //        {
    //            Console.WriteLine("たいへんよくできました");
    //            Console.WriteLine("優");
    //        }
    //        if (80 >= x && 60 <= x)
    //        {
    //            Console.WriteLine("よくできました");
    //        }
    //        if (80 >= x && 70 <= x)
    //        {
    //            Console.WriteLine("良");
    //        }
    //        if (70 >= x && 60 <= x)
    //        {
    //            Console.WriteLine("可");
    //        }
    //        else if (60 <= x)
    //        {
    //            Console.WriteLine("合格");
    //        }
    //        else if (60 >= x)
    //        {
    //            Console.WriteLine("不合格");
    //            Console.WriteLine("残念でした");
    //            Console.WriteLine("不可");
    //        }
    //    }
    //    public static int M2_3_5(int x, int y)
    //    {
    //        if (x < y && x % 2 == 0 && y % 2 == 0)
    //        {
    //            Console.WriteLine("xはyより小さく、かつ、xとyはともに偶数である");
    //            return 1;
    //        }
    //        if (x == y && x < 0 && y < 0)
    //        {
    //            Console.WriteLine("xとyは等しく、かつ、負の数である");
    //            return 1;
    //        }
    //        if (x < y || x % 2 == 0)
    //        {
    //            Console.WriteLine("xはyより小さい、または、xは偶数である");
    //            return 1;
    //        }
    //        if (x <= 10 && x >= 100 && y >= 10 && y <= 100)
    //        {
    //            Console.WriteLine("xは10以下または100以上で、かつ、yは10以上かつ100以下である");
    //            return 1;
    //        }
    //        if (x > 0 && y > 0)
    //        {
    //            Console.WriteLine("xもyも負の数である、ではない");
    //            return 1;
    //        }
    //        return 0;
    //    }

    //    public static void M2_4_4()
    //    {
    //        int k = 0;
    //        int h = 0;

    //        for (int i = 1; i < 10; i++)
    //        {
    //            Console.Write($"{i}回表、巨人の得点を入力してください：");
    //            int b = int.Parse(Console.ReadLine());
    //            Console.Write($"{i}回裏、阪神の得点を入力してください：");
    //            int c = int.Parse(Console.ReadLine());
    //            k += b;
    //            h += c;
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine($"巨人；{k}点、阪神：{h}点");
    //        Console.WriteLine();
    //        if (k > h)
    //        {
    //            Console.WriteLine("巨人の勝ち");
    //        }
    //        else
    //        {
    //            Console.WriteLine("阪神の勝ち");
    //        }
    //    }

    //    public static void M2_4_5()
    //    {
    //        int b = 0;
    //        int c = 0;
    //        for (int i = 0; i < 99; i++)
    //        {
    //            Console.WriteLine("ストライクの場合は１、ボールの場合は２を入力してください、ファウルの場合は3を入力してください");
    //            int a = int.Parse(Console.ReadLine());
    //            if (a == 1)
    //            {
    //                b += a;
    //                if (b == 3)
    //                {
    //                    break;
    //                }
    //            }
    //            else if (a == 3 && b < 2)
    //            {
    //                b += 1;
    //            }
    //            else if (a == 2)
    //            {
    //                c += 1;
    //                if (c == 4)
    //                {
    //                    break;
    //                }
    //            }
    //        }
    //        Console.WriteLine($"{c}ボール、{b}ストライク");
    //    }
    //    public static void M2_5_1()
    //    {
    //        int[] a = new int[10];
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.WriteLine("数字を入力してください");
    //            int b = int.Parse(Console.ReadLine());
    //            a[i] = b;
    //        }
    //        foreach (int c in a)
    //        {
    //            Console.WriteLine(2 * c);
    //        }
    //    }
    //    public static void M2_5_2()
    //    {
    //        int[] d = new int[10];
    //        int[] e = new int[10];
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.WriteLine("数字を入力してください");
    //            int a = int.Parse(Console.ReadLine());
    //            d[i] = a;
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine("偶数");
    //        Console.WriteLine();
    //        foreach (int f in d)
    //        {
    //            if (f % 2 == 0)
    //            {
    //                Console.WriteLine(f);
    //            }
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine("奇数");
    //        Console.WriteLine();
    //        foreach (int f in d)
    //        {
    //            if (f % 2 == 1)
    //            {
    //                Console.WriteLine(f);
    //            }
    //        }

    //    }
    //}
//}





