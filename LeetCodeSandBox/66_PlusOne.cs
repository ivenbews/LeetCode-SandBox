using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeSandBox;

public class PlusOneTask
{
    public static int[] PlusOne(int[] digits)
    {
        if (digits[^1] != 9)
        {
            digits[^1]++;
            return digits;
        }

        if (digits.All(x => x == 9))
        {
            var increasedArray = new int[digits.Length + 1];
            increasedArray[0] = 1;
            return increasedArray;
        }

        var result = new int[digits.Length];

        return GetIncrement(digits, result, digits.Length - 1, 0);
    }

    private static int[] GetIncrement(int[] inputArray, int[] result, int index, int increment)
    {
        if (index < 0) return result;

        var currentValue = inputArray[index] + increment;
        var isLastDigit = index == result.Length - 1;

        if (currentValue < 9)
        {
            result[index] = isLastDigit ? ++currentValue : currentValue;
            return GetIncrement(inputArray, result, index - 1, 0);
        }

        if (currentValue == 9 && !isLastDigit)
        {
            result[index] = currentValue;
            return GetIncrement(inputArray, result, index - 1, 0);
        }

        result[index] = 0;
        return GetIncrement(inputArray, result, index - 1, 1);
    }
}
