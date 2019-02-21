using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToDouble(string argTextInput)
        {
            double output;
            if (!double.TryParse(argTextInput, out output)) throw new ArgumentException("Invalid non-number input entered.");
            return output;
        }
    }
}
