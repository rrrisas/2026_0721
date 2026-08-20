using System;
using System.Collections.Generic;
using System.Text;

namespace _2026_0721
{
    abstract class Employee
    {

        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public string Type { get; set; }
       
        public ITaxStrategy TaxStrategy { get; set; }

        public int Ipayable { get; set; }

        public abstract decimal CalculateMonthlyPay();

        public void ShowProfile()
        {
            Console.WriteLine($"名前：{Name}、雇用形態：{Type}");
        }
        public void MonthlyRoutine()
        {
            ShowProfile();
            BeforeCalcHook();
            CalculateMonthlyPay();
            AfterCalcHook();
        }

        virtual protected void BeforeCalcHook()
        {
            Console.WriteLine("給与計算前の処理を実行します。");
        }
        virtual protected void AfterCalcHook()
        {
            Console.WriteLine("給与計算後の処理を実行します。");
        }

        //public void GenerateReport()
        //{
        //    Console.WriteLine("----- 給与明細 -----");
        //    Console.WriteLine($"名前：{Name}");
        //    Console.WriteLine($"雇用形態：{Type}");
        //    Console.WriteLine($"手取り：{CalculateMonthlyPay()} 円");
        //    Console.WriteLine("---------------------");
        //}





    }
}
