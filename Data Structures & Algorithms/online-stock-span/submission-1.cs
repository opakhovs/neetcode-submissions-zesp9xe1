public class StockSpanner {
    private List<int> arr;

    public StockSpanner() {
        arr = new List<int>();
    }

    public int Next(int price) {
        arr.Add(price);
        int i = arr.Count - 2;

        while (i >= 0 && arr[i] <= price) {
            i--;
        }

        return arr.Count - i - 1;
    }
}