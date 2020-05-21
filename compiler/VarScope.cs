using System.Collections.Generic;

namespace xmllang {
    public class VarScope
    {
        public class Var
        {
            public string Type { get; }
            public object Value { get; set; }

            public Var(string type, object value)
            {
                Type = type;
                Value = value;
            }
        }

        public IDictionary<string, Var> Vars { get; private set; }
        public string Name { get; }

        public VarScope(string scopeName)
        {
            Name = scopeName;
            Vars = new Dictionary<string, Var>();
        }

        public VarScope(string scopeName, IDictionary<string, Var> vars)
        {
            Name = scopeName;
            Vars = vars;
        }

        public object GetVarValue(string varName) => Vars.TryGetValue(varName, out Var var) ? var.Value : null;

        public string GetVarType(string varName) => Vars.TryGetValue(varName, out Var var) ? var.Type : null;

        public void SetVarValue(string varName, object varValue)
        {
            Vars.TryGetValue(varName, out Var var);
            var.Value = varValue;
        }

        public void CreateVar(string varName, string varType, object varValue = null) => Vars.Add(varName, new Var(varType, varValue));

        public bool DeleteVar(string varName) => Vars.Remove(varName);

        public void ClearScope()
        {
            Vars.Clear();
        }
    }
}
