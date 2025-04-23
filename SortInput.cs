public class SortInput {

    public List<KeyValuePair<string, int>> Sort(Dictionary<string, int> InputOccurences) {

        var unsortedList = new List<KeyValuePair<string, int>>(InputOccurences);
        var sortedList = SortRoutine(unsortedList);

        return sortedList;
    }

    // Shamefully stolen from Interview Point
    private List<KeyValuePair<string, int>> SortRoutine(List<KeyValuePair<string, int>> list) {
        
        var unsortedList = list;
        
        int n = list.Count;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - 1; j++) {
                if (string.Compare(list[j].Key, list[j + 1].Key) > 0) {
                    var temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
        

        return unsortedList;
    }
}