using System;
using System.IO.Pipes;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Successfully executed");

            try
            {
                int number = 0;
                int answer = 5 / number;                // Exception, so catch will be executed
                Console.WriteLine(answer);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);           // Message property of object e
            }

            Console.WriteLine("Successfully executed");
        }
    }
}
