namespace DNR
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dnr = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            //MeniuA(dnr);

            //var choice = int.Parse(Console.ReadLine());
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(ref dnr, ref showMenu);   
            }
    
        }

        public static bool MainMenu(ref string dnr, ref bool iseiti)
        {
            //string dnr = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            Console.WriteLine(@"
[1] DNR grandinės normalizavimas
[2] DNR grandinės validacija
[3] Veiksmai su DNR grandine
[4] Išeiti");
            switch (int.Parse(Console.ReadLine()))
            {
                
                case 1:
                    //string dnr = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
                    DnrNormalizavimas(ref dnr);
                    Console.Clear();
                    Console.WriteLine($"Grandinė normalizuota : [{dnr}]");
                    return true;
                case 2:
                    DnrValidacija(dnr);
                    return true;
                case 3:
                    Console.Clear();
                    SubMenu(ref dnr, ref iseiti);
                    return iseiti;
                case 4:
                    return false;
                    default: return true;

            }
        }

        public static bool SubMenu(ref string dnr, ref bool iseiti)
            {

            if (dnr != "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT")
                Console.WriteLine("DNR nėra normalizuotas \n[1] Normalizuoti DNR\n[2] Išeiti");
                switch (int.Parse(Console.ReadLine())) 
                {
                    case 1:
                        DnrNormalizavimas(ref dnr);
                        return true;
                    case 2: return iseiti = false;
                        default: return true;
                }
            Console.WriteLine(@"
[1] Keisti GCT į AGG
[2] Ar yra CAT?
[3] Veiksmai su DNR grandine
[4] Išvesti trečia ir penktą grandinės segmentus
[5] Išvesti raidžių kiekį tekste
[6] Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas
[7] Iš grandinės pašalinti pasirinką elementą
[8] Pakeisti pasirinkti segmentą įvestu iš klaviatūros
[9] Gryžti į ankstesnį meniu");
            switch (int.Parse(Console.ReadLine()))
            {

                case 1:
                    switch (int.Parse(Console.ReadLine()))
                    { 
                    
                    }
                    return true;


                case 2:
                    DnrValidacija(dnr);
                    return true;
                case 3:
                    Console.Clear();
                    
                    return true;
                case 4:
                    return false;
                
                case 5:
                    return false;
                case 6:
                    return false;
                case 7:
                    return false;
                case 8:
                    return false;
                case 9:
                    return false;
                case 10:
                    return false;
                default: return true;

            }
        }

        public static string DnrValidacija(string dnr)
        {
            Console.WriteLine(dnr);
            return dnr;
        }

        public static string DnrNormalizavimas(ref string dnr)
        {
            return dnr = dnr.ToUpper().Replace(" ", "");
        }



        /* public static void MeniuA()
         {
             var choice = int.Parse(Console.ReadLine());
             switch (meniu) 
             {
                 case 1:
                     Console.WriteLine("kazkas");
                     break;
                 case 2:
                     Console.WriteLine("kitas");
                     break ;


             }*/





    }





    }



/*---------------------------------------------------
Tarkime turime DNR grandinę užkoduotą tekstu var txt =" T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ".
Galimos bazės: Adenine, Thymine, Cytosine, Guanine
  Parašykite programą kurioje atsiranda MENIU kuriame naudotojas gali pasirinkti:
  1. Atlikti DNR grandinės normalizavimo veiksmus:
     - pašalina tarpus.
     - visas raides keičia didžiosiomis. 
  2. Atlikti grandinės validaciją
     - patikrina ar nėra kitų nei ATCG raidžių
  3. Atlieka veiksmus su DNR grandine (tik tuo atveju jei grandinė yra normalizuota ir validi). Nuspaudus 3 įeinama į sub-meniu
      - Jeigu grandinė yra validi, tačiau nenormalizuota programa pasiūlo naudotojui 
      1) normalizuoti grandinę
      2) išeiti iš programos
      - jei grandinė normalizuota arba kai buvo atlikta normalizacija
      1) GCT pakeis į AGG
      2) Išvesti ar yra tekste CAT 
      3) Išvesti trečia ir penktą grandinės segmentus (naudoti Substring()).
      4) Išvesti raidžių kiekį tekste (naudoti string composition)
      5) Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas 
      6) Prie grandinės galo pridėti iš klaviatūros įvesta segmentą  
          (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
      7) Iš grandinės pašalinti pasirinką elementą  
      8) Pakeisti pasirinkti segmentą įvestu iš klaviatūros  
          (reikalinga validacija ar nėra kitų kaip ATCG ir 3 raidės) 
      9) Gryžti į ankstesnį meniu
Visoms operacijoms reikalingi testai.
 */