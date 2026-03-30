public class Solution {
    public bool ValidPalindrome(string s) {
        int i = 0, j = s.Length - 1;
        bool hasMissmatch = false;

        while (i < j) {
            if (s[i] != s[j] && hasMissmatch) {
                return false;
            } else if (s[i] != s[j]) {
                hasMissmatch = true;
                if (s[i + 1] == s[j]) {
                    i++;
                } else if (s[i] == s[j - 1]) {
                    j--;
                } else {
                    return false;
                }
            }
            i++;
            j--;
        }

        return true;
    }
}