// See https://aka.ms/new-console-template for more information
char znak = 'a';
Console.WriteLine("Je pismeno: " + char.IsLetter(znak));
Console.WriteLine("Je velke pismeno: " + char.IsUpper(znak));
Console.WriteLine("Je číslo:" + char.IsNumber(znak));
Console.WriteLine("Je bílý znak: " + char.IsWhiteSpace(znak));
Console.ReadLine();
