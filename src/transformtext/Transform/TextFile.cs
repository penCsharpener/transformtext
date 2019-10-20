using System.Collections.Generic;
using System.IO;
using System.Linq;
using transformtext.Args;

namespace transformtext.Transform {
    public class TextFile : TextFileInfo {
        private readonly IEnumerable<string> lines;

        public TextFile(FileInfo fi, IEnumerable<string> lines) : base(fi) {
            this.lines = lines;
        }

        public TextFile(TextFileInfo txtFileInfo,
                        IEnumerable<string> lines) : base(txtFileInfo.fi) {
            this.lines = lines;
        }

        public TextFile Transform(Options o) {
            lines.RemoveLinebreak(o);
            return this;
        }

        public string[] GetLines() => lines.ToArray();

    }
}
