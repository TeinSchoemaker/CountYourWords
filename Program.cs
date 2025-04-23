using System;
using System.Linq.Expressions;

class Program {

    static void Main(string[] args) {
        var reader = new ReadInput("Input/input.txt");
        var regexInput = new RegexInput();

        string inputContent = reader.Read();
        List<string> wordsList = regexInput.Parse(inputContent);
        
        for(int i=0; i<wordsList.Count; i++) {
            Console.WriteLine(wordsList[i]);
        }
    }
}