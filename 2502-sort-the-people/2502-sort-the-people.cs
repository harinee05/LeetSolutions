public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
       var details = names.Zip(heights, (name, height) => new { Name = name, Height = height })
                          .OrderByDescending(person => person.Height)
                          .ToList();
        
        return details.Select(p => p.Name).ToArray();
    }
}