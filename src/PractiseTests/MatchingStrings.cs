namespace PractiseTests;

public class MatchingStrings
{
    public static List<int> matchingStringsSolution(List<string> strings, List<string> queries)
    {
        var stringsKeyValue = new Dictionary<string, int>();


        foreach (var item in strings)
        {
            if (stringsKeyValue.ContainsKey(item))
            {
                stringsKeyValue[item] += 1;
            }
            else
            {
                stringsKeyValue[item] = 1;
            }
        }
        
        var result = new List<int>();
        
        foreach (var str in queries)
        {
            result.Add(stringsKeyValue.ContainsKey(str) ? stringsKeyValue[str] : 0);
        }
        return result;
    }

}