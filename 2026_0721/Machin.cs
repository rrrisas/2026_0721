using System;
using System.Collections.Generic;
using System.Text;

namespace _2026_0721
{
     class Machin
    {
        private List<Veding> products;
        private int money = 0;
        private int sales = 0;

        public Machin(List<Veding> products)
        {
            this.products = products;
        }

        public void InsertMoney(int m)
        {
            int[] valid = { 10, 50, 100, 500, 1000 };

            if (!valid.Contains(m))
            {
                Console.WriteLine("その金額は投入できません");
                return;
            }

            money += m;
            Console.WriteLine($"{m}円を投入しました（合計: {money}円）");
        }

        public void Buy(int number)
        {
            var p = products.FirstOrDefault(x => x.number == number);

            if (p == null)
            {
                Console.WriteLine("商品番号が不正です");
                return;
            }

            if (p.stock <= 0)
            {
                Console.WriteLine("在庫がありません");
                return;
            }

            if (money < p.price)
            {
                Console.WriteLine("お金が足りません");
                return;
            }

            p.stock--;
            sales += p.price;

            int change = money - p.price;
            Console.WriteLine($"{p.name} を購入しました");
            Console.WriteLine($"おつり: {change}円");

            money = 0;
        }

        public void Refund()
        {
            Console.WriteLine($"返金: {money}円");
            money = 0;
        }

        public int GetSales()
        {
            return sales;
        }
    }

}

