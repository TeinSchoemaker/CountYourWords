using System;
using System.Text.RegularExpressions;

public class RegexInput
{

   // Pattern only looks for uper and lower key letters
   static readonly string pattern = "[a-zA-Z]+";

   public List<string> Parse(string input)
   {
      Regex rg = new Regex(pattern);
      var matching = rg.Matches(input);
      List<string> wordsList = new List<string>();

      foreach (Match match in matching)
      {
         wordsList.Add(match.Value.ToLower());
      }

      return wordsList;
   }
}