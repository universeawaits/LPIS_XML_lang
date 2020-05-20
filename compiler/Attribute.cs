namespace xmllang {
    public class Attribute
    {
        public object Name { get; set; }
        public string Value { get; set; }

        public Attribute(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
