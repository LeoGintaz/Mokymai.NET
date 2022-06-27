
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
var pirmas = aKodas[0];
var pirmas2 = Convert.ToInt32(pirmas);
if  (pirmas2 == 49)
    if (pirmas2 == 51)
        if (pirmas2 == 53)
            Console.WriteLine(vyras);
else if (pirmas2 == 50)
            if (pirmas2 == 52)
                if (pirmas2 == 54)
                    Console.WriteLine(moteris);






Console.WriteLine("ATASKAITA APIE ASMENĮ");
Console.WriteLine(DateTime.Today.ToString("yyyy/MM/dd"));
Console.WriteLine("Vardas, Pavardė");
Console.WriteLine("Lytis");
Console.WriteLine("Asmens Kodas");

Console.WriteLine("Amžius");
Console.WriteLine("Gimimo data");
Console.WriteLine("Amžiaus patikrinimas");