using Microsoft.VisualBasic;

namespace PractiseTests;

public class GradingStudents
{
    public static List<int> GradingStudentsSolution(List<int> grades)
    {
        var result = new List<int>();   
        foreach (var grade in grades)
        {
            if (grade < 38)
            {
                result.Add(grade);
            }
            else
            {
                var nextMultipleOfFive = ((grade / 5) + 1) * 5;

                if (nextMultipleOfFive - grade < 3)
                {
                    result.Add(nextMultipleOfFive);
                }
                else
                {
                    result.Add(grade);
                }
            }

        }

        return result;
    }
}
// 51 % 5 = 1 55 - 51 = 4
// 52 % 5 = 2 55 - 52 = 3
// 53 % 5 = 3 55 - 53 = 2
// 54 % 5 = 4 55 - 54 = 1
// 55 % 5 = 0 
// 56 % 5 = 1
// 57 % 5 = 2
// 58 % 5 = 3
// 59 % 5 = 4