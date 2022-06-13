namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("priskyrimo operatoriai = += -= *= /=");

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
            Console.WriteLine("2sk");
            double sk3 = double.Parse(Console.ReadLine());
           

            Console.WriteLine($"{(sk1 +sk2 + sk3) / 3}");














        }
    }
}