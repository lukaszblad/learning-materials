using System.Globalization;

Console.WriteLine("Merge Sort");

int[] myArray = [-11, 12, -42, 0, 1, 90, 68, 6, -9];
Sort(myArray);
Console.WriteLine(string.Join(" | ", myArray));

int[] GetSubArray(int[] a, int si, int ei)
{
    // declare new array
    int arrayLength = ei - si + 1;
    int[] result = new int[arrayLength];
    // fill the array
    for (int i = 0; i < arrayLength; i++)
    {
        result[i] = a[si + i];
    }
    return result;
}

void Sort(int[] a)
{
    // base case for the recursive algorotihm
    if (a.Length <= 1) {return;}

    // divide the arrays
    int arraysMiddle = a.Length / 2;
    int[] leftArray = GetSubArray(a, 0, arraysMiddle - 1);
    int[] rightArray = GetSubArray(a, arraysMiddle, a.Length - 1);

    // call the sort algorithm recursively to divide the arrays till the end
    Sort(leftArray);
    Sort(rightArray);

    // now the arrays need to be merged
    int i = 0, j = 0, k = 0;
    while (i < leftArray.Length && j < rightArray.Length)
    {
        if (leftArray[i] <= rightArray[j]) {a[k] = leftArray[i++];}
        else {a[k] = rightArray[j++];}
        k++;
    }
    while (i < leftArray.Length) { a[k++] = leftArray[i++]; }
    while (j < rightArray.Length) { a[k++] = rightArray[j++]; }   
}
