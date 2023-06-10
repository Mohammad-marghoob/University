using System;

namespace HelloWorld
{
    class Program
    {
        static int Fibo(int input)
        {
            if (input <= 2)
            {
                return 1;
            }
            else
            {
                int sum = 0;

                for (int i=2; i < input; i++)
                {
                    sum = Fibo(input - 1) + Fibo(input - 2);
                }
                return sum;
            }
        }

        static void Main(string[] args)
        {
            int num , result;
            Console.WriteLine("please enter a number");
            string input = Console.ReadLine();
            num = int.Parse(input);
            result = Fibo(num);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}