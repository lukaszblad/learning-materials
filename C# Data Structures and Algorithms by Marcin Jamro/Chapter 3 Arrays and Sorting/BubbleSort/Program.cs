Console.WriteLine("Bubble Sort");

int[] myArray = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
Sort(myArray);
Console.WriteLine(string.Join(" | ", myArray));

void Sort(int[] a)
{
    // first we need to iterate once over the entire array
    for (int i = 0; i < a.Length; i++)
    {
        // a flag to check if there was a change, otherwise the array is sorted
        bool change = false;
        for (int j = 0; j < a.Length - 1 - i;j++)
        {
            // swapping if compared values are not in order
            if (a[j] > a[j + 1])
            {
                change = true;
                int temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
            }
        }
        if(!change) {break;}
    }
}
