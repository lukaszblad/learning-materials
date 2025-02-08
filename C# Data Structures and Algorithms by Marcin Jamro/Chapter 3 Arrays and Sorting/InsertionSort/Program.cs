Console.WriteLine("Insertion sort");

int[] myArray = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
Sort(myArray);
Console.WriteLine(string.Join(" | ", myArray));

void Sort(int[] a)
{
    for (int i = 1; i < a.Length; i++)
    {
        int j = i;
        while (j > 0 && a[j] < a[j -1])
        {
            int temp = a[j];
            a[j] = a[j - 1];
            a[j - 1] = temp;
            j--;
        }
    }
}
