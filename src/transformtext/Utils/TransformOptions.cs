using System;
using System.Collections.Generic;
using System.Text;

namespace transformtext.Utils {
    public class TransformOptions {
        public const string Filename = "options.json";
        public StartWith StartWith { get; set; } = new StartWith();
        public EndsWith EndsWith { get; set; } = new EndsWith();
        public Contains Contains { get; set; } = new Contains();
        public RemoveLinebreak RemoveLinebreak { get; set; } = new RemoveLinebreak();
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
