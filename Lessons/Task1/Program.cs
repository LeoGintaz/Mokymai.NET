namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Gintaras");


            Console.WriteLine("-----Press any key to continue----------");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Enter Name :");
            var letter = Console.ReadLine();
            Console.WriteLine("First Letter of Name : " + letter[0] + "\n ASCII code for letter " + (int)letter[0]);


        }
    }
}