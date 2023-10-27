//vytvoreni prazdneho listu
List<string> jmena = new List<string>();
//Následujícím způsobem můžu vytvořit list s hodnotami
List<string> jmena2 = new List<string>() { "Jirka", "Pepa", "Jana" };
//pridání polozek listu
jmena.Add("Jirka");
jmena.Add("Pepa");
jmena.Add("Jana");
jmena.Add("David");
jmena.Add("Lukas");
jmena.Add("Lucka");

//kopírování listu.
List<string> kopieJmena = new List<string>();
//Můžu udělat pomocí cyklu kdy zrojový list procházím a přidávám do cílového
//foreach(string jmeno in jmena)
//{
//    kopieJmena.Add(jmeno);
//}
//nebo mohu použít funkci AddRange
kopieJmena.AddRange(jmena);

//takto nevytvořím kopii ale budu z jiné proměnné ukazovat na stejné místo v paměti kde je list uložený (tzv. reference)
//tím pádem co se odehraje pro jednu proměnnou stane se i s druhou
List<string> kopie2 = jmena;

//Vypsání počtu položek
Console.WriteLine("Pocet jmen: " + jmena.Count);

//smazání položek: RemoveAt pomocí indexu, Remove přímo zmíněné položky
jmena.RemoveAt(0);
jmena.Remove("Pepa");
//Clear maže veškerý obsah listu
//jmena.Clear();

//Remove Range maze obsah od indexu a pocet položek od něj
jmena.RemoveRange(3, 1);

//vložení položky na přímo zmíněný index
jmena.Insert(1, "Pepa");
//výpis indexu na kterém položka je a zda je položka v listu
Console.WriteLine("Jana je na indexu: " + jmena.IndexOf("Jana"));
Console.WriteLine("Jirka je seznamu: " + jmena.Contains("Jirka"));

//list lze celý vypsat dobře pomocí cyklu foreach nebo i for
Console.WriteLine("Puvodni seznam:");
foreach (string jmeno in kopie2)
{
    Console.WriteLine(jmeno);
}
Console.WriteLine();
foreach (string jmeno in kopieJmena)
{
    Console.WriteLine(jmeno);
}
Console.WriteLine();
foreach (string jmeno in jmena)
{
    Console.WriteLine(jmeno);
}

//for(int i = 0;i < jmena.Count; i++)
//{
//    Console.WriteLine(jmena[i]);
//}


Console.ReadLine();