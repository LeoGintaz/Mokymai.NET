using System.Linq;

namespace DNR
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string dnr = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";         
                       
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(ref dnr, ref showMenu);   
            }
    
        }

        public static bool MainMenu(ref string dnr, ref bool iseiti)
        {
            
            Console.WriteLine(@"
[1] DNR grandinės normalizavimas
[2] DNR grandinės validacija
[3] Veiksmai su DNR grandine
[4] Išeiti");
            switch (int.Parse(Console.ReadLine()))
            {
                
                
                case 1:                    
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
            {
                Console.WriteLine("DNR nėra normalizuotas \n[1] Normalizuoti DNR\n[2] Išeiti");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        DnrNormalizavimas(ref dnr);
                        SubMenu(ref dnr, ref iseiti);
                        Console.Clear();
                        return true;
                    case 2: return iseiti = false;
                    default: return true;
                }
            }
            Console.WriteLine(@"
[1] Keisti GCT į AGG
[2] Ar yra CAT?
[3] Išvesti trečia ir penktą grandinės segmentu
[4] Išvesti raidžių kiekį tekste
[5] Išvesti ar yra tekste ir kiek kartų pasikartoja iš klaviatūros įvestas segmento kodas
[6] Prie grandinės galo pridėti iš klaviatūros įvesta segmentą
[7] Iš grandinės pašalinti pasirinką elementą
[8] Pakeisti pasirinkta segmentą įvestu iš klaviatūros
[9] Gryžti į ankstesnį meniu");
            switch (int.Parse(Console.ReadLine()))
            {

                case 1:
                    Console.Clear();
                    ReplaceGCTtoAGG(ref dnr);
                    Console.ReadKey();
                    Console.Clear();
                    SubMenu(ref dnr, ref iseiti);
                    return true;

                case 2:
                    Console.Clear();
                    IsCatInDNR(ref dnr);
                    Console.ReadKey();
                    Console.Clear();
                    SubMenu(ref dnr, ref iseiti);
                    return true;

                case 3:
                    Console.Clear();
                    Write3rd5thSegment(ref dnr);
                    Console.ReadKey();
                    Console.Clear();
                    SubMenu(ref dnr, ref iseiti);
                    return true;

                case 4:
                    Console.Clear();
                    RaidziuKiekis(ref dnr);
                    Console.ReadKey();
                    Console.Clear();
                    SubMenu(ref dnr, ref iseiti);
                    return true;
                
                case 5:
                    Console.Clear();
                    SegmentCount(ref dnr);
                    Console.ReadKey();
                    Console.Clear();
                    SubMenu(ref dnr, ref iseiti);
                    return true;

                case 6:
                    Console.Clear();
                   /* var isDNRvalid = DnrValidacija(dnr) == "true";
                    if (isDNRvalid == true)
                    {*/
                        SegmentADD(ref dnr);
                        Console.ReadKey();
                        Console.Clear();
                        SubMenu(ref dnr, ref iseiti);
                   /* }
                    else
                    {
                        Console.WriteLine("Reikalinga Validacija");
                        Console.ReadKey();
                        Console.Clear();
                        SubMenu(ref dnr, ref iseiti);
                    }*/
                    return true;

                case 7:
                    Console.Clear();
                    SegmentRemove(ref dnr);
                    Console.ReadKey();
                    Console.Clear();
                    SubMenu(ref dnr, ref iseiti);

                    return true;

                case 8:
                    { Console.Clear();
                    //isDNRvalid = DnrValidacija(dnr) == "true";
                    //if (isDNRvalid == true)
                    //{
                        SegmentChange(ref dnr);
                        Console.ReadKey();
                        Console.Clear();
                        SubMenu(ref dnr, ref iseiti);
                   // }
                    //else
                   // {
                        //Console.WriteLine("Reikalinga Validacija");
                       // Console.ReadKey();
                       // Console.Clear();
                       // SubMenu(ref dnr, ref iseiti);
                    }

                    return true;

                case 9:
                    Console.Clear();
                    return true;
                
                default: return true;

            }
        }

        private static void SegmentChange(ref string dnr)
        {
            Console.WriteLine("{0} \n Įveskite segmentą kurį norite pakeisti :", dnr);
            var segmentas = Console.ReadLine();
            Console.WriteLine("Įvesskite naują segmentą : ");
            var newSegmentas = Console.ReadLine();
            Console.WriteLine(dnr.Replace(segmentas, newSegmentas));
        }

        private static void SegmentRemove(ref string dnr)
        {
            Console.WriteLine("TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT\nĮveskite segmentą : ");
            var segmentas = Console.ReadLine();
            segmentas = dnr.Replace(segmentas, "");
            Console.WriteLine(segmentas);
        }

        private static void SegmentADD(ref string dnr)
        {
            Console.WriteLine("TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT\nĮveskite segmentą : ");
            var segmentas = Console.ReadLine();
            Console.WriteLine(dnr + "-" + segmentas);
            
            
        }

        private static void SegmentCount(ref string dnr)
        {
            Console.WriteLine("TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT\nĮveskite segmentą : ");
            var segmentas = Console.ReadLine();
            segmentas = segmentas.ToUpper();
            var segmentCount = dnr.Split("-").Count(c => c == segmentas);
            Console.WriteLine("Šis segmentas pasikartoja {0} kartų", segmentCount);
        }

        private static void RaidziuKiekis(ref string dnr)
        {
            var kiekis = dnr.Replace("-", "");
            Console.WriteLine("Raidžiū kiekis : {0}", kiekis.Length);
        }

        private static string[] Write3rd5thSegment(ref string dnr)
        {
            var Segmentai = dnr.Split("-");
            Console.WriteLine(Segmentai[4] + "-" + Segmentai[6]);
            return Segmentai;
        }

        private static void IsCatInDNR(ref string dnr)
        {
            Console.WriteLine("Ar grandinėje yra CAT {0}", dnr.Contains("CAT"));
        }

        private static void ReplaceGCTtoAGG(ref string dnr)
        {
            Console.WriteLine(dnr.Replace("GCT", "AGG"));
        }

        public static string DnrValidacija(string dnr)
        {
            bool dnrValidacija = dnr.ToUpper().Replace("A", "").Replace("T", "").Replace("C", "").Replace("G", "").Replace(" ", "").Replace("-", "") == "";
            var contains3split = dnr.ToUpper().Split("-");
            bool contains3 = contains3split.All(x => x.Length == 3);
            Console.WriteLine("Ar visi elementai susideda is 3 ? : \n {0}", contains3);

            Console.WriteLine("Ar DNR grandis - sudaryta tik iš A,T,C,G? \n {0}", dnrValidacija);
            var dnr2 = dnrValidacija == true && contains3 == true;
            dnr = dnr2.ToString();

            return dnr;
        }

        public static string DnrNormalizavimas(ref string dnr)
        {
            return dnr = dnr.ToUpper().Replace(" ", "");
        }




      




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