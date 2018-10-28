using System;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0; float num2 = 0; 

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Type a number, and then press Enter");
            num1 = float.Parse(Console.ReadLine());     //used float.Parse to transform user input(string) to float (step10)

            Console.WriteLine("Type another number, and then press Enter");
            num2 = float.Parse(Console.ReadLine());  

            while ((num1 > 100 | num1 < -100) | (num2 > 100 | num2 < -100))  //testing whether the input is in range -100,100 (step9-10)
            {
                Console.WriteLine("Both numbers need to be in range -100, +100. Type a number and then press Enter");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Type another number, and then press Enter");
                num2 = float.Parse(Console.ReadLine());
            }

            /*while (num1 < 0 | num2 < 0)  //testing if the number is negative (step7)
            {
                Console.WriteLine("Both numbers need to be greater than zero. Type a number and then press Enter");
                num1 = Convert.ToInt32(Console.ReadLine());     //used Convert.ToInt32 to convert the string the user inputs to int
                Console.WriteLine("Type another number, and then press Enter");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            
            while ((num1 < 0 | num1 > 100) | (num2 < 0 | num2 > 100))  //testing if the number is negative or greater than 100 (step8)
            {
                Console.WriteLine("Both numbers need to be greater than zero and less than 100. Type a number and then press Enter");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type another number, and then press Enter");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            */

            // Ask the user to choose an option
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Use a switch statement to do the math
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2)); // Line 32
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor until they do so
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToInt16(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                // Return text for an incorrect option entry
                default:
                    Console.WriteLine("That is an incorrect option entry, please try again.");
                    break;
            }
            //Wait for the user to respond before closing
            Console.Write("Press any key to close the Calculator console app...\r\n");
            Console.ReadKey();

            //The rest of the program consists of the BONUS part and calls the classes Bonus1-4 to operate. 
            Console.WriteLine("\r\nDo you want to continue to the BONUS part of MyCalculator? Press Enter! \r\nIf you are satisfied with the basic version press Escape to end the program...");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Bonus2 myBonus2 = new Bonus2();
                myBonus2.Calculator();

                Bonus3 myBonus3 = new Bonus3();
                myBonus3.Calculator();

                Bonus4 myBonus4 = new Bonus4();
                myBonus4.Calculator();

                Bonus1 myBonus1 = new Bonus1();
                myBonus1.Calculator();
            }
            else
            {
                Console.WriteLine("Thanks for using MyCalculator!");
                Console.ReadKey();
            }
        }
    }
}
