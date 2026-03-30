public class Solution {
    public int EvalRPN(string[] tokens) {
        int val = Int32.Parse(tokens[0]);

        for (int i = 1; i < tokens.Length; i+=2) {
            int temp = Int32.Parse(tokens[i]);
            if (tokens[i+1] == "-") {
                val -= temp;
            } else if (tokens[i+1] == "+") {
                val += temp;
            } else if (tokens[i+1] == "*") {
                val *= temp;
            } else if (tokens[i+1] == "/") {
                val /= temp;
            }
        }

        return val;
    }
}
