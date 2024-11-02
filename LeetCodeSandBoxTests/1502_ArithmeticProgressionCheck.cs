using LeetCodeSandBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBoxTests;

public class ArithmeticProgressionCheckTest
{
    [TestCase(new int[] { 3, 5, 1 }, true)]
    public void AssertMergedStrings(int[] arr, bool result)
    {
        var isProgression = ArithmeticProgressionCheckTask.CanMakeArithmeticProgression(arr);
        Assert.That(isProgression, Is.EqualTo(result));
    }
}
