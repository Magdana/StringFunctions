using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    public static class StaticFunctions
    {
        public static string MyJoin(string separator, string[] values)
        {
            string result = "";

            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];
                if (i < values.Length - 1)
                {
                    result += separator;
                }
            }

            return result;
        }

        public static bool Contains(string mainString, string value)
        {
            for (int i = 0; i <= mainString.Length - value.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < value.Length; j++)
                {
                    if (mainString[i + j] != value[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match) return true;
            }
            return false;
        }

        public static bool StartsWith(string mainString, string value)
        {
            if (mainString.Length < value.Length) return false;

            for (int i = 0; i < value.Length; i++)
            {
                if (mainString[i] != value[i]) return false;
            }
            return true;
        }

        public static bool EndsWith(string mainString, string value)
        {
            if (mainString.Length < value.Length) return false;

            for (int i = 0; i < value.Length; i++)
            {
                if (mainString[mainString.Length - value.Length + i] != value[i]) return false;
            }
            return true;
        }

        public static string Format(string format, params object[] args)
        {
            string result = "";
            int argIndex = 0;
            bool insidePlaceholder = false;
            string placeholder = "";

            for (int i = 0; i < format.Length; i++)
            {
                if (i < format.Length - 1 && format[i] == '{' && format[i + 1] == '}')
                {
                    result += args[argIndex].ToString();
                    argIndex++;
                    i++; 
                }
                else
                {
                    result += format[i];
                }
            }
            return result;
        }

        public static bool IsNullOrEmpty(string value)
        {
            return value == null || value.Length == 0;
        }

        public static bool IsNullOrWhiteSpace(string value)
        {
            if (value == null) return true;

            foreach (char c in value)
            {
                if (!char.IsWhiteSpace(c)) return false;
            }
            return true;
        }
    }

}
