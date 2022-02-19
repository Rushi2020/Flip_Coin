// Loop through multiple times flipping a coin and show count

using System;

namespace flipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("flip coin simulator");

            FlipCoin();

        }
        public static int FlipCoin()
        {
            //constant
            const int HEAD = 0;
            const int TAIL = 1;

            //initilization and declaration
            int headCount = 0;
            int tailCount = 0;
            int i = 0;



            while (i <= 21)
            {

                Random random = new Random();
                int flipResult = random.Next(0, 2);
                if (flipResult == HEAD)
                {
                    headCount++;

                }
                else if (flipResult == TAIL)
                {
                    tailCount++;


                }
                i++;
            }
            Console.WriteLine($"Head {headCount}");

            Console.WriteLine($"Tail {tailCount}");


            return 0;
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))  
                Console.WriteLine("{0} is a Leap Year.", Year);
            else Console.WriteLine("{0} is not a Leap Year.", Year);
            Console.ReadLine();
        }
    }
}