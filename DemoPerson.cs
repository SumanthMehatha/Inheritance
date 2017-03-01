using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /*Inhertiance is the very basic idea of Coding. It is able to optimise the re-usable code.How you do 
     that? Think of this below example which contains two different classes. Student and Employee
     these two classes have some common attributes like email, name parameters and methods like printing
     these parameters. Obviously one does not want to write the above code for every class. So all these
     common attributes are commoned out into single class and this class is inherited to each class*/
    class Person
    {
        protected string name;
        protected string email;

        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(email);
        }
    }
    // Syntax for inheriting the base class
    class Student : Person
    {
        private string college;

        // The constructor takes all the 4 values and passes the base class constructor values
        // using the :base keyword. So the constructor in base class is called and assignment of 
        // variables is done. Additional varibles are assigned here
        public Student(string name, string email, string college)
            : base(name, email)
        {
            this.college = college;
            
        }
        // We are creating a new method with the same as in base class. New is the keyword used here
        // and the process is called shadowing. Since a single class can inherit from only one base class
        // we can call base class methods using Base. keyword. 
        // NOTE: When inheritance happens the derived class loses the privilige of using names already 
        // use in base class to implement shadowing. And this process is automatically done by language.
        public new void Print()
        {
            base.Print();
            Console.WriteLine(college);
           
        }
    }

    class Employee : Person
    {
        private string company;
        private string department;

        public Employee(string name, string email, string company, string department)
            : base(name, email)
        {
            this.company = company;
            this.department = department;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine(company);
            Console.WriteLine(department);
        }
    }
    class DemoPerson
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Naidu", "ab@outlook.com", "TCS", ".NET");
            e.Print();
            Student s = new Student("Sumanth", "sm@outlook.com", "GVP");
            s.Print();
        }
    }
}
