using System;
using System.Collections.Generic;
using System.Text;

namespace _2026_0721
{
    public interface ITaxStrategy
    {
        decimal CalcTax(decimal gross);
    }
}
