Console.WriteLine("Insertion sort");

int[] myArray = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
Sort(myArray);
Console.WriteLine(string.Join(" | ", myArray));

void Sort(int[] a)
{
    // we need to start a loop over the entire array, but we start at the second
    // positions, because we are comparing to the left
    for (int i = 1; i < a.Length; i++)
    {
        // the current position needs to be compared against the previous positions
        // until it finds a smaller value
        int currentIndex = i;
        while (currentIndex > 0 && a[currentIndex] < a[currentIndex - 1])
        {
            int temp = a[currentIndex - 1];
            a[currentIndex - 1] = a[currentIndex];
            a[currentIndex] = temp;
            currentIndex--;
        }
    }
}
