namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create object of my class or an instance  of human
            Human denis = new Human();
            // acces public var from outside, and even change it
            denis.firtname = "Denis";
            // call method of the class
            denis.IntroduceMyself();
            //--------------------------------//
            Human michael = new Human();
            michael.IntroduceMyself(); // will write "my name is " since first name is not given.
            //-------------------------------//
            
            Human tom = new Human();
            tom.firtname = "Tom";
            tom.lastname = "Hardy";
            tom.IntroduceMyself();

            Human bob = new Human();
            bob.firtname = "Bob";
            bob.lastname = "Saget";
            bob.IntroduceMyself();

            Human john = new Human();
            john.firtname = "John";
            
            john.IntroduceMyself();
        }
    }
}