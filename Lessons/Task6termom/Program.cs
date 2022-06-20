
Console.WriteLine("Termometriniai Automobiliai\n\n\n");

//1. Paprašykite naudotojo įvesti 1 skaičių - temperatūrą pagal Celsijų.

Console.WriteLine("Įvesskite temp. celcijumi: ");

decimal cel = decimal.Parse(Console.ReadLine()); //Celcijus
var deg = "\u00B0"; //laipsniu simbolis
decimal far = cel * 9 / 5 + 32; //farenheitas
decimal kel = cel + (decimal)273.15; //kelvinas
Console.WriteLine($"{cel}{deg}C");

//2. Paskaičiuokite ir išveskite į ekraną temperatūrą pagal farenheitą.
//3. Paskaičiuokite ir išveskite į ekraną temperatūrą pagal kelviną.

Console.WriteLine($"{far}{deg}F\n{kel}K");

//4.Gautą temperatūrą pagal farenheitą perskaičiuokite į Celsijų ir patikrinkite ar sutampa su įvestu skaičių (išveskite true/false)
decimal farBack2cel = (far - 32) * 5 / 9;
bool isFequal = farBack2cel == cel;


Console.WriteLine($"Is celcius to Farenheit conversion correct? {isFequal}");

//5.Gautą temperatūrą pagal kelviną perskaičiuokite į celsijų ir patikrinkite ar sutampa su įvestu skaičiu (išveskite true/false)

decimal kelBack2cel = kel - (decimal)273.15;
bool isKequal = kelBack2cel == cel;

Console.WriteLine($"Is celcius to Kelvin conversion coreect ? {isKequal}");

//6.Paskaičiuotą temperatūrą pagal farenheita peverskite į kelviną ir patikrinkite ar sutampa su ankstesniais skaičiavimais (išveskite true/false)
decimal far2kel = (far + (decimal)459.67) * 5 / 9;
decimal kel2far = far2kel * 9 / 5 - (decimal)459.67;
bool isKequalF = far == kel2far;
Console.WriteLine($"Former farenheit {far}{deg}F After konversion to Kelvin and back {kel2far}{deg}F. Ar they Equal ? {isKequalF}");
Console.ReadKey();
/*  Nupieškite termometrą pagal Celsijų 
     a) Atvaizduokite skalę, sugraduotą kas 5 laipsnius C priklausomai nuo įvestos temperatūros pridedant ir atimant 40 laipsnių 
       (tarkime įvesta buvo 10, tuomet skalė bus nuo -30 iki +50)
     b) Grafiškai atvaizduokite įvestą temperatūros stulpelį. */

var cel5 = cel + 5;
var cel10 = cel + 10;
var cel15 = cel + 15;
var cel20 = cel + 20;
var cel25 = cel + 25;
var cel30 = cel + 30;
var cel35 = cel + 35;
var cel40 = cel + 40;
var cel5m = cel - 5;
var cel10m = cel - 10;
var cel15m = cel - 15;
var cel20m = cel - 20;
var cel25m = cel - 25;
var cel30m = cel - 30;
var cel35m = cel - 35;
var cel40m = cel - 40;


var far1 = cel5 * 9 / 5 + 32;
var far2 = cel10 * 9 / 5 + 32;
var far3 = cel15 * 9 / 5 + 32;
var far4 = cel20 * 9 / 5 + 32;
var far5 = cel25 * 9 / 5 + 32;
var far6 = cel30 * 9 / 5 + 32;
var far7 = cel35 * 9 / 5 + 32;
var far8 = cel40 * 9 / 5 + 32;
var far1m = cel5m * 9 / 5 + 32;
var far2m = cel10m * 9 / 5 + 32;
var far3m = cel15m * 9 / 5 + 32;
var far4m = cel20m * 9 / 5 + 32;
var far5m = cel25m * 9 / 5 + 32;
var far6m = cel30m * 9 / 5 + 32;
var far7m = cel35m * 9 / 5 + 32;
var far8m = cel40m * 9 / 5 + 32;

/*Console.WriteLine($"" +
    $"          |--------------------|" +
    $"          |   ^F     _    ^C   |" +
    $"          |  100  - | | -  40  |" +
    $"          |   95  - | | -  35  |" +
    $"          |   90  - | | -  30  |" +
    $"          |   80  - | | -  25  |" +
    $"          |   70  - | | -  20  |" +
    $"          |   60  - | | -  15  |" +
    $"          |   50  - |#| -  10  |" +
    $"          |   40  - |#| -   5  |" +
    $"          |   30  - |#| -   0  |" +
    $"          |   20  - |#| -  -5  |" +
    $"          |   10  - |#| - -10  |" +
    $"          |    5  - |#| - -15  |" +
    $"          |    0  - |#| - -20  |" +
    $"          |  -10  - |#| - -25  |" +
    $"          |  -20  - |#| - -30  |" +
    $"          |  -30  - |#| - -35  |" +
    $"          |  -40  - |#| - -40  |" +
    $"          |        '***`       |" +
    $"          |       (*****)      |" +
    $"          |        '---'       |" +
    $"          |____________________|" );       */


