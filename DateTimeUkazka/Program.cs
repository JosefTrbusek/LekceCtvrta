// See https://aka.ms/new-console-template for more information
DateTime ted = DateTime.Now;
DateTime datum = new DateTime(2023, 2, 22, 8, 10, 50);
Console.WriteLine(ted.ToString("dd. MM. yyyy"));
Console.WriteLine("Dnes je: " + ted.DayOfWeek);
Console.WriteLine("Den v roce: " + ted.DayOfYear);

DateTime zaRok = ted.AddYears(1);
Console.WriteLine(zaRok.ToString("dd. MM. yyyy"));
Console.WriteLine("Dnes je: " + zaRok.DayOfWeek);
Console.WriteLine("Den v roce: " + zaRok.DayOfYear);

TimeSpan rozdilCasu = zaRok - ted;
Console.WriteLine("Casovy rozdil ve dnech: " + rozdilCasu.TotalDays);

Console.ReadLine();
