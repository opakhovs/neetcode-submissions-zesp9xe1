using System.Text;

public class Solution
{
    public string DecodeString(string s)
    {
        int i = 0;
        return Recursive(s, ref i);
    }

    private string Recursive(string s, ref int i)
    {
        StringBuilder decodedStr = new StringBuilder();

        while (i < s.Length && s[i] != ']')
        {
            if (IsDigit(s[i]))
            {
                int quantity = 0;
                while (i < s.Length && IsDigit(s[i]))
                {
                    quantity = quantity * 10 + (s[i] - '0');
                    i++;
                }
                i++;
                string inner = Recursive(s, ref i);
                i++;
                for (int j = 0; j < quantity; j++)
                {
                    decodedStr.Append(inner);
                }
            }
            else
            {
                decodedStr.Append(s[i]);
                i++;
            }
        }

        return decodedStr.ToString();
    }

    private bool IsDigit(char value)
    {
        return value >= '0' && value <= '9';
    }
}