namespace Task3Tower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

 
            string zero = "       |       ";
            string one = "      *|*      ";
            string two = "     **|**     ";
            string three = "    ***|***    ";
            string four = "   ****|****   ";
            string bottom = "-------";
            //  Console.Write(one + Environment.NewLine + two + Environment.NewLine + three + Environment.NewLine + four + Environment.NewLine + five + Environment.NewLine + bottom + "1" + bottom); Testas Grazaus boksto


            Console.Write($"{zero}{zero}{zero}\n{one}{zero}{zero}\n{two}{zero}{zero}\n{three}{zero}{zero}\n{four}{zero}{zero}\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            

            Console.Write($"\n\n\n{four}{zero}{zero}\n{three}{zero}{zero}\n{two}{zero}{zero}\n{one}{zero}{zero}\n{zero}{zero}{zero}\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");


            var all = one = two = three = four = zero;
            Console.Write($"\n\n\n{four}{zero}{zero}\n{three}{zero}{zero}\n{two}{zero}{zero}\n{one}{zero}{zero}\n{zero}{zero}{zero}\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            zero = "       |       ";
            one = "      *|*      ";
            two = "     **|**     ";
            three = "    ***|***    ";
            four = "   ****|****   ";
            bottom = "-------";

            Console.Write($"\n\n\n{zero}{zero}{zero}\n{zero}{zero}{zero}\n{zero}{zero}{zero}\n{zero}{zero}{zero}\n{four}{four}{four}\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            Console.Write($"\n\n\n" +
                $"{zero}{zero}{zero}" +
                $"\n{zero}{zero}{zero}" +
                $"\n{zero}{zero}{zero}" +
                $"\n{zero}{zero}{one}" +
                $"\n{four}{three}{two}" +
                $"\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            Console.Write($"\n\n\n" +
                $"{zero}{zero}{zero}" +
                $"\n{zero}{zero}{zero}" +
                $"\n{zero}{zero}{zero}" +
                $"\n{one}{zero}{one}" +
                $"\n{four}{three}{two}" +
                $"\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            Console.Write($"\n\n\n" +
                $"{zero}{two}{zero}" +
                $"\n{zero}{two}{zero}" +
                $"\n{zero}{two}{zero}" +
                $"\n{one}{two}{one}" +
                $"\n{four}{two}{two}" +
                $"\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            Console.Write($"\n\n\n" +
                $"{zero}{zero}{zero}" +
                $"\n{zero}{zero}{one}" +
                $"\n{zero}{zero}{two}" +
                $"\n{zero}{zero}{three}" +
                $"\n{zero}{zero}{four}" +
                $"\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

           

        }
    }
}