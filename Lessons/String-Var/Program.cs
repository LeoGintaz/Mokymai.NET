namespace String_Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //variable types
            //type  name
            string kintamasis = "hello world"; //string
            string tuscias = ""; //tuscias
            string nulinis = null; //nieko nera
            string laisvas = "          "; //empty space
            var stringkint = "tekstas"; //bendras pagal auto priskiriama reiksme

            string kontratinacija = kintamasis + stringkint;
            string kompozicija = string.Format("{0}", kintamasis);
            string interpoliacija = $"{laisvas}";

            int skaicius = 5;//solid number
            decimal skaiciuss = 5.5m; //skaicius su kableliu
            



            kintamasis = "tekstas belekoks"; // override of "kintamasis" 

        }
    }
}