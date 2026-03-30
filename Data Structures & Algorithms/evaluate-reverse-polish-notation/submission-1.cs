public class Solution {
    private static readonly string OPERATIONS = "-+/*";
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new Stack<int>();

        for (int i = 0; i < tokens.Length; i++) {
            if (!OPERATIONS.Contains(tokens[i])) {
                st.Push(Int32.Parse(tokens[i]));
            } else {
                int temp = st.Pop();
                int val = st.Pop();
                if (tokens[i] == "-") {
                    val -= temp;
                } else if (tokens[i] == "+") {
                    val += temp;
                } else if (tokens[i] == "*") {
                    val *= temp;
                } else if (tokens[i] == "/") {
                    val /= temp;
                }
                st.Push(val);
            }
        }

        return st.Pop();
    }
}
