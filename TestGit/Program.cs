using System;
using System.Collections.Generic;
using MTPLibrary;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum");
            Console.ReadLine();



            //Console.WriteLine(servicec.Add(1, 2));
            //Console.WriteLine();

            //Console.Write("Please insert input 1 : ");
            //string x = Console.ReadLine();

            //Console.Write("Please insert input 2 : ");
            //string y = Console.ReadLine();

            //int s1 = Convert.ToInt32(x);
            //int s2 = Convert.ToInt32(y);

            //int sum = servicec.Add(s1,s2);

            //string msg = $"Your Ans : { x } +  { y } = {sum} ";

            Calculator servicec1 = new Calculator(true);

            Calculator servicec2 = new Calculator(false);


            string sum1 = "";
            string sum2 = "";
            int i = 0;

            while (true)
            {
                Console.Write("Please insert input : ");
                string n = Console.ReadLine();
  
                bool isNumeric = int.TryParse(n, out int mm);
                if (isNumeric)
                {
                    if (i%2 == 0)
                    {
                        sum1 = servicec1.GetInput(Convert.ToInt32(mm));
                    }
                    else
                    {
                        sum2 = servicec2.GetInput(Convert.ToInt32(mm));
                    }
                   
                }
                else
                {
                    break;
                }

                i++;
               
            }


            string set1 = String.Join(",", servicec1.GetHistory());

            string set2 = String.Join(",", servicec2.GetHistory());

            string msg = $"SUM คู่ { set1 } :  { sum1 } SUM คี่ { set2 } : { sum2 }";

            Console.WriteLine(msg);


            Console.ReadLine();

        }
    }
}
