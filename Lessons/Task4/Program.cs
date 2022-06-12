namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Tuple<string, string, int, DateTime> tuple = new Tuple<string, string, int, DateTime>("Code Academy", ".NetMokymai", 22, DateTime.Now);
            Console.WriteLine(tuple);


            var pradzia = new DateTime(2022, 05, 30);
            var siandiena = DateTime.Now;
            var skirtumas = siandiena - pradzia;
            Console.WriteLine("studiju pradžia " + pradzia);
            Console.WriteLine("Šiandienos laikas " + siandiena );
            Console.WriteLine("skirtumas : " + skirtumas);

            Console.WriteLine("-----------------");

            string tekstas = "tekstas";
            int skaicius = 11;
            bool bulijonas = true;
            
            Console.WriteLine(tekstas + " " +skaicius + " " + bulijonas);
           
            Console.WriteLine("{0} {1} {2}", tekstas, skaicius, bulijonas);

            Console.WriteLine($"{tekstas} {skaicius} {bulijonas}");





            }
        }
    }