/*
 * https://www.hackerrank.com/challenges/three-month-preparation-kit-mini-max-sum/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-one
 */

namespace PractiseTests;

public class MiniMaxSumSolution
{
    public static void miniMaxSum(List<int> arr)
    {
        var maxNum = arr[0];
        var minNum = arr[0];

        for (var i = 0; i < arr.Count; i++)
        {
            if (arr[i] < minNum)
            {
                minNum = arr[i];
            }

            if (arr[i] > maxNum)
            {
                maxNum = arr[i];
            }
        }
        
        /*
        var minSum = 0;
        var maxSum = 0;
        
        foreach (var t in arr)
        {
            if (maxNum != t)
            {
                minSum += t;
            }

            if (minNum != t)
            {
                maxSum += t;
            }
        }
        */

        long SumOfArr = 0;

        foreach (var item in arr)
        {
            SumOfArr += item;
        }

        long minSum = SumOfArr - maxNum;
        long maxSum = SumOfArr - minNum;

        Console.WriteLine($"{minSum} {maxSum}");
    }
}