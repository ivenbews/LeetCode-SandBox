using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeSandBox;

public class IndexOfTheFirstOccurrenceInAStringTask
{
    public static int StrStr(string haystack, string needle)
    {
        var substringPattern = new Regex($"({needle})");

        if (!substringPattern.IsMatch(haystack)) return -1;

        var modifiedInput = substringPattern.Replace(haystack, ".");

        return modifiedInput.IndexOf('.');
    }
}
