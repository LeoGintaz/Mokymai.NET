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




            }
        }
    }