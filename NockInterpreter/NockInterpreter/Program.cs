using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NockInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string program = "[[132 19] [10 37 [4 0 3]]]";
            Console.WriteLine("result of nocking program \"" + program + "\":\t" + Interpreter.Nock(program));
            Console.ReadKey();
        }
    }
}
