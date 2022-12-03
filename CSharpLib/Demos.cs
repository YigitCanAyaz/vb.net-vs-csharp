using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharpLib
{
    public class Demos : IDemos
    {
        /// <summary>
        /// This is our C# LoadFile method
        /// </summary>
        /// <returns></returns>
        public List<string> LoadFile()
        {
            List<string> output = new List<string>();
            List<string> lines = File.ReadAllLines(@"C:\temp\test.txt").ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                if (i % 2 == 0)
                {
                    output.Add(lines[i]);
                }
            }

            return output;
        }

        public void PrintFullName(string firstName, string lastName)
        {
            // You probably shouldn't do this in a class library
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}
