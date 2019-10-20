using CommandLine;
using System;
using TransformText.Args;
using TransformText.Print;
using TransformText.Transform;
using TransformText.Utils;

namespace TransformText {
    static class Program {
        static void Main(string[] args) {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(async o => {
                    ConsolePrint.Welcome(o.Quiet);
                    await Setup.Structure(o);
                    SourceFolder.GetFiles(o).TransForm();
                    await foreach (var textFile in SourceFolder.GetFiles(o).TransForm()) {

                    }
                });
        }
    }
}
