using ConsoleAppAdapter.Interfaces;

namespace ConsoleAppAdapter
{
    public class IntegerPart : IDecimalFromStringAdapter
    {

        private readonly IDecimalToIntStringService _adaptee;

        public IntegerPart(IDecimalToIntStringService adaptee)
        {
            _adaptee = adaptee;
        }

        public double ObtainIntegerPart(double total)
        {

            double.TryParse(_adaptee.DecimalIntConvert(total), out double doubleTotal);
            return doubleTotal;
        }
        
    }
}
