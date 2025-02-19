using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Calculator
    {
        public float a;
        public float b;
        public float result;

        public Calculator(){}
        public Calculator(float n,float m) {
            a = n;
            b = m;
        }
        public float add()
        {
            result = a + b;
            return result;
        }
        public float subtract()
        {
            result = a - b;
            return result;
        }
        public float multiply()
        {
            result = a * b;
            return result;
        }
        public float divide()
        {
            result = a / b;
            return result;
        }

    }
}
