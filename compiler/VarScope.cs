using System.Collections.Generic;

namespace xmllang {
    public class VarScope
    {
        private IDictionary<string, string> _vars;

        public VarScope()
        {
            _vars = new Dictionary<string, string>();
        }

        public string GetVarValue(string varName) => _vars.TryGetValue(varName, out var value) ? value : null;

        public void SetVarValue(string varName, string varValue)
        {
            if (_vars.Remove(varName)) _vars.Add(varName, varValue);
        }

        public void CreateVar(string varName, string varValue = null) => _vars.Add(varName, varValue);

        public bool DeleteVar(string varName) => _vars.Remove(varName);

        public void ClearScope()
        {
            _vars.Clear();
        }
    }
}
