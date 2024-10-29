using LeetCodeSandBox;

namespace LeetCodeSandBoxTests;

public class MergeStringsAlternatelyTest
{
    [TestCase("abc", "pqr", "apbqcr")]
    [TestCase("ab", "pqrs", "apbqrs")]
    [TestCase("abcd", "pq", "apbqcd")]
    public void AssertMergedStrings(string word1, string word2, string result)
    {
        var mergeResult = MergeStringsAlternatelyTask.MergeAlternately(word1, word2);
        Assert.That(mergeResult, Is.EqualTo(result));
    }
}