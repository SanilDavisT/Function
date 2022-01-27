using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, sum ,sub;
            Console.WriteLine("Enter Fist Number");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            num3=Convert.ToInt32(Console.ReadLine());
            
            Findlargestnumber obj = new Findlargestnumber();
            obj.largest(num1,num2,num3);  // WIth parameter without return ; Find Largest Number
            
            oddoreven obj1 = new oddoreven();
            obj1.oddeven(); //Without Parameter Without Retrun;Find Odd or Even Number
           
            Tottal obj2 =new Tottal();
            sum = obj2.findtottal(num1, num2);  // With Parameter With Retrun;Find Total
            Console.WriteLine("Sum of First number is {0}" ,sum);
            Console.ReadKey();
              
            Sutract obj3 = new Sutract();
            sub = obj3.subtraction();  // Withot Parameter With Retrun ; Subtraction of two numbers
            Console.WriteLine("Subtraction of two numbers is {0}" ,sub);
            Console.ReadKey();






        }
    }
}
