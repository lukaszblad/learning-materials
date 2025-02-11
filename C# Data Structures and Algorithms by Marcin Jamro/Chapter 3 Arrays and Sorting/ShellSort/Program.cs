Console.WriteLine("Shell Sort");

int[] myArray = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
Sort(myArray);
Console.WriteLine(string.Join(" | ", myArray));

void Sort(int[] a)
{
    // the array is divided in virtual subarrays, until they reach lenght 1
    for (int h = a.Length / 2; h > 0; h /= 2)
    {
        // looping over the second half of the virtual subarray
        for (int i = h; i < a.Length; i++)
        {
            int j = i; // index
            int ai = a[i]; // saves analyzed value

                //only second half and value at gap greater
            while (j >= h && a[j - h] > ai)
            {
                // moving the greater value right
                a[j] = a[j -h];
                j -= h;
            }
            a[j] = ai; // places the lesser value at the place of the grater one
        }
    }
}
