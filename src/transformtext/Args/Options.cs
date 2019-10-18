using CommandLine;
using CommandLine.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace transformtext.Args {
    internal class Options {

        [Option('q', "quiet", Default = false, Required = false, HelpText = "Turn off welcome screen and other decorative text.")]
        public bool Quiet { get; set; }

        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }

        [Option('l', "loglevel", Default = 3, Required = false, HelpText = "Set log level from 1) Trace 2) Debug 3) Info 4) Warning 5) Error")]
        public int LogLevel { get; set; }

        [Option('s', "simulate", Default = false, Required = false, HelpText = "Will run the entire program on the sample files but return no output. Useful for large source file counts to check against errors before writing the files.")]
        public bool Simulate { get; set; }

        [Option('S', "subfolders", Default = true, Required = false, HelpText = "Also traverse through the subfolders in source folder")]
        public bool Subfolders { get; set; }

        [Option('f', "flatten", Default = false, Required = false, HelpText = "Will put all files including those in subfolders in the top level of the target folder.")]
        public bool Flatten { get; set; }

    }
}
