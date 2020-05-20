using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace xmllang
{
    public class XMLCompiler
    {
        static void Try(string input)
        {
            var str = new AntlrInputStream(input);
            var lexer = new xmllangLexer(str);
            var tokens = new CommonTokenStream(lexer);
            var parser = new xmllangParser(tokens);
            var tree = parser.tale();
            
            var visitor = new XMLLangVisitor();
            visitor.Visit(tree);
        }

        static void Main(string[] args)
        {
            Try(args[1]);
        }
    }
}
