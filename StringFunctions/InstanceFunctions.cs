
namespace StringFunctions
{
    public class InstanceFunctions
    {
        public string _str;
        public InstanceFunctions(string str)
        {
            _str = str;
        }
        public int strLength()
        {
            int length = 0;
            foreach (var item in _str)
            {
                length++;
            }
            return length;
        }


        public string MySubstring(int startInd, int lastInd)
        {
            var newStr = new string(_str.Skip(startInd).Take(lastInd - startInd).ToArray());
            return newStr;
        }

        public int MyIndexOf(string val)
        {
            string lowerStr = _str.ToLower();
            string lowerVal = val.ToLower();
            for (int i = 0; i < lowerStr.Length - lowerVal.Length; i++)
            {
                if (lowerStr.Substring(i, lowerVal.Length) == lowerVal)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MyLastIndexOf(string val)
        {
            string lowerStr = _str.ToLower();
            string lowerVal = val.ToLower();
            for (int i = lowerStr.Length - lowerVal.Length; i >= 0; i--)
            {
                if (lowerStr.Substring(i, lowerVal.Length) == lowerVal)
                {
                    return i;
                }
            }
            return -1;
        }

        public string MyReeplace(string oldValue, string newValue)
        {
            return _str.Replace(oldValue, newValue);
        }

        public string MyToUpper()
        {
            char[] result = new char[_str.Length];

            for (int i = 0; i < _str.Length; i++)
            {
                char c = _str[i];
                if (c >= 'a' && c <= 'z')
                {
                    result[i] = (char)(c - 32);
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }
        public string MyToLower()
        {
            char[] result = new char[_str.Length];

            for (int i = 0; i < _str.Length; i++)
            {
                char c = _str[i];
                if (c >= 'A' && c <= 'Z')
                {
                    result[i] = (char)(c + 32);
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }

        public string MyTrim()
        {
            int start = 0;
            int end = _str.Length - 1;
            while (start < _str.Length && char.IsWhiteSpace(_str[start]))
            {
                start++;
            }
            while (end > start && char.IsWhiteSpace(_str[end]))
            {
                end--;
            }

            return _str.Substring(start, end - start + 1);
        }

        public string[] MySplit(char separator)
        {
            List<string> result = new List<string>();
            int start = 0;

            for (int i = 0; i < _str.Length; i++)
            {
                if (_str[i] == separator)
                {
                    result.Add(_str.Substring(start, i - start));
                    start = i + 1;
                }
            }
            result.Add(_str.Substring(start));
            return result.ToArray();
        }
    }


}
