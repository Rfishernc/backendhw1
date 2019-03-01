using System;

namespace backendhw1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var counter = 0;
            string output = "";
            foreach(char item in input) {
                counter++;
                for(var i = 1; i <= counter; i++)
                {
                    if (i == 1)
                    {
                        output += char.ToUpper(item);
                    } else
                    {
                        output += item;
                    }
                    if (i == counter && counter < input.Length)
                    {
                        output += "-";
                    }
                }
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
