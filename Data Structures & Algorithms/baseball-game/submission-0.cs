public class Solution {
    private static readonly string OPERATIONS = "+CD";

    public int CalPoints(string[] operations) {
        int res = 0;
        Stack<int> st = new Stack<int>();

        for (int i = 0; i < operations.Length; i++) {
            if (OPERATIONS.Contains(operations[i])) {
                if (operations[i] == "+") {
                    int a = st.Pop();
                    int b = st.Peek();
                    st.Push(a);
                    st.Push(a + b);
                    res += (a + b);
                } else if (operations[i] == "C") {
                    int a = st.Pop();
                    res -= a;
                } else {
                    int a = st.Peek();
                    st.Push(a * 2);
                    res += (a * 2);
                }
            } else {
                int val = Int32.Parse(operations[i]);
                st.Push(val);
                res += val;
            }
        }

        return res;
    }
}