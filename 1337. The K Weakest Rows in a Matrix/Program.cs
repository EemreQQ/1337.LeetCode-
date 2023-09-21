public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        int[] orderedRow = new int[mat.GetLength(0)];
        var counter = 0;
        for (var i = 0; i < mat.GetLength(0); i++)
        {
            for (var j = 0; j < mat[1].Length; j++)
            {
                if (mat[i][j] == 1)
                {
                    counter++;
                }
            }
            orderedRow[i] = counter;
            counter = 0;
        }
        List<int> result = new List<int>(orderedRow);
        result.Sort();
        List<int> arr = new List<int>();
        for (var i = 0; i < k; i++)
        {
            var Index = Array.FindIndex(orderedRow.ToArray(), x => x == result[i]);
            arr.Add(Index);
            orderedRow[Index] = -1;
        }
        return arr.ToArray();
    }
}