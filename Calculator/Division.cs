using System;
namespace Calculator
{
    public class Division : Operator
    {
        public override decimal Calculate(decimal first, decimal second)
        {
            return first / second;
        }
    }
}
