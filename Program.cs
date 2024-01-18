using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter value to perform an action");
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtarction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");
            int action = Convert.ToInt32(ReadLine());
            Console.WriteLine("Enter 1st input: ");
            int input_1 = Convert.ToInt32(Readline());
            Console.WriteLine("Enter 2nd input: ");
            int input_2 = Convert.ToInt32(ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:{
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("Invalid action; try again!");
            }
            Console.WriteLine("The result of {0}",result);
            Console.ReadKey();
        }
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 / input_2;
            return result;
        }
    }
}