using BasicRecord;

Console.WriteLine("Basic Record");
// records are a data-centric data type and are intended to be immutable,
// providing a short and clear syntax

Dog saba = new("Saba", "Bulldog", 40, 11, 10);
Console.WriteLine(saba);

Dog dolly = saba with {Name = "Dolly", Age = 7};
