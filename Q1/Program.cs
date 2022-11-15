using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (sum < 105)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("1 + 2 + 3 + ..... + N < 105");
            Console.WriteLine("=> N = " + (i - 2));
        }
    }
}
