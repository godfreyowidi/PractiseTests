namespace PractiseTests;

public class TimeConversion
{
    public static string timeConversion(string s)
    {
        var hourStr = s.Substring(0, 2);
        var ampmString = s[^2..]; //hh:mm:ssAM
        
        var mm = s.Substring(3, 2);
        var ss = s.Substring(6, 2);

        switch (hourStr)
        {
            case "12" when ampmString == "AM":
                return $"00:{mm}:{ss}";
            case "12" when ampmString == "PM":
                return $"12:{mm}:{ss}";
        }

        if (ampmString == "PM" && hourStr != "12")
        {
            var hourToInt = int.Parse(hourStr);
            var afterMidday = hourToInt + 12;

            var hh = afterMidday.ToString();
            return $"{hh}:{mm}:{ss}";
        }

        return $"{hourStr}:{mm}:{ss}";
    }
}