// Code tiré de https://www.tutorialspoint.com/csharp/csharp_exception_handling.htm
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Exception
{


    class Program
    {
        class DivNumbers
        {
            int result;

            public DivNumbers()
            {
                result = 0;
            }
            public void division(int num1, int num2)
            {
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }
                finally
                {
                    Console.WriteLine("Result: {0}", result);
                }
                
            }
        }

        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(25,5);
            Console.ReadKey();
        }
    }

}