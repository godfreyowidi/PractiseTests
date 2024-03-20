// https://www.hackerrank.com/challenges/three-month-preparation-kit-breaking-best-and-worst-records/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-one

namespace PractiseTests;

public class BreakingRecords
{
    public static List<int> breakingRecords(List<int> scores)
    {
        if (scores == null || scores.Count == 0)
            return new List<int> {0, 0};
        
        var minPoints = scores[0];
        var maxPoints = scores[0];
      
        var numMinRecords = 0;
        var numMaxRecords = 0;
      
        for (var i = 1; i < scores.Count; i++)
        {
            var scoreItem = scores[i];
         
            if (scoreItem < minPoints)
            {
                numMinRecords += 1;
                minPoints = scoreItem;
            }
         
            if (scoreItem > maxPoints)
            {
                numMaxRecords += 1;
                maxPoints = scoreItem;
            }
        }
        return new List<int> { numMaxRecords, numMinRecords };
    }
}