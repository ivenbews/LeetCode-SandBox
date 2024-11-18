using LeetCodeSandBox.EasyLevelTasks;

namespace LeetCodeSandBoxTests.EasyLevelTasks;

public class RepeatedSubstringPatternTest
{
    [TestCase("abab", true)]
    [TestCase("aba", false)]
    [TestCase("abcabcabcabc", true)]
    [TestCase("abac", false)]
    [TestCase("bb", true)]
    [TestCase("ababab", true)]
    [TestCase("ababba", false)]
    public void AssertIndexes(string s, bool result)
    {
        var hasRepeated = RepeatedSubstringPatternTask.RepeatedSubstringPattern(s);
        Assert.That(hasRepeated, Is.EqualTo(result));
    }
}
