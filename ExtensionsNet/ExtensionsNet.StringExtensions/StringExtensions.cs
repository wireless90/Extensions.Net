using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ExtensionsNet.StringExtensions
{
    public static class StringExtensions
    {
        private const int NOT_FOUND = -1;

        public static String Between(this String value, String leftString, String rightString)
        {
            int leftIndex = value.IndexOf(leftString);

            if(leftIndex == NOT_FOUND)
            {
                return String.Empty;
            }

            int rightIndex = value.LastIndexOf(rightString);

            if(rightIndex == NOT_FOUND || (leftIndex + leftString.Length -1) == rightIndex)
            {
                return String.Empty;
            }

            int leftSubstringIndex = leftIndex + leftString.Length;
            int rightSubstringIndex = rightIndex - leftSubstringIndex;

            return value.Substring(leftSubstringIndex, rightSubstringIndex);
        }

        public static String Capitalize(this String value)
        {
            return String.Join(' ', value.Split(' ')
                .Where(x => !String.IsNullOrWhiteSpace(x))
                .Select(x => 
                {
                    var charArray = x.ToLower().ToCharArray();
                    charArray[0] = Char.ToUpper(charArray[0]);
                    return new String(charArray);
                }));
        }

        public static Boolean IsNumeric(this String value)
        {
            if (long.TryParse(value, out _) || ulong.TryParse(value, out _) || decimal.TryParse(value, out _))
                return true;
            return false;
        }
    }

    
}
