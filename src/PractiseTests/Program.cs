using PractiseTests;

class Program
{
    static void Main()
    {
        string splitMethod = "S;M;plasticCup()";
        string combineVariable = "C;V;mobile phone";
        string combineMethod = "C;M;white sheet of paper";
        string splitVariable = "S;V;pictureFrame";
        string combineClass = "C;C;coffee machine";
        string splitClass = "S;C;LargeSoftwareBook";
            
        var result = CamelCase.camelCase(splitMethod);
        var result1 = CamelCase.camelCase(combineVariable);
        var result2 = CamelCase.camelCase(combineMethod);
        var result3 = CamelCase.camelCase(splitVariable);
        var result4 = CamelCase.camelCase(combineClass);
        var result5 = CamelCase.camelCase(splitClass);
            
        Console.WriteLine($"Result: {result5}");
    }
}