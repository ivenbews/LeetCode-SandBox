namespace LeetCodeSandBox;

public class ArrayProductSignTask
{
    public static int ArraySign(int[] nums)
    {
        var zeroesCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) return 0;
            if (nums[i] < 0) zeroesCount++;
        }

        return zeroesCount % 2 == 1 ? -1 : 1;
    }
}
