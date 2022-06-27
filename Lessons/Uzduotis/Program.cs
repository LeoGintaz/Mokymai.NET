
Console.WriteLine("Užpildykite ankeetą\n\n");
Console.WriteLine("Įveskite savo vardą: ");
string name = Console.ReadLine();
Console.WriteLine("Įveskite saavo pavardę: ");
string surname = Console.ReadLine();
Console.WriteLine($"Įveskite asmens kodą : ");
var aKodas = Console.ReadLine();
int ilgis = aKodas.Length;
if (ilgis != 11)
    Console.WriteLine("neteisingai įvestas asmens kodas");
string vyras = "Vyras";
string moteris = "Moteris";
var pirmas = aKodas.Remove(1,10);
var pirmas2 = Convert.ToInt32(pirmas);
if (pirmas == "1")
    Console.WriteLine(vyras);
else if (pirmas == "3")
    Console.WriteLine(vyras);
else if (pirmas == "5")
    Console.WriteLine(vyras);
if (pirmas == "2")
    Console.WriteLine(moteris);
else if (pirmas == "4")
    Console.WriteLine(moteris);
else if (pirmas == "6")
    Console.WriteLine(moteris);







Console.WriteLine("ATASKAITA APIE ASMENĮ");
Console.WriteLine(DateTime.Today.ToString("yyyy/MM/dd"));
Console.WriteLine("Vardas, Pavardė");
Console.WriteLine("Lytis");
Console.WriteLine("Asmens Kodas");

Console.WriteLine("Amžius");
Console.WriteLine("Gimimo data");
Console.WriteLine("Amžiaus patikrinimas");