using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using transformtext.Args;
using transformtext.Print;

namespace transformtext.Utils {
    internal static class Setup {
        internal const string SourceFolder = "source";
        internal const string TargetFolder = "target";

        internal static async Task Structure(Options o) {
            if (!Directory.Exists(SourceFolder)) {
                ConsolePrint.HelpAddSourceFiles(o.Quiet,
                                                Directory.CreateDirectory(SourceFolder));
            }
            if (Directory.Exists(TargetFolder) && o.Reset) {
                ConsolePrint.ClearTargetFolder(o.Quiet);
                Directory.Delete(TargetFolder, true);
            }
            if (!Directory.Exists(TargetFolder)) {
                Directory.CreateDirectory(TargetFolder);
            }

            await TransformOptions.Create(o);
        }
    }
}
