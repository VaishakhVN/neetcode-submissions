public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char , int> count = new();
        foreach(char c in s)
        {
            if(count.ContainsKey(c))
            {
                count[c]++;
            }
            else
            {
                count[c] = 1;
            }
        }
        foreach(char c in t)
        {
            if(count.ContainsKey(c))
            {
                count[c]--;
            }
            else
            {
                return false;
            }
        }
        foreach(KeyValuePair<char, int> kvp in count)
        {
            if(count[kvp.Key] != 0)
            {
                return false;
            }
        }
        return true;
    }
}
