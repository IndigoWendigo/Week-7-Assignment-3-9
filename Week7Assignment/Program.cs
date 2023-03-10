using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Week7Assignment
{
    internal class Program
    {
        static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("Enter a file path: ");
                string userInput = @"" + Console.ReadLine();

                StreamReader sr = new StreamReader(userInput);

                string line;

                var pathChecker = new Regex(@"^(?:[a - zA - Z]\:|\\\\[\w\.] +\\[\w.$] +)\\(?:[\w] +\\)*\w([\w.])+$");

                do
                {
                    Console.WriteLine("Valid file path found:");
                    line = sr.ReadLine();
                    Console.WriteLine(line);

                } while (line != null);

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid file path, " + e.Message);
            }
        }
    }
}