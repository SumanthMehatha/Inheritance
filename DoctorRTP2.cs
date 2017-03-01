using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// A program which has docotor as base class and derived classes are Rdoctor and consultants. 
// RDocotors have monthly pay. Consultants have pay per visit. The program should display a message
// if salary is above 20000 to pay by check or if less by cash.
// All doctors have name and mobile number
// Virtual is for doing this program without run time polymorphism
namespace Inheritance2
{
   abstract class Doctor // A class with abstract method is an abstract class
    {
        protected string name;
        protected string mobileNo;

        public Doctor(string name, string mobileNo)
        {
            this.name = name;
            this.mobileNo = mobileNo;
        }

        public virtual void Print() // virtual keyword
        {
            Console.WriteLine(name);
            Console.WriteLine(mobileNo);
        }

        public abstract int GetSalary(); // No body for abstract methods but a ;
      // NOTE: Abstract method unlike virtual method should be overriden in every derived class
    }

    class RDoctor : Doctor
    {
        private int salary;

        public RDoctor(string name, string mobileNo, int salary) : base(name, mobileNo)
        {
            this.salary = salary;
        }

        public override void Print() //new replaced by override
        {
            base.Print();
            Console.WriteLine(salary);
        }

        public override int GetSalary()// return type of virtual method and override method must be same
        {
            return salary;
        }
    }

    class Consultant : Doctor
    {
        private int visits;
        private int pay;

        public Consultant(string name, string mobileNo, int visits, int pay) : base(name, mobileNo)
        {
            this.visits = visits;
            this.pay = pay;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(visits);
            Console.WriteLine(pay);
        }

        public override int GetSalary()
        {
            return (pay * visits);
        }
    }
    class Virtual
    {
        static void Main(string[] args)
        {
            RDoctor r = new RDoctor("Mr.Samaram", "6969696969", 30000);
            Consultant c = new Consultant("Sherman", "98764504", 5, 2000);
            Print(r);
            Print(c);
            Doctor r2 = new RDoctor("Samram 2", "55445333", 116);
            // The above line was possible because the object reference of base class can point to an
            // derived class object.(The universal truth is Derived class IS A Base class)
            r2.Print();
            // Now runs correctly
        }
        public static void Print(Doctor x)
        {
            x.Print();
            int sal = x.GetSalary();

            if (sal <= 20000)
                Console.WriteLine("Pay by check");
            else
                Console.WriteLine("Pay by cash");

        }
    }
}
