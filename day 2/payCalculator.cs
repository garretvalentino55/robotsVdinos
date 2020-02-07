using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double standardWorkWeek = 40;
            double overtimeMultiplier = 1.5;
            Console.WriteLine("Please input yours Hours Worked");
            double hoursWorked = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input your Pay Rate");
            double payrate = double.Parse(Console.ReadLine());
            double totalPay;
            if(hoursWorked > 40)
            {
                double overtimehours = hoursWorked - standardWorkWeek;
                double overtimepayrate = payrate * overtimeMultiplier;
                double overtimetotalpay = overtimehours * overtimepayrate;
                double regularpay = payrate * standardWorkWeek;
                totalPay = overtimetotalpay + regularpay;


            }
            else
            {

                totalPay = hoursWorked * payrate;

            }
            Console.WriteLine("your total pay was " + totalPay);
            Console.ReadLine();


            for (int I = 0; I <= 101; I++)
            {
                if (I % 3 == 0 && I % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if (I % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else if (I % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.Write(I);

                }
                Console.ReadLine();
            }

            
        }
    }
}
