using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class Sutract
    {
        public int subtraction()
        {
            int a,b,c;
            Console.WriteLine("Enter a number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            b=Convert.ToInt32(Console.ReadLine());
            c = a - b;
            return c;
        }

    }
}
