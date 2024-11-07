namespace LeetCodeSandBox.EasyLevelTasks;

public class ArithmeticProgressionCheckTask
{
    public static bool CanMakeArithmeticProgression(int[] arr)
    {
        Array.Sort(arr);

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] - arr[i - 1] != arr[i + 1] - arr[i]) return false;
        }

        return true;
    }

    public bool IsCircularSentence(string sentence)
    {
        var words = sentence.Split();

        if (words[0][0] != words[^1][^1]) return false;

        for (int i = 0; i < words.Length - 1; i++)
        {
            if (words[i][^1] != words[i + 1][0]) return false;
        }

        return true;
    }
}
