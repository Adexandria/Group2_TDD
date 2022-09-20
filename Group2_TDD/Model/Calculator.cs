using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_TDD.Model
{
    public class Calculator
    {
        public int AddNumber(int a, int b)
        {
            return a + b;
        }

        public int SubstractNumber(int a, int b)
        {
            return a - b;
        }
        public int MultiplyNumber(int a, int b)
        {
            return a * b;
        }

        public int DivideNumber(int a, int b)
        {
            return a / b;
           
        }
       
    }
}
