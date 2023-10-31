namespace HW4;

public class ShellSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;
        int gap = n / 2;

        SortRecursive(arr, n, gap);
    }

    private static void SortRecursive(int[] arr, int n, int gap)
    {
        if (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j = i;

                while (j >= gap && arr[j - gap] > temp)
                {
                    arr[j] = arr[j - gap];
                    j -= gap;
                }

                arr[j] = temp;
            }

            SortRecursive(arr, n, gap / 2);
        }
    }
}
