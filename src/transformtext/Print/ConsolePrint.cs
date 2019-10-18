using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using transformtext.Args;

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

        internal static void ClearTargetFolder(bool optionQuiet) {
            if (optionQuiet) return;
            Console.WriteLine("Deleting all files in target folder.");
        }

        internal static void CreateOptionsFile(Options o, FileInfo file) {
            if (o.Quiet) return;
            Console.WriteLine($"{(o.Reset ? "Resetting" : "Creating")} options file '{file.FullName}'.");
        }

        internal static void HelpAddSourceFiles(bool optionQuiet, DirectoryInfo dir) {
            if (optionQuiet) return;
            Console.WriteLine($"Place your source text files in the newly created folder '{dir.FullName}'.");
        }
    }
}
