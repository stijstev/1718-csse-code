using System;
using System.Collections; //required for hashtable

namespace opdracht_week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to multiply");
            int tafel = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string[] resultsArray = new string[11]; //creating an array for results
            Hashtable resultsHashtable = new Hashtable(); //creating a hashtable for results
            Console.Clear();
            Console.WriteLine("Results:");
            Console.WriteLine("========================================");
            for (int i = 0; i <= 10; i++){
                int result = tafel * i;
                string resultDisplay = i + "x" + tafel + "=" + result;
                Console.WriteLine(resultDisplay);
                resultsArray[i] = resultDisplay; 
                resultsHashtable[i] = resultDisplay;
            }

            Console.WriteLine("Results displayed from array:");
            Console.WriteLine("========================================");
            foreach (string n in resultsArray)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Results displayed from hashtable:");
            Console.WriteLine("========================================");
            foreach (DictionaryEntry entry in resultsHashtable)
            {
                Console.WriteLine(entry.Value);
            }
        }
    }
}
