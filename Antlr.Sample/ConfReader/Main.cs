using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Antlr.Sample.ConfReader
{
    class Main
    {
        public void Execute()
        {
            string input = 
            @"
                Sart(0,0)
                End(12,15)
            ";
            ANTLRStringStream inStream = new ANTLRStringStream(input);
            ConfLexer lexer = new ConfLexer(inStream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            ConfParser parser = new ConfParser(tokens);
            ConfParser.prog_return returnParser = parser.prog();

            var tree = returnParser.Tree as CommonTree;

            foreach (CommonTree item in tree.Children)
            {
                if (item.Type == ConfLexer.ID)
                    Console.WriteLine("function=" + item.Text);
                else if(item.Type == ConfLexer.INT)
                    Console.WriteLine("params:" + item.Text);
            }


            Console.ReadKey();
        }
    }
}
