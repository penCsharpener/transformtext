using CommandLine;
using System;
using transformtext.Args;
using transformtext.Print;
using transformtext.Utils;

namespace transformtext {
    static class Program {
        static void Main(string[] args) {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(async o => {
                    ConsolePrint.Welcome(o.Quiet);
                    await Setup.Structure(o);

                });
        }
    }
}
