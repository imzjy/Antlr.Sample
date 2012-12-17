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
            ANTLRStringStream inStream = new ANTLRStringStream("LINE(9)");
            ConfLexer lexer = new ConfLexer(inStream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            ConfParser parser = new ConfParser(tokens);
            ConfParser.stat_return returnParser = parser.stat();

            var tree = returnParser.Tree as CommonTree;

            foreach (CommonTree item in tree.Children)
            {
                if (item.Type == ConfLexer.FUNC)
                    Console.WriteLine("function=" + item.Text);
                else if(item.Type == ConfLexer.PARAMS)
                    Console.WriteLine("params:" + item.Text);
            }


            Console.ReadKey();
        }
    }
}
