













































/*
Console.WriteLine("Hello, World!");


Console.WriteLine("iveskite skaiciu");
int skaicius = Convert.ToInt32(Console.ReadLine());
if (skaicius %2 == 0)
{

    Console.WriteLine("skaicius yra lyginis");
}
if (skaicius < 0)
    Console.WriteLine("skaicius yra neigimas");
if (skaicius % 2 != 0 && skaicius > 0)
    Console.WriteLine(skaicius);*/
/*
Console.WriteLine("iveskite grupes nariu skaiciu");
int skaicius = Convert.ToInt32(Console.ReadLine());

if (skaicius == 1)
    Console.WriteLine("tai solo act");
else if (skaicius == 2)
    Console.WriteLine("tai duetas");
else if (skaicius > 2 && skaicius < 10)
    Console.WriteLine("tai ansamblis");
else Console.WriteLine("tai kamerinis");*/

Console.WriteLine("iveskite isdirbtas valandas");
int skaicius = Convert.ToInt32(Console.ReadLine());

if (skaicius < 160) {
    int truk = 160 - skaicius;
    Console.WriteLine("truksta" + truk);
}

else if (skaicius > 160)
{
    int truk = skaicius - 160;
    Console.WriteLine("virsvalandziai" + truk);
}
else if (skaicius == 160)
{
    
    Console.WriteLine("isdirbtas pilnas etatas");
}


else Console.WriteLine("negalimas skaicius")
