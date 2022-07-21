using System.Text;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string seka = "1sd512sd5";
            string sakinys = "vienas du trys keturi penki sesi septyni astuoni";
            //IstraukSkaicius(seka);
            //Rykiavimas();
            IsmetytiZodzius(sakinys);
           // Sujungimas(sakinys, "zodis po zodzio zodziuose");

            /*  int[] taskuMasyvas = new int[10];
              foreach (var item in taskuMasyvas)
              {
                  Console.WriteLine("Naujas elementas" + item);
              }*/
        }

        public static void IsmetytiZodzius(string sakinys)
        {
            List<string> list = new List<string>(sakinys.Split(' '));
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            foreach (var item in list)
            {
                if (item.Length >= 5)
                {
                    list2.Add(item);
                }
                else list3.Add(item);
            }
            Console.WriteLine(String.Join(",", list3));
            return list2;
        }

        public static void Sujungimas()
        {
            




        }

        /* public static void Rykiavimas(string sb)
         {



             for (int i = 0; i < sb.Length; i++)
             {
                 for (int j = i + 1; j < mas.Length; j++)
                 {
                     if (mas[i] > mas[j])
                     {
                         int temp = mas[i];
                         mas[i] = mas[j];
                         mas[j] = temp;
                     }
                 }
             }


             Console.WriteLine(String.Join(",", mas));
             return mas;
         }*/

        public static string IstraukSkaicius(string seka)
        {
            var sb = new StringBuilder();
            foreach (char i in seka)
            {
                if (char.IsNumber(i))
                {
                    sb.Append(i);
                }
                return sb.ToString();
            }

          return sb.ToString();
        }
    }
}


/*

 
 
 
 */