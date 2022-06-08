namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Tuple<string, string, int, DateTime> tuple = new Tuple<string, string, int, DateTime>("Code Academy", ".NetMokymai", 22, DateTime.Now);
            Console.WriteLine(tuple);



            }
        }
    }