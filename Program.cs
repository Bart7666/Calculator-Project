using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_project
{
    internal class Program
    {
        static double UserInput(string Order)
        {
            do
            {
                Console.WriteLine($"Enter the {Order} number ");
                string Temp= Console.ReadLine();
                if (Double.TryParse(Temp, out double Num))
                {
                    return Num;
                }
                else
                {               
                    Console.WriteLine("Incorrect format for entry");
                }
            } while (true);


        }
        static string Rooting(double Root)
        {
            if (Root == 2)
            {
                return "square";
            }
            else if (Root == 3)
            {
                return "cubic";
            }
            else
            {
                return Convert.ToString(Root);
            }
        }

        static char Options()
        {
            Console.WriteLine("What operation would you like to do ? (Enter the number)");
            Console.WriteLine("0.Exit");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine("5.Exponentiate");
            Console.WriteLine("6.Root");
            Console.WriteLine("7.Logarithim");
            Console.WriteLine("8.Round");
            Console.WriteLine("9.Convert");

            do
            {
                char Input = Convert.ToChar(Console.Read());
                if (Input < 0 || Input > 10)
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    return Input;
                }
            } while (true);

        }

        static string ConverterOptions(string InOut)
        {
            do
            {
                Console.WriteLine($"What do you want to convert{InOut}: \n 1.Denary \n 2.Binary \n 3.Hexadecimal");
                char Choice = Convert.ToChar(Console.ReadLine());
                switch (Choice)
                {
                    case '1':
                        int Temp;
                        do
                        {
                            Console.WriteLine("Enter the Denary");
                        } while (Int32.TryParse(Console.ReadLine(), out Temp));
                        return Convert.ToString(Temp);
                    case '2':
                        do
                        {
                            Console.WriteLine("Enter the 8 bit binary");
                            string Output = Console.ReadLine();
                            bool Checker = true;
                            foreach (char Letter in Output)
                            {
                                if (Letter != 0 || Letter != 1)
                                {
                                    Checker = false;
                                    break;
                                }
                            }
                            if (Checker)
                            {
                                return Output;
                            }
                        } while (true);
                    case '3':
                        //Do hex


                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            } while (true);


        }
        /*
        static string Converter()
        {
            string In = ConverterOptions(" from");
            string Out = ConverterOptions(" into");
            
            return Converted;
        }
        */
        static void Main(string[] args)
        {
            int Continue = 0;
            while (Continue == 0)
            {
                char Case = Options();
                // Inputs The first and second operand as Num1 and Num2
                double Num1 = UserInput("first");
                double Num2 = UserInput("second");
                switch (Case)
                {
                    case '0':
                        Continue = 1;
                        break;
                    case '1':
                        Console.WriteLine("The Sum of these two numbers is: " + Convert.ToString(Num1 + Num2));
                        break;
                    case '2':
                        Console.WriteLine($"The difference of these two numbers is: " + Convert.ToString(Num1 - Num2));
                        break;
                    case '3':
                        Console.WriteLine($"The product of these two numbers is: " + Convert.ToString(Num1 * Num2));
                        break;
                    case '4':
                        Console.WriteLine($"The quotient of these two numbers is: " + Convert.ToString(Num1 / Num2));
                        break;
                    case '5':
                        Console.WriteLine($"The result of {Num1} raised to the power of {Num2} numbers is: " + Convert.ToString(Math.Pow(Num1,Num2)));
                        break;
                    case '6':
                        Console.WriteLine($"The result of the {Rooting(Num2)} root of {Num1} " + Convert.ToString(Math.Pow(Num1,1/Num2)));
                        break;
                    case '7':
                        Console.WriteLine($"The log base {Num2} of {Num1} is {Math.Log(Num1, Num2)}");
                        break;
                    case '8':
                        Console.WriteLine($"{Num1} rounded to {Num2} decimal places is {Math.Round(Num1,(int)Num2)}");
                        break;
                    case '9':

                        break;


                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }

        }
    }
}
