using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //this class is a blueprint for a data type
    internal class Human
    {
        //member : var
        public string firtname;
        public string lastname = "Doe";

        //member method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}",firtname, lastname);
        }
    }
}
