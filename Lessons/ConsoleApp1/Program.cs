namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int num1 = 10;
            int num2 = 5;
            var oper = "*";

            Console.WriteLine($"sudetis : {Sudetis(num1, num2)}");
            Console.WriteLine($"atimtis : {Atimtis(num1, num2)}");
            Console.WriteLine($"dalyba : {Dalyba(num1, num2)}");
            Console.WriteLine($"daugyba : {Daugyba(num1, num2)}");
            Console.WriteLine($"visu suma : {Sudetis(num1, num2) + Atimtis(num1, num2) + Dalyba(num1, num2) + Daugyba(num1, num2)}");



        }

        public static int Sudetis(int num, int num2)
        {
            int suma = num + num2;
            return suma;
        }
        public static int Atimtis(int num, int num2)
        {
            int suma = num - num2;
            return suma;
        }
        public static int Dalyba(int num, int num2)
        {
            int suma = num / num2;
            return suma;
        }
        public static int Daugyba(int num, int num2)
        {
            int suma = num * num2;
            return suma;
        }
        public static int Skaiciuotuvas(int num, int num2, string oper)
        {
            switch (num, num2, oper)
            {
                case 1:
                    if (oper == "+")
                        return num + num2;
                    break;
                case 2:
                    if (oper == "-")
                        return num - num2;
                    break;
                case 3:
                    if (oper == "/")
                        return num / num2;
                    break;
                case 4:
                    if (oper == "*")
                        return num * num2;
                    break;
                    return 0;
            

            }
        }
    }   
}