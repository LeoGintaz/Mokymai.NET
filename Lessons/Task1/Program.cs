namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Gintaras");


            Console.WriteLine("--Press any key to clear and continue--");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Enter Name :");
            var letter = Console.ReadLine();

            Console.WriteLine("Enter number :");
            var number = Console.ReadLine();




            Console.WriteLine("First Letter of Name : " + letter[0] + "\n ASCII code for letter " + (int)letter[0]);
            int x = letter[0];
            int y = number[0];
            int sum = x + y;
            Console.WriteLine("Sum of ASCII and number = "+ (sum));









        }
    }
}