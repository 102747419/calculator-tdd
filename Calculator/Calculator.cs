using System;

namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {

        }

        public void Calculate()
        {
            double first = AskForNumber("First number: ");
            string op = AskForOperator("Operator: ");
            double second = AskForNumber("Second number: ");

            double result = Operator.Calculate(first, op, second);
            Console.WriteLine($"Result: {first} {op} {second} = {result}");
        }

        private double AskForNumber(string prompt)
        {
            double value;
            bool valid;

            do
            {
                Console.Write(prompt);
                valid = double.TryParse(Console.ReadLine().Trim(), out value);
                if (!valid)
                {
                    Console.WriteLine("Invalid number");
                }
            } while (!valid);

            return value;
        }

        private string AskForOperator(string prompt)
        {
            string op;

            do
            {
                Console.Write(prompt);
                op = Console.ReadLine().Trim();
                if (!Operator.OperatorExists(op))
                {
                    Console.WriteLine("Invalid operator");
                }
            } while (!Operator.OperatorExists(op));

            return op;
        }
    }
}
