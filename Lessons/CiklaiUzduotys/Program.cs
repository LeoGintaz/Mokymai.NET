using System.Text;
namespace CiklaiUzduotys
{

    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //3
            /*
            Sukurti metodą PakeltiLaipsniu , kuris duotą skaičių pakelia nurodytu
      laipsniu ir gautą rezultatą grąžina.Pirmas parametras skaičius, kurį
      kelsime, antras laipsnis, kuriuo pakelti.
      NB! kai skaičius 0 o laipsnis > 0 gąžinama 1
      NB! kai skaičius 0 ir laipsnis = 0 gąžinama 0
      NB! kai laipsnis = 1 gąžinamas tas pats skaičius*//*
            int skaicius = int.Parse(Console.ReadLine());
            int laipsnis = int.Parse(Console.ReadLine());
            KelimasLaipsniu(skaicius, laipsnis);*/

            var skaicius = Console.ReadLine();
            SkaiciuTrikampis(skaicius);
            //SkaiciuTrikampis2(skaicius);






            //2.Sukurti metodą IntegerToBinary,
            /* kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą.Reikšmę grąžintų kaip simbolių eilutę.
         2-- > 10
         7-- > 111
         45-- > 101101 */
            //string skaicius = Console.ReadLine();

            // IntToBianary(skaicius);



            //1.
            //Console.WriteLine("iveskite sveika skaiciu");
            //var ivestis = double.Parse(Console.ReadLine());
            //ReadIntNr(ivestis);
        }

        public static void SkaiciuTrikampis0(int skaicius)
        {
            Console.Clear();
            for (long i = 0; i < skaicius; ++i)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(skaicius);
                }
                Console.WriteLine();
            }
        }
        public static void SkaiciuTrikampis(string skaicius)
        {
            Console.Clear();
            var sb = new StringBuilder();
            var skaiciusint = Convert.ToInt32(skaicius);
            for (long i = 0; i < skaiciusint; i++)
            {
                
                for (int j = 0; j < i - 1; j++)
                {
                    sb.Append(skaicius);
                    Console.WriteLine(sb.ToString());
                }
                
            }
        }
        public static void SkaiciuTrikampis2(int skaicius)
        {
            Console.Clear();
            for (int i = 0; i < skaicius; ++i)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(skaicius);
                }
                Console.WriteLine();
            }
            for (int i = skaicius; i >= skaicius; --i)
            {
                for (int j = skaicius; j >= skaicius; j--)
                {
                    Console.Write(skaicius);
                }
                Console.WriteLine();
            }
        }

        /*
private static void KelimasLaipsniu(int skaicius, int  laipsnis)
{
   int kartai = 0;
   int rezultatas = 1;
   while (kartai != laipsnis)

   {

       ++kartai;
       rezultatas = rezultatas * skaicius;

   }

   Console.WriteLine(rezultatas);

}*/
        /*
private static string IntToBianary(string skaicius)
{
   foreach (char item in skaicius)
   {
       int item2 = Convert.ToInt32(item);
       item2 = item2 % 2;
       var item3 = item2.ToString();
           Console.WriteLine(item3);
       return item3; 

   }
   return skaicius;
}
/* UŽDUOTIS 1.
Sukurti metodą ReadIntNumber,
kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
(Hint) -> Panaudoti int.TryParse metodą ir while ciklą */
        /*  public static double ReadIntNr(double ivestis)
          {
              while (ivestis != Convert.ToInt32(ivestis))
              {
                  Console.WriteLine("iveskite tinkama skaiciu");
                  ivestis = double.Parse(Console.ReadLine());
              }
              return ivestis;
          }*/








    }

}