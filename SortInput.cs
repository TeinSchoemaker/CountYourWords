public class SortInput
{

    public List<KeyValuePair<string, int>> Sort(Dictionary<string, int> InputOccurences)
    {

        var unsortedList = new List<KeyValuePair<string, int>>(InputOccurences);
        var sortedList = SortRoutine(unsortedList);

        return sortedList;
    }

    /* Borrowed from Interview Point
    // Compares every word in the list by checking if it's neighbour is higher on the list alphabetically
    // If higher then the order of the words is moved untill it becomes completely alphabetical
    */
    private List<KeyValuePair<string, int>> SortRoutine(List<KeyValuePair<string, int>> list)
    {

        var unsortedList = list;

        int n = list.Count;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (string.Compare(list[j].Key, list[j + 1].Key) > 0)
                {
                    var temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }


        return unsortedList;
    }
}