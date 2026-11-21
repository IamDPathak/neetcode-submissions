public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int j = 0;
        HashSet<char> hs = new HashSet<char>();

        int longestLength = 0;
        for(int i = 0; i < s.Length; i++){
            while(hs.Contains(s[i])){
                hs.Remove(s[j]);
                j++;
            }
            hs.Add(s[i]);

            longestLength = Math.Max(longestLength, hs.Count);
        }

        return longestLength;
    }
}