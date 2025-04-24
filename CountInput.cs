public class CountInput
{

    public int CountWords(List<KeyValuePair<string, int>> SortedInput)
    {
        int totalWords = 0;

        foreach (var kvp in SortedInput)
        {
            totalWords += kvp.Value;
        }

        return totalWords;
    }
}