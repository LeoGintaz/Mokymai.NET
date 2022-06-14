
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


