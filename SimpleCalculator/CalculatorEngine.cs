using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(double argFirstNumber, double argSecondNumber, string argOperation)
        {
            double result;

            argOperation = argOperation.ToLower();

            switch(argOperation)
            {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Invalid operation entered.");
            }

            return result;
        }
    }
}
