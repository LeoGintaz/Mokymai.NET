using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
     class HumanConstructor
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //Constructor
        public HumanConstructor(string firstName, string lastName, string eyeColor,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;


        }
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1} aged {3} my eye color is {2}", firstName, lastName, eyeColor,age);
        }
    }
}
