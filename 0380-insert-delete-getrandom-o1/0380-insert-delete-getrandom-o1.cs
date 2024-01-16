public class RandomizedSet {

HashSet<int> s;
    Random rando;

    public RandomizedSet() {
        s = new HashSet<int>();
        rando = new Random();
    }
    
    public bool Insert(int val) {
        return s.Add(val);
    }
    
    public bool Remove(int val) {
        return s.Remove(val);
    }
    
    public int GetRandom() {
        var options = new int[s.Count];
        s.CopyTo(options);
        return options[rando.Next(0, options.Length)];
    }
}
