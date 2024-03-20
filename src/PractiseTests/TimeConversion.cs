//https://www.hackerrank.com/challenges/three-month-preparation-kit-time-conversion/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=three-month-preparation-kit&playlist_slugs%5B%5D=three-month-week-one

namespace PractiseTests;

public class TimeConversion
{
    public static string timeConversion(string s)
    {
        var hourStr = s.Substring(0, 2);
        var ampmString = s[^2..]; //hh:mm:ssAM
        
        var mm = s.Substring(3, 2);
        var ss = s.Substring(6, 2);

        if (hourStr == "12" && ampmString == "AM") return $"00:{mm}:{ss}";

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