using System.Text;

namespace LeetCodeSandBox;

public class MergeStringsAlternatelyTask
{
    public static string MergeAlternately(string word1, string word2)
    {
        var builder = new StringBuilder();

        for (int i = 0; i < word1.Length; i++)
        {
            builder.Append(word1[i]);

            if (word2.Length > i) builder.Append(word2[i]);
        }

        if (word2.Length > word1.Length) builder.Append(word2[(word1.Length)..]);

        return builder.ToString();
    }
}
