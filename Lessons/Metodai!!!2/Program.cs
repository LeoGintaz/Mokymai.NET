namespace Metodai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("metodai 2");
            Console.WriteLine("iveskite teksta");
            var tekstas = Console.ReadLine();
            Console.WriteLine(Tarpai(tekstas));
            //Console.WriteLine(TarpKiekis(tekstas));
            //Console.WriteLine(TarpKiekisprad(tekstas));
            //StarEndstring(tekstas);



        }
        public static int Tarpai(string tarpai)
        {
            string pakitimas = tarpai.Replace(" ", "");
            var atimtis = tarpai.Length - pakitimas.Length;
            return atimtis;

        }
 
        public static int Word(string tarpai)
        {
            string[] split = tarpai.Split(' ');
            var count = split.Count();
            return count;
        }
        public static int TarpKiekis(string tarp)
        {
            var kiekis = tarp.Length - tarp.TrimEnd(' ').Length;
            return kiekis;
        }

        public static int TarpKiekisprad(string tarp)
        {
            var kiekis = tarp.Length - tarp.TrimStart(' ').Length;
            return kiekis;
        }

        public static int StarEndstring(string tekstas, out int tarpaiGale) 
        {
            tarpaiGale = tekstas.Length - tekstas.TrimEnd(' ').Length;
            var kiekis2 = tekstas.Length - tekstas.TrimStart(' ').Length;
            return kiekis2;

        }*/


        


    }

}