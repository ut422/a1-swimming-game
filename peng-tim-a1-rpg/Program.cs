namespace peng_tim_a1_rpg
{
    using System;

    class Program
    {
        static void Main()
        {
            // what's happening

            Console.WriteLine("you're at a swim meet and you're trying to get at least 2nd place.");

            // choices

            Console.WriteLine("how 2 swim:");
            Console.WriteLine("1. freestyle");
            Console.WriteLine("2. breaststroke");
            Console.WriteLine("3. drown (why)");

            string swimmingStyle = Console.ReadLine();

                // 1st choice

            if (swimmingStyle == "1")
            {
                Console.WriteLine("you choose freestyle. hey, at least you're not drowning...");


                // 1st choice outcome

                Console.WriteLine("you didn't finish below 2nd, so yay?");
            }

                // 2nd choice

            else if (swimmingStyle == "2")
            {
                Console.WriteLine("you choose breaststroke. at least you're still not drowning...");

                // 2nd choice outcome

                Console.WriteLine("so close, yet so far... (you finished second last)");
            }

                // 3rd choice

            else if (swimmingStyle == "3")
            {
                Console.WriteLine("you have drowned");

                // 3rd choice outcome

                Console.WriteLine(":skull emoji:");
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
