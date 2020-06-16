using System;

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
    }
}
