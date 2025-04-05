namespace RandomPicks
{
    class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            int randomNumber = random.Next(1, 101);


            Console.WriteLine("Pick a number between 1 and 100");
            string number = Console.ReadLine();

            Console.WriteLine("\n Random number is: " + randomNumber);

            if (randomNumber > Convert.ToInt32(number))
            {
                Console.WriteLine("Number is low");
            }
            if (randomNumber < int.Parse(number))
            {
                Console.WriteLine("Number is high");
            }

            if (int.TryParse(number, out int numberToInt) && randomNumber == numberToInt)
            {
                Console.WriteLine("Nice one! You got the number correctly");
            }


            /* else
             {
                 Console.WriteLine("Try again");
             } */


            /*if (numberInt < randomNumber)
            {
                Console.WriteLine("Number is low");
            }
            if (numberInt == numberInt)
            {
                Console.WriteLine("Nice one! You got the number correctly");
            }
             */
        }
    }
}

