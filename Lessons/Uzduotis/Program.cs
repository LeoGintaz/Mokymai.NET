
var data = (DateTime.Today.ToString("yy/MM/dd"));




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

var dataIsAkodo = aKodas.Substring(1,6);
var yearAK = dataIsAkodo.Substring(0, 1);
var menuoAK = dataIsAkodo.Substring(2, 3);
var dienaAK = dataIsAkodo.Substring(4, 5);// isgryninimaas datos is AK i 3 atskirus string
                                          // ----------------------------------------------------------------------------------------
var toDay = DateTime.Today.ToString("yy/MM/dd");
toDay = toDay.Replace("/", "");
var toDayY = toDay.Substring(0, 1);
var toDayM = toDay.Substring(2, 3);
var toDayD = toDay.Substring(4, 5);// datos isskaidymas i tris atskirus string
                                   //-----------------------------------------------------------------------------------------

Console.WriteLine("įveskite savo amžių :");
var amzius = Console.ReadLine();
if (string.IsNullOrEmpty(amzius))
{
    Console.WriteLine("Įveskite savo gimimo datą : ");
    Console.WriteLine("Metai : ");
    var year = Console.ReadLine();
    Console.WriteLine("menuo (skaiciumi) : ");
    var menuo = Console.ReadLine();
    Console.WriteLine("diena : ");
    var diena = Console.ReadLine();


    if (string.IsNullOrEmpty(year) && string.IsNullOrEmpty(menuo) && string.IsNullOrEmpty(diena) == false)
    {

        if (int.Parse(toDayY) - int.Parse(yearAK) == int.Parse(toDayY) - int.Parse(year)
            && int.Parse(toDayM) - int.Parse(menuoAK) == int.Parse(toDayM) - int.Parse(menuo)
            && int.Parse(toDayD) - int.Parse(dienaAK) == int.Parse(toDayD) - int.Parse(diena))
            Console.WriteLine("amziuspatikimas");
        else Console.WriteLine("amzius nepatikimas");

    }
    else if (string.IsNullOrEmpty(amzius) == false)
    {
        if (int.Parse(toDayY) - int.Parse(yearAK) == int.Parse(toDayY) - int.Parse(amzius))
        {
            Console.WriteLine("amzius patikimas");
        }
        else Console.WriteLine("amzius nepatikimas");

    }

}



    





//Console.WriteLine("Įveskite gimimo metus: ");
//var gimimoDdata = DateTime.Parse(Console.ReadLine());










Console.WriteLine("ATASKAITA APIE ASMENĮ");
Console.WriteLine(DateTime.Today.ToString("yyyy/MM/dd"));
Console.WriteLine("Vardas, Pavardė");
Console.WriteLine("Lytis");
Console.WriteLine("Asmens Kodas");

Console.WriteLine("Amžius");
Console.WriteLine("Gimimo data");
Console.WriteLine("Amžiaus patikrinimas");