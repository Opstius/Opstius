namespace Opstius.Generator.MVVM
{
    public static class Utilities
    {
        public static readonly Dictionary<string, string> DefaultValues = new Dictionary<string, string>()
        {
            { "bool" ,"false"},
            { "Boolean" ,"false"},

            { "byte" ,"0"},
            { "Byte" ,"0"},

            { "sbyte" ,"0"},
            { "SByte" ,"0"},

            { "char" ,"\'\\0\'"},
            { "Char" ,"\'\\0\'"},

            { "decimal" ,"0"},
            { "Decimal" ,"0"},

            { "double" ,"0"},
            { "Double" ,"0"},

            { "float" ,"0"},
            { "Single" ,"0"},

            { "int" ,"0"},
            { "Int32" ,"0"},

            { "uint" ,"0"},
            { "UInt32" ,"0"},

            { "long" ,"0"},
            { "Int64" ,"0"},

            { "ulong" ,"0"},
            { "UInt64" ,"0"},

            { "short" ,"0"},
            { "Int16" ,"0"},

            { "ushort" ,"0"},
            { "UInt16" ,"0"},

            { "object" ,"null"},
            { "Object" ,"null"},

            { "string" ,"string.Empty"},
            { "String" ,"String.Empty"}
        };

        private static string GetValue(string type, string value)
        {
            if (value != string.Empty)
            {
                return value;
            }

            if (DefaultValues.ContainsKey(type))
            {
                value = DefaultValues[type];
            }
            else
            {
                value = $"new {type}()";
            }

            return value;
        }
        public static string GetDMValue(string type, string value)
        {
            return GetValue(type, value);
        }
        public static string GetVMValue(string type, string value)
        {
            return GetValue(type, value);
        }
    }
}
