using System;

namespace ExceptionHandlingFromOutsideMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1);

            try
            {
                int answer = Test(0);
                Console.WriteLine(3);           //if argument is 0, this line won't be executed, but catch will
                Console.WriteLine(answer);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(4);
                Console.WriteLine(e.Message);           //display the exception message
            }
            
        }

        static int Test(int number)
        {
            Console.WriteLine(2);
            int answer = 100 / number;          //Exception created, will return to called method

            return answer;
        }
    }
}
