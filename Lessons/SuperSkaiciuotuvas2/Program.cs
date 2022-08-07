
namespace SuperSkaiciuotuvas2
    
{
    public class Program
    {
        static double? rezultatas = null;
        static List<string> input = new List<string>();
        static void Main(string[] args)
        {


            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            foreach (var move in fake_moves)
            {
                SuperSkaiciuotuvas(move);
            }

            Rezultatas();



        }
        public static void SuperSkaiciuotuvas(string ivedimas)

        {

            input.Add(ivedimas);
            MainMenu();
        }

        public static void MainMenu()
        {
            switch (input[0])
            { 
            case "1"://Nauja Operacija
                    switch (input[1])
                    {
                        case "1"://Sudetis
                            double sk1 = double.Parse(input[2]);
                            double sk2 = double.Parse(input[3]);

                            rezultatas = sk1 + sk2;
                            switch (input[4])
                            {
                                case "2"://Testi su Rezultatu
                                    switch (input[5])
                                    {
                                        case "2"://Atimttis
                                            
                                            double sk4 = double.Parse(input[6]);

                                            rezultatas = rezultatas - sk4;
                                            switch (input[7])
                                            {
                                                case "3"://iseiti
                                                    break;
                                            }
                                            break;

                                    }
                                    break;
                            }
                            break;

                    }
                    break;
            
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

/*
 string? ivestis = null;
            bool showMenu = true;
            while (showMenu == true)
            {
                Console.WriteLine("1. NAUJA OPEERACIJA 2.Iseiti");
                ivestis = Console.ReadLine();
                if (ivestis == "2")
                    showMenu = false;
                else
                {
                    Console.WriteLine("1Sudetis 2.Atimtis");
                    ivestis = ivestis + Console.ReadLine();
                    Console.WriteLine("iveeskite pirma sk");
                    ivestis = ivestis + Console.ReadLine();
                    Console.WriteLine("iveeskite antra sk");
                    ivestis = ivestis + Console.ReadLine();
                    Console.WriteLine("1. NAUJA OPEERACIJA 2.Test su rezultatu 3.Iseiti");
                    var ivedimas = Console.ReadLine();
                    ivestis = ivestis + ivedimas;
                    if (ivedimas == "3")
                        showMenu=false;
                }*/