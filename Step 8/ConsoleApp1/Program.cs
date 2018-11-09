using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application will add two whole or decimal numbers and display their sum.");
            Console.WriteLine("Please enter the first whole or decimal number. ");
            string input = Console.ReadLine();


            Console.WriteLine("Please enter the second whole or decimal number. ");
            string input2 = Console.ReadLine();

            try
            {
                var num1 = Convert.ToInt32(input); //Check input for doubles
                var num2 = Convert.ToInt32(input2); //This avoids some errors
                getSum(num1, num2);

            }
            catch
            {
                var num1 = Convert.ToDouble(input); //Check input for doubles
                var num2 = Convert.ToDouble(input2); //This avoids some errors
                getSum(num1, num2);
            }

            //This keeps the console open until the user presses Enter to close           
            Console.WriteLine("Press Enter to close...");
            Console.ReadLine();
        }

        public static void getSum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("8 + 2 = {0}", result);
        }

        public static void getSum(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("7.4 + 2.6 = {0}", result);
        }

    }
}