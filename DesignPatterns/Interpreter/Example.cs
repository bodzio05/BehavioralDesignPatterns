using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace DesignPatterns.Interpreter
{
    public static class Example
    {
        public static void Execute_Example()
        {

            var input = "(13+4)-(12+1)";
            var tokens = Interpreter.Lex(input);
            WriteLine(string.Join("\t", tokens));

            var parsed = Interpreter.Parse(tokens);
            WriteLine($"{input} = {parsed.Value}");
        }
    }
}
