using System.Globalization;

Console.WriteLine("Single dimensional arrays");

CultureInfo culture = new("en");
string[] months = new string[12];
for (int month = 1; month < 12; month++)
{
    DateTime firstDay = new(DateTime.Now.Year, month, 1);
    string name = firstDay.ToString("MMMM", culture);
    months[month - 1] = name;
}
foreach(string m in months)
{
    Console.WriteLine(m);
}
