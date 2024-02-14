/*
https://www.hackerrank.com/challenges/three-month-preparation-kit-plus-minus/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-one
*/

namespace PractiseTests;

public class PlusMinusSolution
{
    public static void plusMinus(List<int> arr)
    {
        var positiveElementCount = 0f;
        var negativeElementCount = 0f;
        var zeroElementCount = 0f;
            
        arr.ForEach(element =>
        {
            if (element > 0)
            {
                positiveElementCount++;
            }
            if (element < 0)
            {
                negativeElementCount++;
            }
            if (element == 0)
            {
                zeroElementCount++;
            }
        });
        var positiveElementRatio = positiveElementCount / arr.Count;
        var negativeElementRatio = negativeElementCount / arr.Count;
        var zeroElementRatio = zeroElementCount / arr.Count;
        
        Console.WriteLine(positiveElementRatio.ToString("N6").Replace(',', '.'));
        Console.WriteLine(negativeElementRatio.ToString("N6").Replace(',', '.'));
        Console.WriteLine(zeroElementRatio.ToString("N6").Replace(',', '.'));
    }

}