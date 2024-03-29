using System.Globalization;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Channels;

namespace PractiseTests;

public class CamelCase
{
    public static string camelCase(string s)
    {
        var actionType = s.Substring(0, 4);
        
        if (actionType == "S;M;") //S;M;plasticCup() -         plastic cup
        {
            var splitMethod = s.Substring(4, s.Length - 6);

            var firstUpperCaseIndex = -1;

            for (var i = 0; i < splitMethod.Length; i++)
            {
                if (Char.IsUpper(splitMethod[i]))
                {
                    firstUpperCaseIndex = i;
                    break;
                }
            }

            if (firstUpperCaseIndex > 0)
            {
                var result = splitMethod.Insert(firstUpperCaseIndex, " ").ToLower();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(splitMethod.ToLower());
            }
        }

        if (actionType == "C;V;") //C;V;mobile phone -         mobilePhone
        {
            var combineVariable = new StringBuilder(s.Substring(4));

            for (var i = 0; i < combineVariable.Length - 1; i++)
            {
                if (Char.IsWhiteSpace(combineVariable[i]))
                {
                    combineVariable[i + 1] = Char.ToUpper(combineVariable[i + 1]);
                    combineVariable.Remove(i, 1);
                    break;

                }
            }
            var result = combineVariable.ToString();
            Console.WriteLine(result);
        }

        if (actionType == "C;C;") //C;C;coffee machine -       CoffeeMachine
        {
            var combineClass = s.Substring(4);

            var results =  CultureInfo.CurrentCulture.TextInfo.ToTitleCase(combineClass.ToLower()).Replace(" ", "");
            Console.WriteLine(results);

        }

        if (actionType == "S;C;") //S;C;LargeSoftwareBook -    large software book
        {
            var splitClass = new StringBuilder(s.Substring(4));

            var spaceIndices = new List<int>();

            for (var i = 1; i < splitClass.Length; i++)
            {
                if (Char.IsUpper(splitClass[i]))
                {
                    spaceIndices.Add(i);
                }
            }

            foreach (var index in spaceIndices.OrderByDescending(i => i))
            {
                splitClass.Insert(index, " ");
            }
            Console.WriteLine(splitClass.ToString().ToLower());
        }

        if (actionType == "C;M;") //C;M;white sheet of paper -         whiteSheetOfPaper()
        {
            var combineMethod = new StringBuilder(s.Substring(4));

            for (var i = 0; i < combineMethod.Length - 1; i++)
            {
                if (Char.IsWhiteSpace(combineMethod[i]))
                {
                    combineMethod[i + 1] = Char.ToUpper(combineMethod[i + 1]);
                    combineMethod.Remove(i, 1);
                }
            }
            combineMethod.Append("()");
            Console.WriteLine(combineMethod.ToString());
        }

        if (actionType == "S;V;") //S;V;pictureFrame -         picture frame
        {
            var splitVariable = s.Substring(4);
            int firstUpperCaseIndex = -1;

            for (var i = 0; i < splitVariable.Length; i++)
            {
                if (Char.IsUpper(splitVariable[i]))
                {
                    firstUpperCaseIndex = i;
                    break;
                }
            }

            if (firstUpperCaseIndex != -1)
            {
                var result = splitVariable.Substring(0, firstUpperCaseIndex) + " " +
                             splitVariable.Substring(firstUpperCaseIndex).ToLower();
                Console.WriteLine(result);
            }
        }

        return "";
    }
}