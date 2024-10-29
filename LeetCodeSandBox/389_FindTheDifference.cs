using System.Collections.Immutable;
using System.Linq;

namespace LeetCodeSandBox;

public class FindTheDifferenceTask
{
    public static char FindTheDifference(string s, string t)
    {
        if (string.IsNullOrEmpty(s)) return t[^1];

        var sGroupedChars = s.GroupBy((x) => x);
        var tGroupedChars = t.GroupBy((x) => x);

        foreach (var tElement in tGroupedChars)
        {
            var tKey = tElement.Key;
            var sElement = sGroupedChars.FirstOrDefault(x => x.Key.Equals(tKey));

            if (sElement is null || sElement.Count() != tElement.Count())
            {
                return tKey;
            }
        }

        return t[^1];
    }
}
