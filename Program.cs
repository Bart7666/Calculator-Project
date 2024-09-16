using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_project
{
    internal class Program
    {
        /*
        static double Value(string Order)
        {
            Console.WriteLine($"Enter the {Order} number ");
            
            string Temp = Console.ReadLine();

            return Num;
        }
        */
        static char Options()
        {
            Console.WriteLine("What operation would you like to do ? (Enter the number)");
            Console.WriteLine(" 1.Add");
            Console.WriteLine(" 2.Subtract");
            Console.WriteLine(" 3.Multiply");
            Console.WriteLine(" 4.Divide");
            char Input = Convert.ToChar(Console.Read());
            return Input;
        }
        static void Main(string[] args)
        {
            int Continue = 0;
            while (Continue == 0)
            {
                char Case = Options();
                // Inputs The first and second operand as Num1 and Num2
                double Num1 = Value("first");
                double Num2 = Value("second");
                switch (Case)
                {
                    case '1':
                        Console.WriteLine(Convert.ToString(Num1 + Num2));
                        break;
                    case '2':
                        Console.WriteLine(Convert.ToString(Num1 - Num2));
                        break;
                    case '3':
                        Console.WriteLine(Convert.ToString(Num1 * Num2));
                        break;
                    case '4':
                        Console.WriteLine(Convert.ToString(Num1 / Num2));
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }

        }
    }
}
