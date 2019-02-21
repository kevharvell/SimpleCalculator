using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double result;
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToDouble(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToDouble(Console.ReadLine());
                string operation = Console.ReadLine();

                result = calculatorEngine.Calculate(firstNumber, secondNumber, operation);

                Console.WriteLine(result);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
