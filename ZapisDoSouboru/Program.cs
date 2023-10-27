//Toto je jednoducha verze reseni domaciho ukolu
//vytvořím si string pro cestu k souboru a s nazvem souboru
string cesta = @"C:\test\";
string soubor = "text.txt";

//zjistim jestli cesta neexistuje a v tom pripade ji vytvorim
if (!Directory.Exists(cesta))
{
    Directory.CreateDirectory(cesta);
}

Console.WriteLine("Zacni psat:");

//vytvorim si bool promennou signalizujici ze poslední nacteny radek je prazdny
bool jePrazdnyRadek = false;
while (!jePrazdnyRadek)
{
    string radek = Console.ReadLine();

    //pokud neni nacteny radek prazdny pridam ho na konec souboru spolu s odradkovanim
    //jinak nastavim promennou pro prazdny radek na true
    if (!string.IsNullOrEmpty(radek))
    {
        File.AppendAllText(cesta + soubor, radek + "\n");
    }
    else
    {
        jePrazdnyRadek = true;
    }
}

//vypisu obsah souboru.
Console.WriteLine();
Console.WriteLine("Toto je v souboru:");
Console.WriteLine(File.ReadAllText(cesta + soubor));
Console.ReadLine();
