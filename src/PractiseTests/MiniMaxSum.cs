/*
 * https://www.hackerrank.com/challenges/three-month-preparation-kit-mini-max-sum/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-one
 */

namespace PractiseTests;

public class MiniMaxSum
{
    public static void miniMaxSum(List<int> arr)
    {
        var maxNum = arr.Max();
        var minNum = arr.Min();
        
        var sumOfList = 0;
        
        for (var i = 0; i < arr.Count; i++)
        {
            sumOfList += arr[i];
        }
        
        var minSum = sumOfList - maxNum;
        var maxSum = sumOfList - minNum;
        
        Console.WriteLine($"{minSum} {maxSum}");
    }
}