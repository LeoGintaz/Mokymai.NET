namespace Lists
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> intSarasas = new List<int> { 5, 1, 6, 8, 7 };
            //Didziausias(intSarasas);
            //VienuDidesnis(intSarasas);
           // VienuDidesnis2(intSarasas);




        }
        /* ### 2
        DIDESNIS UŽ DIDŽIAUSIĄ
       Duotas vienmatis sveikų skaičių sąrašas. 
       Parašykite programą, kuri į sąrašo galą prideda vienetu didesnį skaičių už patį didžiausią

       pvz:
       { 5, 1, 6, 8, 7 }
       rezultatas:  5, 1, 6, 8, 7, 9 */

        public static int VienuDidesnis(List<int> lst)
        {
           lst.Sort();
           var max = lst[lst.Count - 1];
           lst.Add(max + 1);
           return lst[5];
        }
        public static List<int> VienuDidesnis2(List<int> intSarasas)
        {
            var max = Didziausias(intSarasas);
            intSarasas.Add(max + 1);
             
            
            return intSarasas;
        }


        /* ### 1
DIDŽIAUSIAS SĄRAŠE
Duotas vienmatis sveikų skaičių sąrašas. 
Parašykite programą, kuri suranda didžiausią skaičių saraše
{ 5, 1, 6, 8, 7 }

rezultatas:  8*/
        public static int Didziausias(List<int> mas)
        {
            int max = mas[0];
            for (int i = 0; i < mas.Count(); i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];

                }

            }
            
            return max;
        }

   

















    }
}