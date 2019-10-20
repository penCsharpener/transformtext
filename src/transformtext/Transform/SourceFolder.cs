using System.Collections.Generic;
using System.IO;
using System.Linq;
using transformtext.Args;

namespace transformtext.Transform {
    public static class SourceFolder {

        public const string Path = "source";

        public static IEnumerable<TextFileInfo> GetFiles(Options o) {
            if (o.Subfolders) {
                return ConvertToTextFile(RecurseFiles(new DirectoryInfo(Path)));
            }
            return ConvertToTextFile(new DirectoryInfo(Path).GetFiles());
        }

        private static IEnumerable<FileInfo> RecurseFiles(DirectoryInfo dir) {
            if (dir.EnumerateDirectories().Any()) {
                foreach (var directory in dir.GetDirectories()) {
                    RecurseFiles(directory);
                }
            }
            foreach (var file in dir.GetFiles()) {
                yield return file;
            }
        }

        private static IEnumerable<TextFileInfo> ConvertToTextFile(IEnumerable<FileInfo> files) {
            return files.Select(x => new TextFileInfo(x));
        }
    }
}
