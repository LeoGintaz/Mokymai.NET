namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Gintaras");

            /*
                        Console.WriteLine("--Press any key to clear and continue--");
                        Console.ReadKey();
                        Console.Clear();

                        Mano bandymas

                        Console.WriteLine("Enter Name :");
                        var letter = Console.ReadLine();

                        Console.WriteLine("Enter number :");
                        var number = Console.ReadLine();


                        Console.WriteLine("First Letter of Name : " + letter[0] + "\n ASCII code for letter " + (int)letter[0]); */

            //Console.WriteLine("  ivestas ASCII  " + (int)Console.ReadKey().KeyChar);


            /*Console.WriteLine("ivest raide ir skaiciu");

            Console.WriteLine("Sum {0}" , (int)Console.ReadKey().KeyChar + (int)Console.ReadKey().KeyChar);

            */

            Console.WriteLine("L\na\nb\na\ns"); //nauja eilute kas raide
            Console.WriteLine("L\ta\tb\ta\ts"); //tabai kas raide (galima tiesiog deti tabus)

            Console.WriteLine("(1) Pirkti" + Environment.NewLine + "(2) Parduoti" + Environment.NewLine + "(3) Likučiai");
            Console.WriteLine("\"Pasirinkimas yra : \" " + Console.ReadLine());

            Console.WriteLine("\n{0} \n{1} \n{2}", "(1)Pirkti", "(2)Parduoti", "(3)Likuciai");

            Console.WriteLine($"\n{"1.Pirkti"} \n{"2.Parduoti"} \n{"3.Likuciai"}");












        }
    }
}