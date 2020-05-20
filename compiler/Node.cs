using System.Linq;
using System.Collections.Generic;

namespace xmllang {
    public class Node
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public IEnumerable<Attribute> Attributes { get; }
        public IEnumerable<Node> Children { get; }

        public Node(string name)
        {
            Name = name;
        }
    }
}
