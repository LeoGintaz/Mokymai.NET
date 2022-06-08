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



            //From lesson variable types

            //Sveikas skaičius
            byte mazasSkaicius = 2; //galima priskirti nuo 0 iki 255
            short trumpasSkaicius = 2; //max value 32767 min value -32768
            long ilgasSkaicius = 2; //max ir min labai didelis, didesni negu int
            int skaiciusss = 2; //max value 2147483647 min value -2147483647
            

            //tinka visiem skaiciu var. tipam

            int maxIntSkaitmuo = int.MaxValue; // Išveda maksimalų galimą skaičių
            int minIntSkaitmuo = int.MinValue; // Isveda minimalu galima skaiciu


            //budai skaiciu var. priskirti null
            int? skaiciusKurisGaliButNull;
            skaiciusKurisGaliButNull = null;
            Nullable<int> skaiciussKurisGaliButNull = null;
            
            
            uint tikTeigiamasSkaicius = 2; //tik teigiami skaiciai max dvigubas lyginant su int/ushot/ulong



        }
    }
}