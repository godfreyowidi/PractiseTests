namespace PractiseTests;

public class DivisibleSumPairs
{
    public static int DivisibleSumPairsSolution(int n, int k, List<int> ar)
    {
        var counter = 0;
        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    counter++;
                }
                
            }
        }

        return counter;
    }

}