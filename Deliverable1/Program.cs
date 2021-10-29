using System;

namespace Deliverable1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string again = "Y";

            while (again == "Y")
            {
                //user input for measurement type
                Console.Write("Oh you need to convert some units? Please provide the measurement type in Imperial (inch or foot) or MilHip (fidget spinner or meme). ");
                string type = Console.ReadLine();

                //user input for measurement amount
                Console.Write("Please provide the measurement amount. ");
                //convert string to double
                double amount = double.Parse(Console.ReadLine());


                if (type == "inch")
                {
                    //converting to fidget spinner
                    amount *= 3.5;
                    Console.WriteLine("Converts to " + amount + " fidget spinner(s).");
                }
                else if (type == "foot")
                {
                    //converting to meme
                    amount *= 5;
                    Console.WriteLine("Converts to " + amount + " meme(s).");
                }
                else if (type == "fidget spinner")
                {
                    //converting to inch
                    amount /= 3.5;
                    Console.WriteLine("Converts to " + amount + " inch(es).");
                }
                else if (type == "meme")
                {
                    //converting to foot
                    amount /= 5;
                    Console.WriteLine("Converts to " + amount + " foot(feet).");
                }
                else
                {
                    Console.WriteLine("You did not enter in a valid unit type.");
                }

                Console.Write("Wanna go again? (Y or N) ");
                again = Console.ReadLine();
                again = again.ToUpper();

            }
            Console.Write("Later!");
        }
    }
}