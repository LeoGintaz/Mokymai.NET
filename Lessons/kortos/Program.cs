namespace kortos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipai = "Sirdziu Bugnu Vynu Kryziu";
            string kortos = "Tuzas Dviake Triake Keturake Penkiaake Seseake Septynake Astuonake Devynake Desimtake Bortukas Dama Karalius";
            Kalade(tipai, kortos);
        }

        public static List<string> Kalade(string tipai, string kortos)
        {
            List<string> listtipai = new List<string>(tipai.Split(' '));
            List<string> listkortos = new List<string>(kortos.Split(' '));
            List<string> kalade = new List<string>();
            for (int i = 0 ; i < listtipai.Count; i++)
            {                
                
                var tipas = listtipai[i];
                
                foreach (var korta in listkortos)
                {
                    kalade.Add(tipas);
                    kalade.Add($"{korta}\n");
                }
            }
            Console.WriteLine(String.Join(' ', kalade));
            return kalade;

        }
    }
}