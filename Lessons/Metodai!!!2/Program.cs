namespace Metodai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("metodai 2");
              Console.WriteLine("iveskite teksta");
              var tekstas = Console.ReadLine();
              Console.WriteLine(Tarpai(tekstas));
              //Console.WriteLine(TarpKiekis(tekstas));
              //Console.WriteLine(TarpKiekisprad(tekstas));
              //StarEndstring(tekstas);
            */
            //string tekstas = Console.ReadLine();
            //Console.WriteLine(Mokausi(tekstas));
            var kurA = Console.ReadLine();
            Console.WriteLine(Mokausi(kurA));


        }/*
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


        public static string Mokausi(string tekstas)
        {
            bool tarpai = tekstas.Contains(" mokausi ");
            bool kableliai1 = tekstas.Contains("mokausi,");
            bool kableliai2 = tekstas.Contains(",mokausi");
            bool klaustukas = tekstas.Contains("mokausi?");
            bool skliaustai = tekstas.Contains("(mokausi)");

            bool mokausi = tarpai || kableliai1 || kableliai2 || klaustukas || skliaustai;
            if (mokausi = true)
                return "true";
            else return "false";



            

        }
        public static int Aindex(string tekstas)
        {
            int indeksas = tekstas.IndexOf("a");
                return indeksas;

        }

    }

}