using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ 
    // From this example it is obvious that we are using Inheritance only to reduce the code to be written
    // There is nothing special in here and shadowing can be done for variables too.
    class Timeh
    {
        protected int hours;

        public Timeh(int hours)
        {
            this.hours = hours;
        }
        
        public void Print()
        {
            Console.WriteLine(hours);
        }
    }
    class Timem : Timeh
    {
        private int minutes;
         
        public Timem(int minutes, int hours) : base(hours)
        {

            this.minutes = minutes;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine(minutes);
        }

        public void Print(int yo)
        {
            base.Print();
            Console.WriteLine(minutes);
            Console.WriteLine("You have unlocked the secret");
        }
    }
    class Shadowing
    {
        public static void Main()
        {

            Timem t2 = new Timem(30,5);
            t2.Print();
            t2.Print(10);
        }
    }
}
