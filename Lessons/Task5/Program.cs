namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("priskyrimo operatoriai = += -= *= /=");
            /*
            Console.WriteLine("1sk");
            int sk1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2sk");
            int sk2 = int.Parse(Console.ReadLine());

            double dalyba = (double)sk1 / sk2;

            Console.WriteLine($"suma {sk1 + sk2} \nskirtumas {sk1 - sk2}");
            Console.WriteLine($"daugyba {sk1 * sk2} \ndalyba {dalyba}");


            Console.WriteLine("1sk");
            sk1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2sk");
            sk2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3sk");
            double sk3 = double.Parse(Console.ReadLine());


            Console.WriteLine($"{(double)(sk1 + sk2 + sk3) / 3}");
            
            long max = long.MaxValue;
            short max2 = short.MaxValue;

            double max3 = (double)max / max2;
            double max4 = max3 - max;
            int max5 = int.MaxValue;
            double max6 = max5 + max4;

            Console.WriteLine(max3);
            Console.WriteLine(max4);
            Console.WriteLine(max6);
            

            long ilg1 = 10_000_000_00;
            long ilg2 = 10_000_000_00;
            long ilg3 = 10_000_000_00;

            ilg1 = (int)ilg1;
            Console.WriteLine(ilg1);
            ilg2 = (short)ilg2;
            Console.WriteLine(ilg2);
            ilg1 = (byte)ilg1;
            Console.WriteLine(ilg2);

            // ilg3 = Convert.ToInt32(ilg3);
            // Console.WriteLine(ilg3);
            // ilg3 = Convert.ToInt16(ilg3);
            // Console.WriteLine(ilg3);
            // ilg3 = Convert.ToByte(ilg3);
            // Console.WriteLine(ilg3);


            Console.WriteLine("iveskite rutulio diametra: ");
            var a = Console.ReadLine();
            Console.WriteLine(a);
            double d = Int32.Parse(a);
            double b = 4 / 3;
            double c = d * d * d;
            double e = b * 3.14 * c;

            Console.WriteLine(e);

            double f = 4 * 3.14 * (d * d);
            Console.WriteLine(f);
            

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = y + 2 * y + x + 1;

            Console.WriteLine($"Enter x and y for y+2y+x+1 : {x} {y}\n Answer: {z}");
            Console.WriteLine($"{y * y + x / 2}");

           

            Console.WriteLine("įveskite penkiaženklį sveikajį skaičių: ");
            var skaicius = Convert.ToDouble(Console.ReadLine().Replace("2" , "0").Replace("3","0").Replace("4", "0").Replace("5", "0").Replace("6", "0").Replace("7", "0").Replace("8", "0").Replace("9", "0"));
            Console.WriteLine($"{skaicius}/2 = {skaicius /2}");


            
            Console.WriteLine("Iveskite 1 sveika skaiciu ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x);

            Console.WriteLine($"{++x} {++x} {++x} {++x} {++x}");
            */
            var toDay = DateTime.Today.ToString("yy/MM/dd");
            Console.WriteLine(toDay);










        }
    }
}