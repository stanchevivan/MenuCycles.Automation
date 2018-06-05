using System;
namespace MenuCycle.Tests
{
    public static class CommonHerlpers
    {
        public static string GetRandomValueExcluding(string previousValue)
        {
            Random rnd = new Random();
            string randomNumber;

            int counter = 0;

            do
            {
                randomNumber = rnd.Next(1, 101).ToString();

                if (randomNumber != previousValue)
                {
                    return randomNumber;
                }
                counter++;
            }
            while (counter < 100);

            throw new Exception("Sorry, you are very unlucky. Terminating endless loop!");
        }
    }
}