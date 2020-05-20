using System;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace xmllang
{
    public class XMLCompiler
    {
        public static void Main(string[] args)
        {
            try
            {
                string text = File.ReadAllText(args[1]);

                var reader = new StringReader(text);
                var input = new AntlrInputStream(reader);
                var lexer = new xmllangLexer(input);
                var tokens = new CommonTokenStream(lexer);
                var parser = new xmllangParser(tokens);

                var taleContext = parser.tale();

                var walker = new ParseTreeWalker();
                var listener = new AntlrXMLLangListener();
                walker.Walk(listener, taleContext);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
