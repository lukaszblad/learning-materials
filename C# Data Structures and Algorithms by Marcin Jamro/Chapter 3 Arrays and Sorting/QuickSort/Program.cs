Console.WriteLine("Quick Sort");

int[] myArray = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
Sort(myArray);
Console.WriteLine(string.Join(" | ", myArray));

void Sort(int[] a)
{
    SortPart(a, 0, a.Length - 1);
}

void SortPart(int[] a, int l, int u)
{
    // base case
    if (l >= u) { return; }

    int pivot = a[u];
    int j = l - 1;
    for (int i = l; i < u; i++)
    {
        if (a[i] < pivot)
        {
            j++;
            (a[j], a[i]) = (a[i], a[j]);
        }
        int p = j + 1;
        (a[p], a[u]) = (a[u], a[p]);
        SortPart(a, l, p - 1);
        SortPart(a, p + 1, u);
    }
}
