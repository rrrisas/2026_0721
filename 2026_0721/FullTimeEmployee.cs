using _2026_0721;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2026_0721
{
    class FullTimeEmployee : Employee , IOvertimeEligible , IReportable
    {

        public int OvertimeHours { get; set; }

        public decimal BaseSalary { get; set; }

        
        public int GetOvertimeHours()
        {
            return OvertimeHours;
        }

        public void AddOvertimeHours(int hours)
        {
            OvertimeHours += hours;
        }

        //public string GenerateReport()
        //{

        //    return $"名前：{Name}、雇用形態：{Type}、残業時間：{OvertimeHours}時間、残業代：{OvertimeHours * (BaseSalary / 160m) * 1.25m}円、総支給額：{CalculateMonthlyPay()}円";

        //}

        public void GenerateReport()
        {
            Console.WriteLine("----- 給与明細 -----");
            Console.WriteLine($"名前：{Name}");
            Console.WriteLine($"雇用形態：{Type}");
            //Console.WriteLine($"勤務時間：{WorkedHours}時間");
            Console.WriteLine($"総支給額：{CalculateMonthlyPay()}円");
            Console.WriteLine("---------------------");
        }


        protected override void BeforeCalcHook()
        {
            Console.WriteLine("残業時間を確認します。");
            Console.WriteLine($"残業時間：{OvertimeHours}時間");
        }


        public override decimal CalculateMonthlyPay()
        { 
            var gross = BaseSalary;

            var tax = TaxStrategy?.CalcTax(gross) ?? 0;

            return gross - tax;
        }

        public void Pay()
        {
            Console.WriteLine($"{Name}さんに{Ipayable}円を振込");
        }

        
    }

}

public class FlatTaxStrategy : ITaxStrategy
{
    public decimal CalcTax(decimal gross) => gross * 0.10m;
}

public class ProgressiveTaxStrategy : ITaxStrategy
{
    public decimal CalcTax(decimal gross)
    {
        if (gross <= 200000)
            return gross * 0.05m;
        else
            return gross * 0.10m;
    }
}


