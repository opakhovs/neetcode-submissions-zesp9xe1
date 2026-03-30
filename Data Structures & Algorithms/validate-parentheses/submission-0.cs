public class Solution {
    private static readonly List<char> opens = new List<char>{'{', '(', '['};
    private static readonly List<char> closed = new List<char>{'}', ')', ']'};

    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();

        foreach (char c in s) {
            if (opens.Contains(c)) {
                st.Push(c);
            } else {
                char toComp = st.Pop();

                if (toComp == '{' && c != '}' || toComp == '[' && c != ']' || toComp == '(' && c != ')') {
                    return false;
                }
            }
        }

        return true;
    }
}
