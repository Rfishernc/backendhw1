using System;

namespace backendhw2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = "";
            var splitInput = input.Split(",");
            var counter = 0;
            var total = 1;
            Console.WriteLine("Would you like to multiply or square? Enter M for multiply or S for square.");
            var type = Console.ReadLine();
            if (type == "M")
            {
                foreach (string num in splitInput)
                {
                    var curNum = Int32.Parse(num);
                    total = total * curNum;
                }
                output += total;
            } else if (type == "S")
            {
                foreach (string num in splitInput)
                {
                    counter++;
                    var curNum = Int32.Parse(num);
                    curNum = curNum * curNum;
                    output += curNum;
                    if (counter < splitInput.Length)
                    {
                        output += ",";
                    }
                }
            }           
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
