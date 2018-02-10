using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            myCar.CurrentSpeed = 0;
            try
            {
                //Arg вызовет исключение выхода за пределы диапазона
                myCar.Accelerate(160);
            }
           
            catch
            {
                Console.WriteLine("Something bad happened...");
            }
             
            
            Console.ReadLine();
        }
    }
}
