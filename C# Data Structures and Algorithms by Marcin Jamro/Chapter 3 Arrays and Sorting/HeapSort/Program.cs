Console.WriteLine("Heap Sort");

int[] myArray = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
Sort(myArray);
Console.WriteLine(string.Join(" | ", myArray));

void Heapify(int[] a, int n, int i)
{
    int max = i;
    int l = 2 * i + 1;
    int r = 2 * i + 2;
    max = l < n && a[l] > a[max] ? l : max;
    max = r < n && a[r] > a[max] ? r : max;
    if (max != i)
    {
        (a[i], a[max]) = (a[max], a[i]);
        Heapify(a, n, max);
    }
}

void Sort(int[] a)
{
    for (int i = a.Length / 2 - 1; i >= 0; i--)
    {
        Heapify(a, a.Length, i);
    }
    for (int i = a.Length - 1; i > 0; i--)
    {
        (a[0], a[i]) = (a[i], a[0]);
        Heapify(a, i, 0);
    }
}
