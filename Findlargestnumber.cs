using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class Findlargestnumber
    {
        public void largest(int num1,int num2 , int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The largest number  is {0}" ,num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The Largest number is {0}" ,num2);
            }
            else
            {
                Console.WriteLine("The Largest number is {0}", num3);
            }
            Console.ReadKey();
        }
    }
}
