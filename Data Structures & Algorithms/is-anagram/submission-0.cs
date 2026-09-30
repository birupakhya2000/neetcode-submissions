public class Solution {
    public bool IsAnagram(string s, string t) {

        int[] count = new int[26];
        foreach(char c in s)
        {
            count[c - 'a']++;
        }

        foreach(char c in t)
        {
            count[c - 'a']--;
        }

        foreach(var value in count)
        {
            if(value != 0)
                return false;
        }
        return true;
    }
}
