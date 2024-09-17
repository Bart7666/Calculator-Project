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
                char Input = Convert.ToChar(Console.ReadLine());
                if (!Char.IsDigit(Input))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    return Input;
                }
            } while (true);

        }

        static char ConverterOptions(string InOut)
        {
            do
            {
                Console.WriteLine($"What do you want to convert{InOut}: \n 1.Denary \n 2.Binary \n 3.Hexadecimal");
                char Choice = Convert.ToChar(Console.ReadLine());
                switch (Choice)
                {
                    case '1':
                        return '1';

                    case '2':
                        return '2';

                    case '3':
                        return '3';

                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            } while (true);


        }
        static int IntInputter()
        {
            int Temp;
            do
            {
                Console.WriteLine("Enter the Denary");
            } while (Int32.TryParse(Console.ReadLine(), out Temp));
            return Temp;
        }

        static string BinInputter()
        {
            do
            {
                Console.WriteLine("Enter the binary");
                string Output = Console.ReadLine();
                bool BinChecker = true;
                foreach (char Letter in Output)
                {
                    if (Letter != '0' || Letter != '1')
                    {
                        BinChecker = false;
                        break;
                    }
                }
                if (BinChecker)
                {
                    return Output;
                }
            } while (true);
        }
        static string HexInputter()
        {
            do
            {
                Console.WriteLine("Enter the Hex 0x");
                string Output = Console.ReadLine();
                bool HexChecker = true;
                foreach (char Letter in Output)
                {
                    if (!('0' <= Letter && Letter <= '9' || 'a' <= Letter && Letter <= 'f' || 'A' <= Letter && Letter <= 'F'))
                    {
                        HexChecker = false;
                        break;
                    }
                }
                if (HexChecker)
                {
                    return Output;
                }

            } while (true);
        }

        static void DenConverter()
        {
            int Denary = IntInputter();
            char Choice = ConverterOptions(" to");
            switch (Choice)
            {
                case '1':
                    Console.WriteLine($"{Denary} in Denary is {Denary}");
                    break;

                case '2':
                    break;

                case '3':
                    break;
            }
        }
        static void BinConverter()
        {
            string Bin = BinInputter();
            char Choice = ConverterOptions(" to");
            switch (Choice)
            {
                case '1':
                    Console.WriteLine($"{Bin} in Denary is {Convert.ToInt32(Bin, 2)}");
                    break;

                case '2':
                    Console.WriteLine($"0x{Bin} in Hex is 0x{Bin}");
                    break;

                case '3':
                    break;
            }
        }
        static void HexConverter()
        {
            string Hex = HexInputter();
            char Choice = ConverterOptions(" to");
            switch (Choice)
            {
                case '1':
                    Console.WriteLine($"{Hex} in Denary is {Convert.ToInt32(Hex,16)}");
                    break;

                case '2':
                    Console.WriteLine($"{Hex} in Binary is ");
                    break;

                case '3':
                    Console.WriteLine($"0x{Hex} in Hex is 0x{Hex}");
                    break;
            }
        }


        static void Converter()
        {
            char In = ConverterOptions(" from");
            switch (In)
            {
                case '1':
                    DenConverter();
                    break;

                case '2':
                    BinConverter();
                    break;

                case '3':
                    HexConverter();
                    break;
            }


        }


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
                        Converter();
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }

        }
    }
}
