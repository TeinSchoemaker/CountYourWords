using System;
using System.Diagnostics;
using System.Linq.Expressions;

class Program
{

    static void Main(string[] args)
    {
        var reader = new ReadInput("Input/input.txt");
        var regexInput = new RegexInput();
        var occurrences = new OccurrenesInput();

        string inputContent = reader.Read();
        List<string> wordsList = regexInput.Parse(inputContent);
        Dictionary<string, int> InputOccurences = occurrences.InputCounter(wordsList);

        Console.WriteLine("Number of words: ");
        foreach (KeyValuePair<string, int> kvp in InputOccurences) {
            Console.WriteLine("{0} {1} ", kvp.Key, kvp.Value);
        }
    }
}