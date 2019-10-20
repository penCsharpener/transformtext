using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransformText.Args;
using TransformText.Transform;

namespace TransformText.Tests {

    class ExtensionTests {

        private Options o;

        [SetUp]
        public void Setup() {
            o = new Options();
        }

        [TestCase]
        public async Task GetFiles() {
            await TransformText.Utils.Setup.Structure(o);
            Console.WriteLine(string.Join(", ", SourceFolder.GetFiles(o).Select(x => x.fi.Name)));
            Assert.IsTrue(SourceFolder.GetFiles(o).Any());
        }

        [TestCase]
        public async Task ReadAndWriteFileTest() {
            // Read text file
            await SourceFolder.GetFiles(o).TransForm().WriteTextFiles();
            // Create TextFileInfo
            // read lines and create TextFile
            // write lines to new destination file
            Assert.Pass();
        }
    }
}
