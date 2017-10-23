using System;
using System.Collections;

namespace week04
{
    class Program
    {
        static void Main(string[] args)
        {
            findPrime();
            findFibonacci();
        }
        private static void findPrime(){
            Console.WriteLine("Enter a number between 1 and 100 to find prime numbers");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 100 || number < 0) {
                string errorMessage = "This program only accept numbers between 1 and 100. You entered: {0}";
                Console.WriteLine(string.Format(errorMessage, number));
            } else {
                for (int i = 1; i <= number; i++) {
                    if (number % i == 0 && i != number && i != 1) {
                        Console.Clear();
                        string resultMessage = "{0} is not a prime number";
                        Console.WriteLine(resultMessage, number);
                        break;
                    } else {
                        if (i == number) {
                            Console.Clear();
                            string resultMessage = "{0} is a prime number";
                            Console.WriteLine(resultMessage, number);
                        }
                    };
                }
            }
        }
        private static void findFibonacci(){
            int i = 0;
            int j = 1;
            Console.WriteLine("Fibonacci:");
            Console.WriteLine("=================================");
            Console.WriteLine(i);
            Console.WriteLine(j);
            for (int k = 0; k < 5; k++){
                i = i + j;
                Console.WriteLine(i);
                j = i + j;
                Console.WriteLine(j);
            }
        }
    }
}
