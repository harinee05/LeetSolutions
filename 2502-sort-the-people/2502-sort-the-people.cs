public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
       var details = names.Zip(heights, (name, height) => new { Name = name, Height = height })
                          .OrderByDescending(person => person.Height)
                          .ToList();
        string[] sortedDetails = details.Select(p => p.Name).ToArray();
        return sortedDetails;
    }
}