using System;

public class OccurrenesInput
{
    public Dictionary<string, int> InputCounter(List<string> wordsList)
    {

        Dictionary<string, int> occurrences = new Dictionary<string, int>();

        foreach (string word in wordsList ) {
          if (occurrences.ContainsKey(word)) {
            occurrences[word]++;
          }  else {
            occurrences[word] = 1;
          }
        }

        return occurrences;
    }
}