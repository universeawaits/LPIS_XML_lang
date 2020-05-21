using System.Linq;
using System.Collections.Generic;

namespace xmllang {
    public class XMLNode
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public IEnumerable<XMLAttribute> Attributes { get; }
        public IEnumerable<XMLNode> Children { get; }

        public XMLNode(string name)
        {
            Name = name;
        }
    }
}
