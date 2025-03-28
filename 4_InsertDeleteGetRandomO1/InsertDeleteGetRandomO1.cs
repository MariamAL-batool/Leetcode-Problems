public class RandomizedSet
{
    List<int> list;
    Dictionary<int, int> dictionary;

    public RandomizedSet()
    {
        list = new List<int>();
        dictionary = new Dictionary<int, int>();
    }

    public bool Insert(int val)
    {
        if (dictionary.ContainsKey(val))
            return false;
        else
        {
            list.Add(val);
            dictionary[val] = list.Count - 1;
            return true;
        }

    }

    public bool Remove(int val)
    {
        if (!dictionary.ContainsKey(val))
            return false;

        int index = dictionary[val];

        int lastVal = list[list.Count - 1];
        list[index] = lastVal;
        dictionary[lastVal] = index;
        list.RemoveAt(list.Count - 1);
        dictionary.Remove(val);
        return true;

    }

    public int GetRandom()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(list.Count);
        return list[randomIndex];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */