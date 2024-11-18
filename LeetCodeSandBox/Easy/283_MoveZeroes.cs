namespace LeetCodeSandBox.EasyLevelTasks;

public class MoveZeroesTask
{
    public static void MoveZeroes(int[] nums)
    {
        var zeroesCount = 0;
        var endIndex = nums.Length - 1;

        for (int i = 0; i < endIndex; i++)
        {
            var valueForReplace = nums[i + 1];

            if (zeroesCount > 0 && valueForReplace != 0)
            {
                nums[i == 0 ? i : i - 1] = valueForReplace;
            }
            else
            {
                zeroesCount++;
            }
        }

        if (zeroesCount == 0 || zeroesCount >= endIndex) return;

        for (int i = endIndex; i > endIndex - zeroesCount; i--)
        {
            nums[i] = 0;
        }
    }
}
