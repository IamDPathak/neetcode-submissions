public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int j = 0;
        HashSet<char> hs = new HashSet<char>();

        int longestLength = 0;
        for(int i = 0; i < s.Length; i++){
            if(!hs.Contains(s[i])){
                hs.Add(s[i]);
            } else {
                hs.Remove(s[j]);
                j++;
                i--;
            }

            longestLength = Math.Max(longestLength, hs.Count);
        }

        return longestLength;
    }
}
