
namespace SuperSkaiciuotuvas
    
{
    public class Program
    {
        static double? rezultatas = null;

        static void Main(string[] args)
        {

            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            var expected = 50d;

            Program.Reset();
            foreach (var move in fake_moves)
            {
                Program.SuperSkaiciuotuvas(move);
            }
            var actual = Rezultatas();

           SuperSkaiciuotuvas().

            Console.WriteLine(@"
            [1] Nauja Operacija
            [2] Išeiti");
            //SuperSkaiciuotuvas(Ivedimas());






        }

        public static string Ivedimas()
        {
            {
                string? ivedimas = Console.ReadLine();
                if (ivedimas == null)
                {
                    ivedimas = "";
                }
                return ivedimas;

            }
        }

        public static void SuperSkaiciuotuvas(string ivedimas)
        {

            bool showMenu = true;
            while (showMenu == true)
            {



                switch (ivedimas)
                {
                    case "1":
                        Operacijos(ivedimas);
                        showMenu = true;
                        break;
                    case "2":
                        if (rezultatas == null)
                        {
                            Console.WriteLine("Operacija negalima");
                            showMenu = true;
                            break;
                        }
                        Operacijos2(ivedimas);
                        break;

                    case "3":
                        showMenu = false;
                        break;
                    default:
                        {

                            Console.WriteLine("            Negalimas pasirinkimas!");
                            showMenu = true;
                            break;
                        }


                }

            }
        }

        public static void Operacijos2(string ivedimas)
        {

            Console.WriteLine(@"
            [1] Sudėtis
            [2] Atimtis
            [3] Daugyba
            [4] Dalyba");

            switch (ivedimas)
            {
                case "1":
                    {

                        rezultatas = rezultatas + Ivestis2();
                        Console.WriteLine(rezultatas);
                        break;


                    }
                case "2":
                    {
                        rezultatas = rezultatas - Ivestis2();
                        Console.WriteLine(rezultatas);
                        break;
                    }
                case "3":
                    {
                        rezultatas = rezultatas * Ivestis2();
                        Console.WriteLine(rezultatas);
                    }
                    break;

                case "4":
                    {

                        var ivestis2 = Ivestis2();

                        if (ivestis2 == 0)
                        {
                            Console.WriteLine("Dalyba is nulio negalima");
                            break;
                        }
                        rezultatas = rezultatas / ivestis2;
                        Console.WriteLine(rezultatas);
                    }
                    break;
            }
        }

        public static void Operacijos(string ivedimas)
        {

            Console.WriteLine(@"
            [1] Sudėtis
            [2] Atimtis
            [3] Daugyba
            [4] Dalyba");

            switch (ivedimas)
            {
                case "1":
                    {

                        rezultatas = SuperSkaiciuotuvas(Ivestis()) + SuperSkaiciuotuvas(Ivestis());
                        Console.WriteLine(rezultatas);
                        break;


                    }
                case "2":
                    {
                        rezultatas = Ivestis() - Ivestis2();
                        Console.WriteLine(rezultatas);
                        break;
                    }
                case "3":
                    {
                        rezultatas = Ivestis() * Ivestis2();
                        Console.WriteLine(rezultatas);
                    }
                    break;

                case "4":
                    {
                        var ivestis = Ivestis();
                        var ivestis2 = Ivestis2();

                        if (ivestis2 == 0)
                        {
                            Console.WriteLine("Dalyba is nulio negalima");
                            break;
                        }
                        rezultatas = ivestis / ivestis2;
                        Console.WriteLine(rezultatas);
                    }
                    break;


            }
        }


        public static double Ivestis2()
        {
            Console.WriteLine("Įvesskite antrą skaičių");

            var input = double.TryParse(Console.ReadLine(), out double result);
            if (input == false)
            {

                Console.WriteLine("Negalima ivestis");
                Operacijos(Ivedimas());
            }

            return result;
        }
        public static double Ivestis()
        {

            Console.WriteLine("Įvesskite pirmą skaičių");

            var input = double.TryParse(Console.ReadLine(), out double result);
            if (input == false)
            {

                Console.WriteLine("Negalima ivestis");
                Operacijos(Ivedimas());
            }
            return result;
        }
        public static double Rezultatas()
        {
            return rezultatas ?? 0;
        }
        public static void Reset()
        {
            //todo
            rezultatas = null;
        }


    }
}

/* UzDuoties salygos
{
    /* ## Super Skaiciuotuvas ## 
        Sukurti skaiciuotuva. Ijungus programa turetume gauti pranešimą “
        1. Nauja operacija 2 Iseiti. 
        
        Pasirinkus 1 vada į submeniu:
        1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    
        Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius,
        o gale isvesti rezultata į ekraną. Po rezultato parodymo naudotojui parodomas submeniu su klausimu ar naudotojas nori atlikti nauja operacija ar testi su rezultatu. 
        1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
        Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. 
        Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.
    
    Pvz:
    > 1. Nauja operacija 2 Iseiti. 
    _1
    > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    _1
    > pasirinktas veiksmas + 
    > iveskite pirma skaiciu
    _15
    > iveskite antra skaiciu
    _45
    > Rezultatas: 60
    > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
    _2
    > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    _2
    > pasirinktas veiksmas - 
    > Iveskite skaiciu
    _10
    > Rezultatas: 50
    > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
    _1
    > 1. Sudetis 2. Atimtis 3. Daugyba 4. Dalyba
    _2
    > pasirinktas veiksmas * 
      > iveskite pirma skaiciu
    _2
    > iveskite antra skaiciu
    _3
    > Rezultatas: 6
    > 1. Nauja operacija 2. Testi su rezultatu 3. Iseiti
    _3
    > Baigta
     
    
    
    BONUS1: Iskelkite operacijas i metodus
    BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. 
            - dalyba is nulio, neteisingu ivesciu prevencija 
            - kada tikimasi gauti skaiciu, bet gaunamas char arba string.
            - neteisingas meniu punkto pasirinkimas
    BONUS3: Parasyti unit testus uztikrinant operaciju veikima
    BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas
    
       
public class Program
{
    static double? rezultatas = null;

    static void Main(string[] args)
    {

    }


    public static void SuperSkaiciuotuvas(string ivedimas)
    {
        //todo
    }

    public static double Rezultatas()
    {
        return rezultatas ?? 0;
    }
    public static void Reset()
    {
        //todo
        rezultatas = null;
    }



*/