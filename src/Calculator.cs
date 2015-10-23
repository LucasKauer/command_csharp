using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_csharp
{
    public class Calculator
    {
        private int _currentValue = 0;

        public void ExecuteOperation(char operator_, int value)
        {
            var oldValue = _currentValue;

            switch (operator_)
            {
                case '+': _currentValue += value; break;
                case '-': _currentValue -= value; break;
                case '*': _currentValue *= value; break;
                case '/': _currentValue /= value; break;
            }
            Console.WriteLine("{0} {1} {2} = {3}", oldValue, operator_, value, _currentValue);
        }
    }
}
