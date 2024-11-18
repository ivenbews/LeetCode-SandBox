using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandBox.Easy;

public static class PalindromeNumberTask
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x < 10) return true;

        var str = x.ToString();

        for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        {
            if (!str[i].Equals(str[j])) return false;
        }

        return true;
    }
}
