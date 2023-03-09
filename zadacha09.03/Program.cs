using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha09._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            string komandi= Console.ReadLine();

            while (komandi != "print")
            {
                string[] k = komandi.Split();
                string n = k[0];

                if (n == "push")
                {
                    int number = int.Parse(k[1]);
                    numbers.Add(number);
                }
                else if (n == "pop")
                {
                    if (numbers.Count > 0)
                    {
                        int number = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        Console.WriteLine(number);
                    }
                }
                else if (n == "shift")
                {
                    if (numbers.Count > 0)
                    {
                        int number = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, number);
                    }
                }
                
               
            }

           
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}