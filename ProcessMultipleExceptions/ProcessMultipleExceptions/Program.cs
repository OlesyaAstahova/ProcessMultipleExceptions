using System;
using System.IO;
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
            myCar.CrankTunes(true);
            myCar.CurrentSpeed = 0;
            try
            {
                //Arg вызовет исключение выхода за пределы диапазона
                myCar.Accelerate(10);
            }
           
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Этот код будет выполняться всегда, возникало исключение или нет
                myCar.CrankTunes(false);
            }

            Console.ReadLine();
        }
    }
}
