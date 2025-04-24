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
        var sorter = new SortInput();
        var count = new CountInput();

        string inputContent = reader.Read();
        List<string> wordsList = regexInput.Parse(inputContent);
        Dictionary<string, int> InputOccurences = occurrences.InputCounter(wordsList);
        List<KeyValuePair<string, int>> SortedInput = sorter.Sort(InputOccurences);

        Console.WriteLine($"Number of words: {count.CountWords(SortedInput)}\n");

        foreach (KeyValuePair<string, int> kvp in SortedInput)
        {
            Console.WriteLine("{0} {1} ", kvp.Key, kvp.Value);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();

    }
}