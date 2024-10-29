using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox;

public class ValidAnagramTask
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var sDistinct = s.Distinct().ToList();
        var tDistinct = t.Distinct().ToList();

        if (sDistinct.Count() != tDistinct.Count()) return false;

        var sDict = sDistinct.ToDictionary(key => key, value => s.Where(x => x.Equals(value)).Count());
        var tDict = tDistinct.ToDictionary(key => key, value => t.Where(x => x.Equals(value)).Count());

        foreach (var sElement in sDict)
        {
            var isElementExisted = tDict.TryGetValue(sElement.Key, out var tValue);

            if (!isElementExisted || tValue != sElement.Value) return false;
        }

        return true;
    }
}
