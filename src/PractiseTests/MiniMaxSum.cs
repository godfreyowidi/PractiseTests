/*
 * https://www.hackerrank.com/challenges/three-month-preparation-kit-mini-max-sum/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-one
 */

namespace PractiseTests;

public class MiniMaxSumSolution
{
    public static void miniMaxSum(List<int> arr)
    {
        var firstItem = arr[0];
        var maxNum = firstItem;
        var minNum = firstItem;
        
        long SumOfArr = 1;
        
        for (var i = 1; i < arr.Count; i++)
        {
            var item = arr[i];
            SumOfArr += item;
            
            if (item < minNum)
            {
                minNum = item;
            }

            if (item > maxNum)
            {
                maxNum = item;
            }
        }
        

        long minSum = SumOfArr - maxNum;
        long maxSum = SumOfArr - minNum;

        Console.WriteLine($"{minSum} {maxSum}");
    }
}