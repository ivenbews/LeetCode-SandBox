using LeetCodeSandBox;

namespace LeetCodeSandBoxTests;

public class IndexOfTheFirstOccurrenceInAStringTest
{
    [TestCase("sadbutsad", "sad", 0)]
    [TestCase("leetcode", "leeto", -1)]
    public void AssertIndexes(string haystack, string needle, int result)
    {
        var index = IndexOfTheFirstOccurrenceInAStringTask.StrStr(haystack, needle);
        Assert.That(index, Is.EqualTo(result));
    }
}
