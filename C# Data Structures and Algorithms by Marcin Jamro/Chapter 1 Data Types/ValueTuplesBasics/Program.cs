Console.WriteLine("Value Tuples");

(int, int, double) result = Calculate(4, 8, 13);
Console.WriteLine($"Min = {result.Item1}, Max = {result.Item2}, Avg = {result.Item3}");

(int min, int max, double avg) = Calculate(4, 8, 13);
Console.WriteLine($"Min = {min}, Max = {max}, Avg = {avg}");


(int, int, double) Calculate(params int[] numbers)
{
    if (numbers.Length == 0)
    {
        return (0, 0, 0);
    }
    int min = int.MaxValue;
    int max = int.MinValue;
    int sum = 0;
    foreach (int number in numbers)
    {
        if (number > max) { max = number; }
        if (number < min) { min = number; }
        sum += number;
    }
    return (min, max, (double)sum / numbers.Length);
}
