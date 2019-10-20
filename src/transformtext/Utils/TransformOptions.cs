using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TransformText.Args;

    internal class TransformOptions {
namespace TransformText.Utils {
        public const string Filename = "options.json";
        public StartWith StartWith { get; set; } = new StartWith();
        public EndsWith EndsWith { get; set; } = new EndsWith();
        public Contains Contains { get; set; } = new Contains();
        public RemoveLinebreak RemoveLinebreak { get; set; } = new RemoveLinebreak();

        internal static async Task Create(Options o) {
            if (o.Reset || !File.Exists(Filename)) {
                await File.WriteAllTextAsync(Filename,
                                             JsonConvert.SerializeObject(new TransformOptions(),
                                             Formatting.Indented),
                                             Encoding.UTF8);
                Print.ConsolePrint.CreateOptionsFile(o, new FileInfo(Filename));
            }
        }

        internal static async Task<TransformOptions> ReadOptions() {
            if (File.Exists(Filename)) {
                return JsonConvert.DeserializeObject<TransformOptions>(await File.ReadAllTextAsync(Filename));
            }
            return null;
        }
    }

    public class StartWith {

    }

    public class EndsWith {

    }

    public class Contains {
        
    }

    public class RemoveLinebreak {
        public Dictionary<string, Mode> StartsWithRegex { get; set; } = new Dictionary<string, Mode>();
        public Dictionary<string, Mode> EndsWithRegex { get; set; } = new Dictionary<string, Mode>();
    }

    public enum Mode {
        Include,
        Exclude
    }
}
