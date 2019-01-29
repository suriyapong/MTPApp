using System;

using MTPLibrary;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum");
            Console.ReadLine();

            Calculator servicec = new Calculator();

            //Console.WriteLine(servicec.Add(1, 2));
            //Console.WriteLine();

            Console.Write("Please insert input 1 : ");
            string x = Console.ReadLine();

            Console.Write("Please insert input 2 : ");
            string y = Console.ReadLine();

            int s1 = Convert.ToInt32(x);
            int s2 = Convert.ToInt32(y);

            int sum = servicec.Add(s1,s2);

            string msg = $"Your Ans : { x } +  { y } = {sum} ";

            Console.WriteLine(msg);

            Console.ReadLine();

        }
    }
}