Console.WriteLine($"" +
    $"          |--------------------|\n" +
    $"          |   {deg}F     _    {deg}C   |\n" +
    $"          |  {far8}  - | | -  {cel40}  |\n" +
    $"          |   {far7}  - | | -  {cel35}  |\n" +
    $"          |   {far6}  - | | -  {cel30}  |\n" +
    $"          |   {far5}  - | | -  {cel25}  |\n" +
    $"          |   {far4}  - | | -  {cel20}  |\n" +
    $"          |   {far3}  - | | -  {cel15}  |\n" +
    $"          |   {far2}  - | | -  {cel10}  |\n" +
    $"          |   {far1}  - | | -   {cel5}  |\n" +
    $"          |   {far}  - |#| -   {cel}  |\n" +
    $"          |   {far1m}  - |#| -  {cel5m}  |\n" +
    $"          |   {far2m}  - |#| - {cel10m}  |\n" +
    $"          |    {far3m}  - |#| - {cel15m}  |\n" +
    $"          |   {far4m}  - |#| - {cel20m}  |\n" +
    $"          |  {far5m}  - |#| - {cel25m}  |\n" +
    $"          |  {far6m}  - |#| - {cel30m}  |\n" +
    $"          |  {far7m}  - |#| - {cel35m}  |\n" +
    $"          |  {far8m}  - |#| - {cel40m}  |\n" +
    $"          |        '***`       |\n" +
    $"          |       (*****)      |\n" +
    $"          |        '---'       |\n" +
    $"          |____________________|");
Console.ReadKey(); 

Console.WriteLine("Enter km from point A to B"); 
var AtoB = int.Parse(Console.ReadLine());
Console.WriteLine("Enter speed of car A in km/h");
var carA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter speed of car B in km/h");
var carB = int.Parse(Console.ReadLine());
var C = carA + carB;
decimal laikas = (C/C) + (AtoB/C);
Console.WriteLine(laikas);
decimal meet = carA * laikas;
Console.WriteLine(meet);

Console.WriteLine($" cars will meet at {meet * 1000} meeters from point A. after {laikas * 60 *60}s from start");
decimal carAfin = AtoB / carA; 
decimal carBfin= AtoB / carB;
Console.WriteLine($"car a will finish route in {carAfin *60}min. and CarB will finish route in {carBfin *60}minutes");
Console.WriteLine($" total emitions from both cars at meet point {200 * 95 } emissions from car A {meet * 95}. Emissions from car B {(200 - meet) * 95}");

var segment = AtoB / 20;
var seg = Convert.ToString(segment);


seg = seg.Replace(seg, $"km");

Console.WriteLine($"" +
    $"|{seg, 4}|{seg, 4}|{seg,4}|{seg, 4}|{seg, 4}|{seg, 4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|");

seg = seg.Replace("km", $"{segment}");

Console.WriteLine($"" +
    $"|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|{seg,4}|");

seg = seg.Replace($"{segment}", "----");


Console.WriteLine($"" +
    $"|{seg,4}-{seg,4}-{seg,4}-{seg,4}-{seg,4}-{seg,4}-{seg,4}-{seg,4}-{seg,4}-{seg,4}{AtoB}km-{seg,4}-{seg,4}-{seg,4}-{seg,4}-{seg,4}-{seg,4}-{seg,4}-{seg,4}-{seg,4}|");
int xx = Convert.ToInt32(meet);
string susitikimas = new String('-', xx/10*5-1);
string susitikimas2 = new String('-', (AtoB - xx) / 10 * 5-1);
Console.WriteLine($"|{susitikimas}x Cars will meet here at {meet} km.");


int CarAT = AtoB / carA * 60;
int CarBT = AtoB / carB * 60;
string plus = $"CarA{susitikimas}>>>{CarAT}min";
Console.WriteLine($"|{plus, -99}|");
string plus2 = $"{CarBT}min.<<<{susitikimas2}CarB";
Console.WriteLine($"|{plus2, 99}|");
/*seg = seg.Replace("-", ">");

Console.WriteLine($"" +
    $"{seg}{seg}{seg}{seg}{seg}{seg}{seg}{seg}{seg}{CarAT}min{seg}{seg}{seg}{seg}{seg}{seg}{seg}{seg}{seg}A");*/
//susitikimas = susitikimas.Replace("-", ">");
//Console.WriteLine($"|{susitikimas}{CarAT}min{susitikimas2} CarA total time");

//susitikimas = susitikimas.Replace(">", "<");
//susitikimas2 = susitikimas2.Replace(">", "<");

//Console.WriteLine($"|{susitikimas2}{CarBT}min{susitikimas} CarB total time");


/*seg = seg.Replace(">", "<");

Console.WriteLine($"" +
    $"{seg}{seg}{seg}{seg}{seg}{seg}{seg}{seg}{seg}{CarBT}min{seg}{seg}{seg}{seg}{seg}{seg}{seg}{seg}{seg}B");*/






