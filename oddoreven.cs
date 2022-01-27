using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class oddoreven
    {
        public void oddeven()
        {
            int a;
            Console.WriteLine("Enter a Value");
            a=Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("{0} is an Even number" ,a);
            }
            else
            {
                Console.WriteLine("{0} is an Odd number", a);
            }
            Console.ReadKey();

        }

    }
}
