using ConsoleAppAdapter.Interfaces;
using System;

namespace ConsoleAppAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDecimalToIntStringService service = new DecimalTotalToIntStringFormat();
            IDecimalFromStringAdapter adapter = new IntegerPart(service);
            double total = 123456.7890;

            Console.WriteLine("El valor entero de {0} es : {1}", total, adapter.ObtainIntegerPart(total));
        }
    }
}
