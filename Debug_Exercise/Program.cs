using System;


namespace Q1
{

    class Program
    {

        static void Main(string[] args)

        {

            Test mytest = new Test(0);

            mytest.AddEight();

            mytest.Display();

        }
    }

    public class Test
    {
        private int tally;
        public Test(int tally)
        {
            this.tally = tally;
        }

        public void AddEight()
        {
            tally += 8;
        }

        public void Display()
        {
            Console.WriteLine("tally is {0}", tally);
        }
    }
}