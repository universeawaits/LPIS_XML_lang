namespace xmllang {
    public class XMLAttribute
    {
        public object Name { get; set; }
        public string Value { get; set; }

        public XMLAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
