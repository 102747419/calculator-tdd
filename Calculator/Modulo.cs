using System;

namespace Calculator
{
	public class Modulo : Operator
	{
		public override decimal Calculate(decimal first, decimal second)
		{
			if (second == 0)
			{
				return first;
			}
			return first % second;
		}
	}
}