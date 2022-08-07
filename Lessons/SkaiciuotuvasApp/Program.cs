namespace SkaiciuotuvasApp
{
    public class Program
    {
        static double? rezultatas = null;

        static void Main(string[] args)

        {
            Console.ReadKey();

            //  var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            Console.WriteLine(@"
            [1] Nauja Operacija
            [2] Išeiti");
            
            SuperSkaiciuotuvas(Ivedimas());
        }

        public static string Ivedimas()
        {
            string? ivedimas = Console.ReadLine();
            if (ivedimas == null)
            {
                ivedimas = "";
            }
            return ivedimas;
            
        }

        public static void SuperSkaiciuotuvas(string ivedimas)
        {
            if (int.TryParse(ivedimas, out int result))
            {
                switch (result)
                {
                    case 1: //Nauja Operacija
                        {
                            Operacijos();

                        }
                        break;




                    case 2: // iseiti

                        break;
                }
            }
            else
            {
                Console.WriteLine("neteisingas  ivedimas");
                Ivedimas();
            }
          

        }
        public static void Tesimas()
        {
            Console.WriteLine($"1.Nauja Operacija \n 2.Testi su rezultatu \n 3.Iseiti");
            if (int.TryParse(Ivedimas(), out int result))
            {
                switch (result)
                {
                    case 1:
                        Reset();
                        Operacijos();
                        break;
                    case 2:
                        OperacijosTesiant();
                        break;
                    case 3:
                        break;


                }

            }
            else
            {
                Console.WriteLine("neteisingas  ivedimas");
                Ivedimas();
            }
            switch (result)
            {
                case 1:
                    Reset();
                    Operacijos();
                    break;
                case 2:
                    OperacijosTesiant();
                    break;
                case 3:
                    break;
            
            
            }


        }

        public static void Operacijos()
        {
            Console.WriteLine("1 Sudetis \n 2aimis ");

            if (int.TryParse(Ivedimas(), out int result2))
                switch (result2)
                {
                    case 1: //Sudetis
                        {
                            Console.WriteLine("Iveskite pirma skaiciu");
                            double.TryParse(Ivedimas(), out double atimtis);
                            Console.WriteLine("Iveskite antra skaiciu");
                            double.TryParse(Ivedimas(), out double atimtis2);
                            rezultatas = atimtis + atimtis2;

                            Console.WriteLine(rezultatas);
                            Tesimas();
                            break;
                        }
                    case 2: // atimtis
                        {
                            Console.WriteLine("Iveskite pirma skaiciu");
                            double.TryParse(Ivedimas(), out double atimtis);
                            Console.WriteLine("Iveskite antra skaiciu");
                            double.TryParse(Ivedimas(), out double atimtis2);
                            rezultatas = atimtis - atimtis2;

                            Console.WriteLine(rezultatas);
                            Tesimas();
                            break;
                        }
                }

            else
            {
                Console.WriteLine("neteisingas  ivedimas");
                Ivedimas();
            }
        }
        private static void OperacijosTesiant()
        {
            Console.WriteLine("1 Sudetis \n 2aimis ");

            if (int.TryParse(Ivedimas(), out int result2))
                switch (result2)
                {
                    case 1: //Sudetis
                        {
                            
                            Console.WriteLine("Iveskite antra skaiciu");
                            double.TryParse(Ivedimas(), out double atimtis2);
                            rezultatas = rezultatas + atimtis2;

                            Console.WriteLine(rezultatas);
                            Tesimas();
                            break;
                        }
                    case 2: // atimtis
                        {
                           
                            Console.WriteLine("Iveskite antra skaiciu");
                            double.TryParse(Ivedimas(), out double atimtis2);
                            rezultatas = rezultatas - atimtis2;

                            Console.WriteLine(rezultatas);
                            Tesimas();
                            break;
                        }
                }

            else
            {
                Console.WriteLine("neteisingas  ivedimas");
                Ivedimas();
            }
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