using System;
using System.Collections.Generic;
using System.Text;

namespace _2026_0721
{
    class PartTimeEmployee : Employee, IReportable,IPayable
    {
        public decimal HourlyWage { get; set; }

        public int WorkedHours { get; set; }

        public override decimal CalculateMonthlyPay()
        {
            return HourlyWage * WorkedHours;
        }

        public void GenerateReport()
        {
            Console.WriteLine("----- 給与明細 -----");
            Console.WriteLine($"名前：{Name}");
            Console.WriteLine($"雇用形態：{Type}");
            Console.WriteLine($"勤務時間：{WorkedHours}時間");
            Console.WriteLine($"総支給額：{CalculateMonthlyPay()}円");
            Console.WriteLine("---------------------");
        }

        public void Pay()
        {
            Console.WriteLine($"{Name}さんに{CalculateMonthlyPay()}円を振込");
        }

    }
}
