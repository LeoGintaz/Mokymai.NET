

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

Console.WriteLine("iveskite pazimi");
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

Console.WriteLine("iveskite pazimi");
var sk = Convert.ToInt32(Console.ReadLine());








