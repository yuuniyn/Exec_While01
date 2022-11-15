using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            const int number = 300;
            int i = 1;

            while (i <= number)
            {
                if (number % i == 0)
                    sb.Append(i + ", ");
                i++;
            }

            Console.WriteLine(sb.ToString().Substring(0, sb.ToString().Length - 2));
        }
    }
}
