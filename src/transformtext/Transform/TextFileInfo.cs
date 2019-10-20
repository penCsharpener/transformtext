using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TransformText.Transform {
    public class TextFileInfo {
        internal readonly FileInfo fi;
        public string FullPath => fi.FullName;
        public string FileName => fi.Name;

        public TextFileInfo(FileInfo fi) {
            this.fi = fi;
        }

        public TextFile Promote(IEnumerable<string> lines) {
            return new TextFile(fi, lines);
        }
    }
}
