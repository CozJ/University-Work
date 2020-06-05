using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calclulator
{
    class Display
    {
        private string calculation;

        public void updateDisplay(string newCalculation)
        {
            calculation = newCalculation;
        }

        public void clearDisplay()
        {
            calculation = "";
        }

        public void undo()
        {
            if (calculation.Length > 0)
            {
                calculation = calculation.Remove(calculation.Length - 1);
            }
        }

        public string getDisplay()
        {
            return (calculation);
        }
    }
}
