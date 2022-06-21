

Console.WriteLine("2020-06-21");
/*
Console.WriteLine("hello swich");
Console.WriteLine("iveskite meniu punkta");
int menuChoice = Convert.ToInt32(Console.ReadLine());
switch (menuChoice)
{
    case 1:
        Console.WriteLine("1");
        Console.WriteLine("dar kazkas");
        break;
    case 2:
        Console.WriteLine("2");
        break;
    case 3:
        Console.WriteLine("3");
        break;
    case 4:
        Console.WriteLine("4");
        break;
    default:
        Console.WriteLine("klaida");
        break ;

}
Console.WriteLine("------------------");
var resultatas = menuChoice switch
{
    1 => "1",
    2 => "2",
    3 => "3",
    _ => "nieko nepasirinko"
};
Console.WriteLine("------------");
*/

/*Console.WriteLine("iveskite pazimi");
int nr = Convert.ToInt32(Console.ReadLine());
if (nr >=0 && nr < 5)
    Console.WriteLine("nepatenkinamai");
else if (nr == 5)
    Console.WriteLine("patenkinamai");
else if (nr == 6)
    Console.WriteLine("silpnai");
else if (nr == 7)
    Console.WriteLine("vidutiniskai");
else if (nr == 8)
    Console.WriteLine("gerai");
else if (nr == 9)
    Console.WriteLine("labai gerai");
else if (nr == 10)
    Console.WriteLine("puikiai");
else
    Console.WriteLine("netinkamas skaicius");

Console.WriteLine("--------------------");

Console.WriteLine("pasirinkite pazimi");
Console.WriteLine("1\n2\n3\n4\n5\n6\n7\n8\n9\n10");
int menuChoice = Convert.ToInt32(Console.ReadLine());
switch (menuChoice) {

    case 1:
    case 2:
    case 3:
    case 4:
        Console.WriteLine("nepatenkinamas");
        break;
    case 5:
        Console.WriteLine("patenkinamas");
        break;
    case 6:
        Console.WriteLine("silpnai");
        break;
    case 7:
        Console.WriteLine("vidutiniskai");
        break;
    case 8:
        Console.WriteLine("gerai");
        break;
    case 9:
        Console.WriteLine("labai gerai");
        break;
    case 10:
        Console.WriteLine("puikiai");
        break;
    default: Console.WriteLine("toks pazimys neegzistuoja");
        break;
}
*/

/*
Console.WriteLine("Atspėk skaičių!!!!");


int ats = 15;

Console.WriteLine("\n\n\n Įveskite skaičių nuo 1 iki 20");
int spejimas = Convert.ToInt32(Console.ReadLine());


if (spejimas == ats)
    Console.WriteLine("Atspėjote teisingai");
else if (spejimas != ats && spejimas < ats)
    Console.WriteLine("Atsakymas yra didesnis, bandykite dar kartą (liko 5 spėjimai)");
else if (spejimas != ats && spejimas > ats)
    Console.WriteLine("Atsakymas yra mazesnis , bandykite dar kartą (liko 5 spėjimai)");
else Console.WriteLine("Įvedėte netinkamą skaičių");
spejimas = Convert.ToInt32(Console.ReadLine());

if (spejimas == ats)
    Console.WriteLine("Atspėjote teisingai");
else if (spejimas != ats && spejimas < ats)
    Console.WriteLine("Atsakymas yra didesnis, bandykite dar kartą (liko 4 spėjimai)");
else if (spejimas != ats && spejimas > ats)
    Console.WriteLine("Atsakymas yra mazesnis , bandykite dar kartą (liko 4 spėjimai)");
else Console.WriteLine("Įvedėte netinkamą skaičių");
spejimas = Convert.ToInt32(Console.ReadLine());

if (spejimas == ats)
    Console.WriteLine("Atspėjote teisingai");
else if (spejimas != ats && spejimas < ats)
    Console.WriteLine("Atsakymas yra didesnis, bandykite dar kartą (liko 3 spėjimai)");
else if (spejimas != ats && spejimas > ats)
    Console.WriteLine("Atsakymas yra mazesnis , bandykite dar kartą (liko 3 spėjimai)");
else Console.WriteLine("Įvedėte netinkamą skaičių");
spejimas = Convert.ToInt32(Console.ReadLine());

if (spejimas == ats)
    Console.WriteLine("Atspėjote teisingai");
else if (spejimas != ats && spejimas < ats)
    Console.WriteLine("Atsakymas yra didesnis, bandykite dar kartą (liko 2 spėjimai)");
else if (spejimas != ats && spejimas > ats)
    Console.WriteLine("Atsakymas yra mazesnis , bandykite dar kartą (liko 2 spėjimai)");
else Console.WriteLine("Įvedėte netinkamą skaičių");
spejimas = Convert.ToInt32(Console.ReadLine());

if (spejimas == ats)
    Console.WriteLine("Atspėjote teisingai");
else if (spejimas != ats && spejimas < ats)
    Console.WriteLine("Atsakymas yra didesnis, bandykite dar kartą (liko 1 spėjimai)");
else if (spejimas != ats && spejimas > ats)
    Console.WriteLine("Atsakymas yra mazesnis , bandykite dar kartą (liko 1 spėjimai)");
else Console.WriteLine("Įvedėte netinkamą skaičių");
spejimas = Convert.ToInt32(Console.ReadLine());

if (spejimas == ats)
    Console.WriteLine("Atspėjote teisingai");
else if (spejimas != ats)
    Console.WriteLine("Neatspėjote");
else Console.WriteLine("Įvedėte netinkamą skaičių");*/


Console.WriteLine("įveskite pirmą skaičių");
int pirmasSk = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("įveskite antrą skaičių");
int antrasSk = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("įveskite operatorių + , - , * arba /");
var operatorius = Console.ReadLine();

if (operatorius == "+")
{
    var pridet = pirmasSk + antrasSk;
    Console.WriteLine(pridet);
}
else if (operatorius == "-")
{
    var atimt = pirmasSk - antrasSk;
    Console.WriteLine(atimt);
}
else if (operatorius == "*")
{
    var daug = pirmasSk * antrasSk;
    Console.WriteLine(daug);
}
else if (operatorius == "/")
{
    double dal = (double)pirmasSk / (double)antrasSk;
    Console.WriteLine(dal);
}
else Console.WriteLine("Klaida");








