using System;
using System.Text.RegularExpressions;

class RegexInput {
   
   static readonly string pattern = "[a-zA-Z]+";

   public List<string> Parse(string input) {
    Regex rg = new Regex(pattern);
    var matching = rg.Matches(input);
    var wordsList = new List<string>();

    foreach (Match match in matching){
      wordsList.Add(match.Value);
    }

   return wordsList;
   }
}