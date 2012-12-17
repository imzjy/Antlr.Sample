using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Antlr.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfReader.Main main = new ConfReader.Main();
            main.Execute();
        }
    }
}
