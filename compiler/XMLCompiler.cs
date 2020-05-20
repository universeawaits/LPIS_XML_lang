using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace xmllang
{
    public class XMLCompiler
    {
        static void Parse(string filepath)
        {
            var input = File.ReadAllText(filepath);
            var str = new AntlrInputStream(input);
            var lexer = new xmllangLexer(str);
            var tokens = new CommonTokenStream(lexer);
            var parser = new xmllangParser(tokens);
            var tree = parser.tale();
            
            var visitor = new XMLLangVisitor();
            var result = visitor.Visit(tree);
            
            Console.WriteLine(result);
        }

        public static void Main(string[] args)
        {
            Parse(args[0]);
        }
    }
}
