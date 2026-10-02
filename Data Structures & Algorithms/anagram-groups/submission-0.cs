public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();

        foreach(string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);

            string key = new string(chars);

            if(!dict.ContainsKey(key))
            {
                dict[key] = new List<string>();
            }

            dict[key].Add(str);
        } 

        return dict.Values.ToList<List<string>>();
    }
}
