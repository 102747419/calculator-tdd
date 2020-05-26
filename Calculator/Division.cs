using System;
namespace Calculator
{
    public class Division : Operator
    {
        public override decimal Calculate(decimal first, decimal second)
        {
            if (second == 0)
            {
                return 0;
            }
            return first / second;
        }
    }
}
