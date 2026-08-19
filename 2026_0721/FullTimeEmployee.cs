using System;
using System.Collections.Generic;
using System.Text;

namespace _2026_0721
{
    class FullTimeEmployee : Employee , IOvertimeEligible , IReportable
    {

        public int OvertimeHours { get; set; }

        public decimal BaseSalary { get; set; }

        public override decimal CalculateMonthlyPay()
        {
            return BaseSalary + OvertimeHours * (BaseSalary / 160m) * 1.25m;
        }
        public int GetOvertimeHours()
        {
            return OvertimeHours;
        }

        public void AddOvertimeHours(int hours)
        {
            OvertimeHours += hours;
        }

        public string GenerateReport()
        {

            return $"名前：{Name}、雇用形態：{Type}、残業時間：{OvertimeHours}時間、残業代：{OvertimeHours * (BaseSalary / 160m) * 1.25m}円、総支給額：{CalculateMonthlyPay() - ITaxStrategy}円";

        }

        protected override void BeforeCalcHook()
        {
            Console.WriteLine("残業時間を確認します。");
            Console.WriteLine($"残業時間：{OvertimeHours}時間");
        }
    }

    
}
