using System;

namespace Program1
{
    class PrimeNumbers
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime numbers between 2 and " + n + ": ");
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                    Console.Write(i + " "); 
            }
            Console.ReadLine();
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false; // checks to see if it is less than or equal to 1 and if its then it is false
            if (number == 2) return true; // checks to see if the input is equal to 2 and if it is then it is returned as the only prime number
            if (number % 2 == 0) return false; // checks to see if the input is divisable by 2

            var boundary = (int)Math.Floor(Math.Sqrt(number)); 

            for (int i = 3; i <= boundary; i += 2) // 
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
