using System;
namespace CounterTask
{
    public class Program
    {
        private static void PrintCounters(Counter[] counters)
        {
            foreach (Counter c in counters)
            {
                Console.WriteLine("{0}: {1}", c.Name, c.Ticks);
            }
        }
        static void Main(string[] args)
        {
            Counter[] myCounters = new Counter[3];

            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0];
            
            int i;

            for (i = 0; i <= 9; i++)
            {
                myCounters[0].Increment();
            }
            for (i = 0; i <= 14; i++) 
            {
                myCounters[1].Increment();
            }
            PrintCounters(myCounters);

            myCounters[2].Reset();
            PrintCounters(myCounters);
        
    
    FizzBuzz(args);
    }
    static void FizzBuzz(string[] args)
    {

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}       
}

