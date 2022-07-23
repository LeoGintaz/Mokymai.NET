namespace SuperSkaiciuotuvas
{
    public class Program
    {
        static double? rezultatas = null;

        static void Main(string[] args)
        {
            SuperSkaiciuotuvas();





        }



        public static void SuperSkaiciuotuvas()
        {

            bool showMenu = true;
            while (showMenu == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
            [1] Nauja Operacija
            [2] Išeiti");
                switch (Console.ReadLine())
                {
                    case "1":
                        Operacijos();
                        showMenu = true;
                        break;
                    case "2":
                        showMenu = false;
                        break;
                    default:
                        {
                            //////////////////////////////////////////////////
                            Console.Clear();/////////////////////////////////
                            Console.ForegroundColor = ConsoleColor.Red;/////
                            ///////////////////////////////////////////////
                            Console.WriteLine("            Negalimas pasirinkimas!");
                            showMenu = true;
                            break;
                        }


                }

            }
        }
        private static void Operacijos()
        {
            Console.WriteLine(@"
            [1] Sudėtis
            [2] Atimtis
            [3] Daugyba
            [4] Dalyba");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        var input1 = double.TryParse(Program.Ivestis(), out double result);
                        var input2 = double.TryParse(Program.Ivestis2(), out double result2);
                        if (input1 == false || input2 == false) 
                        {
                            Console.WriteLine("Negalima ivestis");


                        }
                        else
                        {
                            var sudetis = result + result2;
                            Console.WriteLine(sudetis);
                        }
                        break;
                    }
                case "2":
                    {
                        var input1 = double.TryParse(Program.Ivestis(), out double result);
                        var input2 = double.TryParse(Program.Ivestis2(), out double result2);
                        if (input1 == false || input2 == false)
                        {
                            Console.WriteLine("Negalima ivestis");


                        }
                        else
                        {
                            var sudetis = result - result2;
                            Console.WriteLine(sudetis);
                        }
                        break;
                    }
                case "3":
                    {
                        var input1 = double.TryParse(Program.Ivestis(), out double result);
                        var input2 = double.TryParse(Program.Ivestis2(), out double result2);
                        if (input1 == false || input2 == false)
                        {
                            Console.WriteLine("Negalima ivestis");


                        }
                        else
                        {
                            var sudetis = result * result2;
                            Console.WriteLine(sudetis);
                        }
                        break;
                    }
                
                case "4":
                    {
                        var input1 = double.TryParse(Program.Ivestis(), out double result);
                        var input2 = double.TryParse(Program.Ivestis2(), out double result2);
                        if (input1 == false || input2 == false)
                        {
                            Console.WriteLine("Negalima ivestis");


                        }
                        else
                        {
                            var sudetis = result / result2;
                            Console.WriteLine(sudetis);
                        }
                        break;
                    }
                    break;


            }
        }


        public static string? Ivestis2()
        {
            Console.WriteLine("             Įvesskite antrą skaičių");
            var input = Console.ReadLine();
           
            return input;
        }
        public static string? Ivestis()
        {
            Console.WriteLine("             Įvesskite pirmą skaičių");
            var input = Console.ReadLine();
            return input;
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