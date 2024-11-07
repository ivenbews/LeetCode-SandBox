using System.Text.RegularExpressions;

namespace LeetCodeSandBox.EasyLevelTasks;

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
