using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; //Default value is "not-a-number" if an operation, such as division, could result in an error.

            //use a switch statement to do maths
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    //Ask the user to not be a complete dickhead
                    if (num2 !=0)
                    {
                        result = num1 / num2;
                    }
                    break;
                //return text for dickhead behavior
                default:
                    break;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
   
            ////Declare variables and then initialize to zero
            //double num1 = 0;
            //double num2 = 0;

            //Display the title as the C# console calculator app
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("-------------------------\n");

            while (!endApp)
            {
                //declare variables and set empty
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                //ask user to type a number
                Console.Write("Type a number, and then press enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Ayo, dickhead, try a better number.");
                    numInput1 = Console.ReadLine();
                }

                //Ask user to type another number
                Console.Write("Type a number, and then press enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Ayo, dickhead, try a better number.");
                    numInput2 = Console.ReadLine();
                }

                //ask user to choose an operator
                Console.WriteLine("Choose an operation from the following list: ");
                Console.WriteLine("\ta - add");
                Console.WriteLine("\ts - subtract");
                Console.WriteLine("\tm - multiply");
                Console.WriteLine("\td - divide");
                Console.Write("Whatchu want? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Hey dick for brains, this is your official error message for being a dick");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh noez! We made an uwu fucky wucky!");
                }

                Console.WriteLine("------------------------------\n");

                //Wait for user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); //"Friendly" linespacing
            }
            return;

            ////Ask the user to type the first number
            //Console.WriteLine("Type a number, then press enter");
            //num1 = Convert.ToDouble(Console.ReadLine());

            ////Ask the user to type the second number
            //Console.WriteLine("Type another number, cheif");
            //num2 = Convert.ToDouble(Console.ReadLine());

            ////Ask the user to choose an option
            //Console.WriteLine("Choose an option from the following listicle:");
            //Console.WriteLine("\ta - ADD");
            //Console.WriteLine("\ts - SUBTRACT");
            //Console.WriteLine("\tm - MULTIPLY");
            //Console.WriteLine("\td - DIVIDE");
            //Console.WriteLine("Whachu want king? ");

            ////Switch case to do maths
            //switch (Console.ReadLine())
            //{
            //    case "a":
            //        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            //        break;
            //    case "s":
            //        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            //        break;
            //    case "m":
            //        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            //        break;
            //    case "d":
            //        //Ask the user to not be a total dick
            //        while (num2 == 0)
            //        {
            //            Console.WriteLine("Enter something other than 0: ");
            //            num2 = Convert.ToDouble(Console.ReadLine());
            //        }
            //        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            //        break;
            //}
            ////Wait for user to respond before closing
            //Console.Write("Dab on one of these keys to close me");
            //Console.ReadKey();
        }
    }
}
