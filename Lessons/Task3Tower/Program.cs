namespace Task3Tower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tower of Hanoi\n\n");

            
            string? zero = "       |       ";
            string? one = "      #|#      ";
            string? two = "     ##|##     ";
            string? three = "    ###|###    ";
            string? four = "   ####|####   ";
            string? bottom = "-------";
            //  Console.Write(one + Environment.NewLine + two + Environment.NewLine + three + Environment.NewLine + four + Environment.NewLine + five + Environment.NewLine + bottom + "1" + bottom); Testas Grazaus boksto

            //1.nupieškite Tower of Hanoi.
            Console.WriteLine($"1eil.{zero}{zero}{zero}\n2eil.{one}{zero}{zero}\n3eil.{two}{zero}{zero}\n4eil.{three}{zero}{zero}\n5eil.{four}{zero}{zero}\nTower{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();

            //2.Apverskite pirmą sulpelį ir išveskite visą Tower of Hanoi
            Console.WriteLine($"\n\n\n1eil.{four}{zero}{zero}\n2eil.{three}{zero}{zero}\n3eil.{two}{zero}{zero}\n4eil.{one}{zero}{zero}\n5eil.{zero}{zero}{zero}\nTower{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");


            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();


            //visų var. sulyginimas tusčiam , kad būtų galima pakartoti koda , jo nekeičiant ir gauti norimą rezultatą
            one = two = three = four = zero;

            //3.Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi
            Console.Write($"\n\n\n1eil.{four}{zero}{zero}\n2eil.{three}{zero}{zero}\n3eil.{two}{zero}{zero}\n4eil.{one}{zero}{zero}\n5eil.{zero}{zero}{zero}\nTower{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();

            //var. atstatyumas
            zero = "       |       ";
            one = "      #|#      ";
            two = "     ##|##     ";
            three = "    ###|###    ";
            four = "   ####|####   ";
            bottom = "-------";

            //4.kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi
            Console.WriteLine($"\n\n\n1eil.{zero}{zero}{zero}\n2eil.{zero}{zero}{zero}\n3eil.{zero}{zero}{zero}\n4eil.{zero}{zero}{zero}\n5eil.{four}{four}{four}\nTower{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");

            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();

            //5.Į 1stulp 5eil įdėkite 4 dalių elementą, 2sutup 5eil - 3 dalių, 3sutup 4eil - 1 dalies, 3sutup 5eil - 2 dalių, ir išveskite Tower of Hanoi
            Console.WriteLine($"\n\n\n" +
                $"1eil.{zero}{zero}{zero}" +
                $"\n2eil.{zero}{zero}{zero}" +//Interpoliacija išskaidžiau naudojant konkatinacija, dėl lengvesnio skaitomumo kode (aiškiau matomi stulpeliai)
                $"\n3eil.{zero}{zero}{zero}" +
                $"\n4eil.{zero}{zero}{one}" +
                $"\n5eil.{four}{three}{two}" +
                $"\nTower{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");


            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();

            //6. Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stup 4eil, ir išveskite Tower of Hanoi
            Console.WriteLine($"\n\n\n" +
                $"1eil.{zero}{zero}{zero}" +
                $"\n2eil.{zero}{zero}{zero}" +
                $"\n3eil.{zero}{zero}{zero}" +
                $"\n4eil.{one}{zero}{one}" +
                $"\n5eil.{four}{three}{two}" +
                $"\nTower{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");


            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();

            //7. visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stup 5eil, ir išveskite Tower of Hanoi
            Console.WriteLine($"\n\n\n" +
                $"1eil.{zero}{two}{zero}" +
                $"\n2eil.{zero}{two}{zero}" +
                $"\n3eil.{zero}{two}{zero}" +
                $"\n4eil.{one}{two}{one}" +
                $"\n5eil.{four}{two}{two}" +
                $"\nTower{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");


            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();

            //8. 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi
            Console.WriteLine($"\n\n\n" +
                $"1eil.{zero}{zero}{zero}" +
                $"\n2eil.{zero}{zero}{one}" +
                $"\n3eil.{zero}{zero}{two}" +
                $"\n4eil.{zero}{zero}{three}" +
                $"\n5eil.{zero}{zero}{four}" +
                $"\nTower{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");


            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();


            //9.pakeiskite visų elementų dizainą iš # į " , išveskite Tower of Hano
            one = one.Replace("#", "\"");
            two = two.Replace("#", "\"");
            three = three.Replace("#", "\"");
            four = four.Replace("#", "\"");

            Console.WriteLine($"\n\n\n" +
              $"1eil.{zero}{zero}{zero}" +
              $"\n2eil.{zero}{zero}{one}" +
              $"\n3eil.{zero}{zero}{two}" +
              $"\n4eil.{zero}{zero}{three}" +
              $"\n5eil.{zero}{zero}{four}" +
              $"\nTower{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");


            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();


            zero = "       |       ";
            one = "      #|#      ";
            var oneE = "      *|*      ";
            two = "     ##|##     ";
            three = "    ###|###    ";
            four = "   ####|####   ";
            bottom = "-------";

            //10.paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute
            Console.WriteLine("\n\n---------------------------------------");
            Console.WriteLine("Enter one character: ");
            var a = Console.ReadLine() ;
            oneE = oneE.Replace("*", a);
            
            
            Console.WriteLine($"1eil.{oneE}{zero}{four}\n2eil.{one}{zero}{three}\n3eil.{two}{zero}{two}\n4eil.{three}{zero}{zero}\n5eil.{four}{zero}{zero}\nTower{bottom}{"1"}{bottom}{bottom}{"2"}{bottom}{bottom}{"3"}{bottom}");


            
        }
    }
}