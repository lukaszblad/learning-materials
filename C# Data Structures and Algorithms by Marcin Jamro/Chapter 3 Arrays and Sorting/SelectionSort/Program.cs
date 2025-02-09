Console.WriteLine("Selection sort");

int[] myArray = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
Sort(myArray);
Console.WriteLine(string.Join(" | ", myArray));

void Sort(int[] a)
{
    // outer loop that cycles the entire array except the last positio, that 
    // will be automatically sorted at the end
    for (int i = 0; i < a.Length - 1; i++)
    {
        // we need to store the current minimum value index for further comparison
        int savedMinimumValueIndex = i;
        
        // now we need to loop over the entire unsorted part, looking for
        // smaller values
        for (int j = i; j < a.Length; j++)
        {
            if (a[j] < a[savedMinimumValueIndex])
            {
                savedMinimumValueIndex = j;
            }
        }
        // once the entire unsorted array has been checked, we have
        // the actual minimum value. We can swap it with the first position
        // of the unsorted array and it will become part of the sorted array
        // with the next iteration of the outer loop
        int temp = a[i];
        a[i] = a[savedMinimumValueIndex];
        a[savedMinimumValueIndex] = temp;
    }
}
