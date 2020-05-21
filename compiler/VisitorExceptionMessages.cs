using System;
using System.Collections.Generic;
using System.Text;

namespace xmllang
{
    public static class VisitorExceptionMessages
    {
        public static string VarNotDefined = "Variable is not defined";
        public static string VarAlreadyExists = "Variable is already exists in the scope";
        public static string InvalidCast = "Invalid type cast";
        public static string UndefinedFunction = "Undefined function";
        public static string AlreadyDefinedFunction = "Function already defined";
    }
}
