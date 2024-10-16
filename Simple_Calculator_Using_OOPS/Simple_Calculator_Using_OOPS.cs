using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator_Using_OOPS
{
    internal class Simple_Calculator_Using_OOPS
    {
        static void Main(string[] args)
        {
            Calculator_Operations operation1 = new Calculator_Operations()
            {
                Operator1 = 5,
                Operator2 = 6,
            };

            operation1.Add();
            operation1.Subtract();
            operation1.Multiply();
            operation1.Division();
        }
    }
}
