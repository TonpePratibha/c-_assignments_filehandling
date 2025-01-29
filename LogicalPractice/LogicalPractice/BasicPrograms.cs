using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPractice
{
    internal class BasicPrograms
    {
        public int add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public bool isEven(int num)
        {

            var result = num % 2 == 0;

            if (result)
            {
                Console.WriteLine("num is even");
                return true;
            }
            return false;

        }
    }
}
