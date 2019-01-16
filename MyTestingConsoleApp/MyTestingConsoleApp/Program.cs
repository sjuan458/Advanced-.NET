using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyTestingConsoleApp
{
    class Program
    {

        public class Visitor : ExpressionVisitor
        {
            public Visitor()
            {

            }
        }

        public class nodeObject
        {
            public Expression node;


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter something");
            string inp = Console.ReadLine();

            Console.WriteLine(inp);
            Console.Write("Enter any key to continue...");

            Console.ReadKey();
        }
    }
}
