using System;

namespace LanguageComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // VB.NET

            VBLib.Demos vb = new VBLib.Demos();

            var vbResults = vb.LoadFile();

            Console.WriteLine("VB.NET Call");

            foreach (var item in vbResults)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            // C#

            CSharpLib.Demos cSharp = new CSharpLib.Demos();

            var cSharpResults = cSharp.LoadFile();

            Console.WriteLine("C# Call");

            foreach (var item in cSharpResults)
            {
                Console.WriteLine(item);
            }

        }
    }
}
