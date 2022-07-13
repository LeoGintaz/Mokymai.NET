using System.Text;

namespace SkaiciuotuvasApp
{

    internal class Program
        
    {
        int input2 = int.Parse(Console.ReadLine());
        int input3 = int.Parse(Console.ReadLine());
        int input4 = int.Parse(Console.ReadLine());
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //int input2 = int.Parse(Console.ReadLine());
            //SkaiciuEile(input , input2);
            //DaugybosLentele(input2);

            Skaiciuotiuvas();

        }

        private static void Skaiciuotiuvas()
        {
            bool showMenu = true;
            while (showMenu)
            {
                
                showMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            Console.WriteLine("iveskite pirma skaiciu");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("iveskite antra skaiciu");
            int input3 = int.Parse(Console.ReadLine());

            Console.WriteLine(@"
[1] Sudėtis
[2] Atimtis
[3] Daugyba
[4] Dalyba
[5] Išeiti");
            switch (int.Parse(Console.ReadLine()))
            {


                case 1:
                    Console.WriteLine(input2 + input3);
                    return true;
                case 2:
                    Console.WriteLine(input2 - input3);
                    return true;
                case 3:
                    Console.WriteLine(input2 * input3);
                    return true;
                case 4:
                    Console.WriteLine(input2 / input3);
                    return true;
                case 5:
                    return false;
                default: return true;
            }


        }
        private static void DaugybosLentele(int input2)
        {
            for (int i = 1; i <= 11; i++)
            {
                var suma = input2 * i;
                Console.WriteLine($"{input2} * {i} = {suma}");
            }
        }

        private static void SkaiciuEile(string input, int input2)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < input2; i++)
            {
                Console.Write("->");
                sb.Append(input);
                Console.Write(sb);
            }

        }

    }



}