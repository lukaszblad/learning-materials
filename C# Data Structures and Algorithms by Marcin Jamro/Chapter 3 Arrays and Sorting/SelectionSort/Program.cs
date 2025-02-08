Console.WriteLine("Selection sort");

int[] myArray = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
Sort(myArray);
Console.WriteLine(string.Join(" | ", myArray));

void Sort(int[] a)
{
    for (int i = 0; i <a.Length -1; i++)
    {
        int minIndex = i;
        int minValue = a[i];
        for (int j = i + 1; j < a.Length; j++)
        {
            if (a[j] < minValue)
            {
                minIndex = j;
                minValue = a[j];
            }
            int temp = a[i];
            a[i] = a[minIndex];
            a[minIndex] = temp;
        }
    }
}
