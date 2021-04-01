using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculator calc = new Calculator();

            calc.Add

            do
            {
                Console.Write("operation: ");
                char operation = Console.ReadLine()[0];

                Console.Write("a: ");
                String operandString1 = Console.ReadLine();
                int a = Convert.ToInt32(operandString1);

                Console.Write("b: ");
                String operandString2 = Console.ReadLine();
                int b = Convert.ToInt32(operandString2);

                

                int result;
                char operation;

                switch (operation)
                {
                    case '*':
                        result = calc.Multiplikation(a, b);
                        break;
                    case '+':
                        result = calc.Addition(a, b);
                        break;
                    case '-':
                        result = calc.Subtraktion(a, b);
                        break;
                    case '/':
                        result = calc.Division(a, b);
                        break;
                }

                Console.WriteLine($"{a} {operation} {b} = {result}");
            } while ();
        }
    }
}
