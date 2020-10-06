using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Exception
{
    class ExceptionTest
    {
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }
        static void Main()
        {
            // Input for test purposes. Change the values to see
            // exception handling behavior.
            double a = 98, b = 5;
            double result = 0;
            double result1 = 0;

           

            try
            {
                result = SafeDivision(a, b);//tenemos posible exception
                result1 = a / b;

                result1 = (double)98 / 0;
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result1);
                /*
                 ofjsakdlfmasdf
                 sdf
                 asdf
                 asdf
                 sdf
                 */
            }
            catch (DivideByZeroException e)
            {
               //Console.WriteLine("Attempted divide by zero.");

                Console.WriteLine("Detalle de la exception: "+e.Message);
                Console.WriteLine("Fuente de exception:\n"+e.Source);
                Console.WriteLine("Pila\n"+e.StackTrace);
                Console.WriteLine("Objetivo de la exception:\n"+e.TargetSite);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.HResult);
                Console.WriteLine(e.HelpLink);
            }
            finally//opcional
            {
                Console.WriteLine("Ejecución de Finally");
            }

            Console.ReadLine();
        }
    }
}
