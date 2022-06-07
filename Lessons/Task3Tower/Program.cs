namespace Task3Tower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

 
            string one = "       |       ";
            string two = "      *|*      ";
            string three = "     **|**     ";
            string four = "    ***|***    ";
            string five = "   ****|****   ";
            string bottom = "-------";
            //  Console.Write(one + Environment.NewLine + two + Environment.NewLine + three + Environment.NewLine + four + Environment.NewLine + five + Environment.NewLine + bottom + "1" + bottom); Testas Grazaus boksto


            Console.Write($"{one}{one}{one}\n{two}{one}{one}\n{three}{one}{one}\n{four}{one}{one}\n{five}{one}{one}\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            

            Console.Write($"\n\n\n{five}{one}{one}\n{four}{one}{one}\n{three}{one}{one}\n{two}{one}{one}\n{one}{one}{one}\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");


            var all = two = three = four = five = one;
            Console.Write($"\n\n\n{five}{one}{one}\n{four}{one}{one}\n{three}{one}{one}\n{two}{one}{one}\n{one}{one}{one}\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            one = "       |       ";
            two = "      *|*      ";
            three = "     **|**     ";
            four = "    ***|***    ";
            five = "   ****|****   ";
            bottom = "-------";

            Console.Write($"\n\n\n{one}{one}{one}\n{one}{one}{one}\n{one}{one}{one}\n{one}{one}{one}\n{five}{five}{five}\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            Console.Write($"\n\n\n" +
                $"{one}{one}{one}" +
                $"\n{one}{one}{one}" +
                $"\n{one}{one}{one}" +
                $"\n{one}{one}{two}" +
                $"\n{five}{four}{three}" +
                $"\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            Console.Write($"\n\n\n" +
                $"{one}{one}{one}" +
                $"\n{one}{one}{one}" +
                $"\n{one}{one}{one}" +
                $"\n{two}{one}{two}" +
                $"\n{five}{four}{three}" +
                $"\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            Console.Write($"\n\n\n" +
                $"{one}{three}{one}" +
                $"\n{one}{three}{one}" +
                $"\n{one}{three}{one}" +
                $"\n{two}{three}{two}" +
                $"\n{five}{three}{three}" +
                $"\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            Console.Write($"\n\n\n" +
                $"{one}{one}{one}" +
                $"\n{one}{one}{two}" +
                $"\n{one}{one}{three}" +
                $"\n{one}{one}{four}" +
                $"\n{one}{one}{five}" +
                $"\n{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

        }
    }
}