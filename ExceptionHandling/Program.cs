using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Divide(3, 0);
            }
            /*
            catch (DivideByZeroException ex)
            {
                DisplayExceptionMessage(ex);
            }
            */
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int Divide(int dividend, int divisor)
        {
            return dividend / divisor;
        }

        static void DisplayExceptionMessage(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
