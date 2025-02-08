using System.Diagnostics;

Console.WriteLine("Jagged arrays");

int[][] months = new int[12][];

for (int i = 0; i < 12; i++)
{
    int daysInMonth = DateTime.DaysInMonth(2025, i + 1);
    months[i] = new int[daysInMonth];
    for (int j = 0; j < daysInMonth; j++)
    {
        months[i][j] = j + 1;
        Console.Write(months[i][j]);
    }
    Console.WriteLine("");
}
