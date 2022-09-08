using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        bool DoesSumEqualTarget(int firstNumber, int secondNumber) => firstNumber + secondNumber == target;

        (int number, int index)[] AddIndexes(IEnumerable<int> list) => list
                .Select((number, index) => (i: number, n: index))
                .ToArray();

        var numbersWithIndex = AddIndexes(numbers);
        foreach (var (firstNumber, firstIndex) in numbersWithIndex)
        {
            foreach (var (secondNumber, secondIndex) in numbersWithIndex)
            {
                var isNotSameIndex = firstIndex != secondIndex;
                if (isNotSameIndex && DoesSumEqualTarget(firstNumber, secondNumber))
                    return new[] { firstIndex, secondIndex };
            }
        }
        return new int[2];
    }
}