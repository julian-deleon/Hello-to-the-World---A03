/* Hello World
 * by Julian De Leon
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0) //have one or more string supplied
            {
                foreach (string word in args)
                    WriteLine($"Hello {word}"); //string interpolation - $"{expression}"
            }
            else
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine(@"
Hello World
===== ====

Usage: .\HelloWorld [names]

where
    [names] is a space-separated list of names");
            }
            //Reset console text color
            ResetColor(); //.Foreground and .ResetColor are static members of Console class
        }
    }
}
