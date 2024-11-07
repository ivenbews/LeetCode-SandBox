using LeetCodeSandBox.EasyLevelTasks;

namespace LeetCodeSandBoxTests.EasyLevelTasks;

public class MoveZeroesTest
{
    [TestCase(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
    [TestCase(new int[] { 0 }, new int[] { 0 })]
    [TestCase(new int[] { 1 }, new int[] { 1 })]
    [TestCase(new int[] { 1, 0 }, new int[] { 1, 0 })]
    [TestCase(new int[] { 2, 1 }, new int[] { 2, 1 })]
    [TestCase(new int[] { 1, 0, 0, 5 }, new int[] { 1, 5, 0, 0 })]
    public void AssertArrays(int[] nums, int[] result)
    {
        MoveZeroesTask.MoveZeroes(nums);
        Assert.That(nums, Is.EquivalentTo(result));
    }
}
