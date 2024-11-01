using LeetCodeSandBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBoxTests;

public class PlusOneTest
{
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
    [TestCase(new int[] { 9 }, new int[] { 1, 0 })]
    [TestCase(new int[] { 3, 9, 9, 9 }, new int[] { 4, 0, 0, 0 })]
    [TestCase(new int[] { 8, 9, 9, 9 }, new int[] { 9, 0, 0, 0 })]
    [TestCase(new int[] { 2, 4, 9 }, new int[] { 2, 5, 0 })]
    [TestCase(new int[] { 9, 8, 9 }, new int[] { 9, 9, 0 })]
    [TestCase(
        new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 }, 
        new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 7 }
    )]
    public void AssertArrays(int[] nums, int[] result)
    {
        var res = PlusOneTask.PlusOne(nums);
        Assert.That(res, Is.EquivalentTo(result));
    }
}
