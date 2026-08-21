using System;
using System.Collections.Generic;
using System.Text;

namespace _2026_0721
{
        class Library
        {
            Dictionary<string, string> book = new Dictionary<string, string>();
            List<string> book2 = new List<string>();
         
            List<string> book4 = new List<string>();

            public void Run()
            {
                while (true)
                {
                    Console.WriteLine("1:本を登録");
                    Console.WriteLine("2:貸出");
                    Console.WriteLine("3:返却");
                    Console.WriteLine("4:一覧表示");

                    int library = int.Parse(Console.ReadLine());

                    switch (library)
                    {
                        case 1:
                            //本の登録
                            Console.WriteLine();
                            Console.WriteLine("【登録する本のタイトルを入力してください】");
                            string a = Console.ReadLine();
                            Console.WriteLine("【登録する本の著者を入力してください】");
                            string b = Console.ReadLine();

                            book.Add(a, b);

                            Console.WriteLine();
                            Console.WriteLine("【登録が完了しました】");
                            Console.WriteLine();
                            Console.WriteLine($"タイトル：{a}、著者：{b}");
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("【貸出する本のタイトルを入力してください】");
                            string c = Console.ReadLine();

                            if (book.ContainsKey(c))
                            {
                                book2.Add(c);
                                book4.Add(c);
                                Console.WriteLine();
                                Console.WriteLine("【貸出登録が完了しました】");
                                Console.WriteLine($"タイトル：{c} ");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("【本を登録してください】");
                                Console.WriteLine();
                            }

                            break;

                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("【返却する本のタイトルを入力してください】");
                            string d = Console.ReadLine();
                            Console.WriteLine();
                            if (book2.Contains(d))
                            {
                            book2.Remove(d);
                            Console.WriteLine("【返却登録が完了しました】");
                                Console.WriteLine($"タイトル：{d}");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("【本を登録してください】");
                            }
                            break;

                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("【一覧表示】");
                            Console.WriteLine();

                            foreach (var li in book)
                            {
                                if (book2.Contains(li.Key))
                                {
                                    Console.WriteLine($"タイトル：{li.Key}、著者：{li.Value}、貸出状況：貸出中");
                                }
                                else if (!book2.Contains(li.Key))
                                {
                                    Console.WriteLine($"タイトル：{li.Key}、著者：{li.Value}、貸出状況：利用可能");
                                }
                               
                            }
                            Console.WriteLine();

                            break;
                    }
                }
            }
        }

    
}
