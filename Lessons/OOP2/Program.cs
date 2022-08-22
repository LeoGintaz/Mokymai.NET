namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create object of my class or an instance  of human
            Human denis = new Human();
            // acces public var from outside, and even change it
            denis.firstName = "Denis";
            // call method of the class
            denis.IntroduceMyself();
            //--------------------------------//
            Human michael = new Human();
            michael.IntroduceMyself(); // will write "my name is " since first name is not given.
            //-------------------------------//
            
            Human tom = new Human();
            tom.firstName = "Tom";
            tom.lastName = "Hardy";
            tom.IntroduceMyself();// will write Mu name is Tom Hardy

            Human bob = new Human();
            bob.firstName = "Bob";
            bob.lastName = "Saget";//Will write my name is Bob Ssaget
            bob.IntroduceMyself();

            Human john = new Human();
            john.firstName = "John"; // will wtire John Doe, because last name is not given and default is Doe           
            john.IntroduceMyself();

            HumanConstructor johny = new HumanConstructor("Johny","Bravo","blue",26);
            johny.IntroduceMyself(); // will write Johny Bravo aged 26 my eye color is blue

            HumanConstructor jane = new HumanConstructor("Jane","Janet","my buissness", 21);
            jane.IntroduceMyself();//will write I am Jane Janet aged 21 my eye color is my buissness
        }
    }
}