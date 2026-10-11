public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int m = s1.Length;
        int n = s2.Length;

        if(m > n)
            return false;

        int[] s1freq= new int[26];
        int[] winfreq = new int[26];

        for(int i = 0; i< m; i++)
        {
            s1freq[s1[i] - 'a']++;
            winfreq[s2[i] - 'a']++;
        }

        if(s1freq.SequenceEqual(winfreq))
            return true;

        for(int right = m; right < n; right++)
        {
            winfreq[s2[right] - 'a']++;

            winfreq[s2[right - m] - 'a']--;

            if(s1freq.SequenceEqual(winfreq))
                return true;
        }
        return false;
    }
}
