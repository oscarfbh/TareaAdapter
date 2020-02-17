using ConsoleAppAdapter.Interfaces;
using System;

namespace ConsoleAppAdapter
{
    public class DecimalTotalToIntStringFormat : IDecimalToIntStringService
    {
        public string DecimalIntConvert(double value)
        {
            int integerValue = (int) Math.Truncate(value);

            return integerValue.ToString();
        }
    }
}
