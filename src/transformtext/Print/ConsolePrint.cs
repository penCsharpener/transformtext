using System;
using System.Collections.Generic;
using System.Text;

namespace transformtext.Print {
    internal static class ConsolePrint {
        internal static void Welcome(bool optionQuiet) {
            if (optionQuiet) return;
            Console.WriteLine("=====================================");
            Console.WriteLine("=                                   =");
            Console.WriteLine("=     Welcome to TransformText      =");
            Console.WriteLine("=                                   =");
            Console.WriteLine("=====================================");
        }
    }
}
