using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2026_0721
{
    internal class Veding
    {
        public int number { get; set;}
        public string name{ get; set; }
        public int price { get; set; }
        public int stock { get; set; }

        //public Veding(int number, string name, int price, int stock)
        //{
        //    this.number = number;
        //    this.name = name;
        //    this.price = price;
        //    this.stock = stock;
        //}


        public bool Buy(int money)
        {
            // 在庫がない場合は買えない
            if (stock <= 0)
            {
                return false;
            }

            // お金が足りない場合も買えない
            if (money < price)
            {
                return false;
            }

            // 上の条件をすべて満たしていれば買える
            return true;
        }

        public void ReduceStock()
        {
            // 在庫が1以上あるときだけ減らす
            if (stock > 0)
            {
                stock--;
            }
        }


    }
}
