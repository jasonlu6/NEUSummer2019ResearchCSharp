/* 
 * Tutorial for Variables and Functions for #C Unity coding. 
 * Bsaic arithmetic operations in #C Unity coding. 
 * Author: Jason Lu (lu.jaso@husky.neu.edu)
 * Date: 5.02.2019 - 5.05.2019
 * Training Module #3 For NEU Summer Research 2019 
 */


using System;
namespace Application
{
    public static class VariablesAndFunctions
    {

        /* Function that multiplies a number by 2 */
        static int MultiplyByTwo(int number)
        {
            int ret;
            ret = 2 * number;
            return ret;
        }

        /* Function that divides a number by 2 */
        static int DivideByTwo(int number)
        {
            int ret;
            ret = number / 2;
            return ret;
        }

        /* Function that adds a number by 2 */
        static int AddByTwo(int number)
        {
            int ret;
            ret = 2 + number;
            return ret;
        }

        /* Function that multiplies a number by 2 */
        static int SubtractByTwo(int number)
        {
            int ret;
            ret = number - 2;
            return ret;
        }

        static void Main(string[] args)
        {
            /* Functions to test arithmetic operations. Hardcode for static 
             * variable reasons.          
            */

            System.Console.WriteLine(MultiplyByTwo(5));
            System.Console.ReadKey();
            Console.WriteLine("Test 1: Multiplication.");
            Environment.Exit(0);

            System.Console.WriteLine(DivideByTwo(5));
            System.Console.ReadKey();
            Console.WriteLine("Test 2: Division.");
            Environment.Exit(0);         

            System.Console.WriteLine(AddByTwo(5));
            System.Console.ReadKey();
            Console.WriteLine("Test 3: Addition.");
            Environment.Exit(0);

            System.Console.WriteLine(SubtractByTwo(1));
            System.Console.ReadKey();
            Console.WriteLine("Test 4: Subtraction.");
            Environment.Exit(0);

            Console.WriteLine("Arithmetics Completed.");
        }
    }
}
