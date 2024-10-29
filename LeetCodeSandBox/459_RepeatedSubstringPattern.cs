using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox;

public class RepeatedSubstringPatternTask
{
    public static bool RepeatedSubstringPattern(string s)
    {
        int maxSubstringLength = s.Length / 2;

        for (int substringLength = maxSubstringLength; substringLength > 0; substringLength--)
        {
            if (s.Length % substringLength != 0) continue;

            var hasRepeatedSubstrings = HasRepeatedSubstrings(s, null, 0, substringLength);
            if (hasRepeatedSubstrings) return true;
        }

        return false;
    }

    private static bool HasRepeatedSubstrings(string s, string substring, int startIndex, int substringLength)
    {
        if (startIndex >= s.Length) return true;

        var substringForCompare = s.Substring(startIndex, substringLength);

        if (substring is not null && !substring.Equals(substringForCompare))
        {
            return false;
        }

        return HasRepeatedSubstrings(s, substringForCompare, startIndex + substringLength, substringLength);
    }
}
