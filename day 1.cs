using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CSharpExcercises
    {
        // member varibles 
        public int hoursworkedbase;
        public int hoursworkedovertime;
        public double payratebase;
        public double payrateovertime;
        public double totalpay;




        // constuctor
        public CSharpExcercises(int hoursworkedbase, int hoursworkedovertime, double payratebase, double payrateovertime, double totalpay) 
        {
            this.hoursworkedbase = hoursworkedbase;
            this.hoursworkedovertime = hoursworkedovertime;
            this.payratebase = payratebase;
            this.payrateovertime = payrateovertime;
            this.totalpay = totalpay;
        }



        // member methods 
        public int RunPayCalculator(int hoursworkedbase, int hoursworkedovertime, double payratebase, double payrateovertime, double totalpay) 
        {
            if (hoursworkedbase > 40)
            {
                double totalpaybase = hoursworkedbase * payratebase;
                Console.WriteLine(payratebase);


            }
            else if (hoursworkedbase<40)
            {
                double toatalpay = hoursworkedovertime * payrateovertime;
                Console.WriteLine(totalpay);
            }
            else
            {
              Console.WriteLine("Error");
                
            }
        }


    }
}
