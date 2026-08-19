using System;
using System.Collections.Generic;
using System.Text;

namespace _2026_0721
{
    class PartTimeEmployee : Employee, IReportable
    {
        public decimal HourlyWage { get; set; }

        public decimal WorkedHours { get; set; }

        public override decimal CalculateMonthlyPay()
        {
            return HourlyWage * WorkedHours;
        }

        public string GenerateReport()
        {
            return $" 名前：{Name}、雇用形態：{Type}、総支給額：{CalculateMonthlyPay()}円";
        }

    }
}
