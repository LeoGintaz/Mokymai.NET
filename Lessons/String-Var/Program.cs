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
            int? skaiciusNull = null;

            int? skaiciusKurisGaliButNull;
            skaiciusKurisGaliButNull = null;

            Nullable<int> skaiciussKurisGaliButNull2 = null;


            uint tikTeigiamasSkaicius = 2; //tik teigiami skaiciai max dvigubas lyginant su int/ushot/ulong

            //float numbers. trupmeniniai skaic

            float maziausias = 8.5f; // maziausias trup. skaic.
            // var trup = 8.5; patampa double
            // var trup = 8.5f; patampa float
            double trupmeninis = 8.5; //double
            decimal didziausias = 8.5m; // didziausias trup. skaic.  //Google when to use which type

            //galimi dideliu skaiciu rasymo budai
            double didelis = 6.022e23; // 6.022x10^23.
            double atskyrimas = 522_1_00.00_001; //Atskirimas del lengvesnio skaitomumo


        }
    }
}