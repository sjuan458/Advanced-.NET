using System;
using System.Collections.Generic;

delegate void myDelegate();

namespace MyTestingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> result = GetAllNumbersLessThanFive(
                new[] { 2, 7, 3, 9, 5, 7, 1, 8 });
            foreach (int n in result)
                Console.WriteLine(n);
            Console.ReadKey();
        }

        static IEnumerable<int> GetAllNumbersLessThanFive(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
                if (number < 5)
                    yield return number;
        }
    }
}
