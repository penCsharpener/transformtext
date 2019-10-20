using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using TransformText.Args;
using TransformText.Utils;

namespace TransformText.Transform {
    public static class TextFileExtensions {
        public static async IAsyncEnumerable<TextFile> TransForm(this IEnumerable<TextFileInfo> textFiles) {
            foreach (var file in textFiles) {
                yield return file.Promote(await File.ReadAllLinesAsync(file.FullPath));
            }
        }

        public static async Task WriteTextFiles(this IAsyncEnumerable<TextFile> textFiles) {
            await foreach (var file in textFiles) {
                await File.WriteAllLinesAsync(Path.Combine(Setup.TargetFolder, file.FileName), file.GetLines());
            }
        }
    }
}
