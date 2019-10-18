using CommandLine;
using System;
using transformtext.Args;
using transformtext.Print;

namespace transformtext {
    static class Program {
        static void Main(string[] args) {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o => {
                    ConsolePrint.Welcome(o.Quiet);
                });

        }
    }
}
