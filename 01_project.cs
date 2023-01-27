// this is a project that test the created class person. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this is a class for the 01 project that deals with personal information
//The class should has one constructor with three parameters, namely thename, the surname and the yearOfbirth. 
//The address of the person is set initially to an emptystring "" inside the constructor; it can be set later on via invoking the SetAddress method.
//Inside the Main entry-point of the project create two instances of the above class Person withsome relevant information for all the attributes. 
//Print on the screen the information of those Person objects via invoking their Display method.

namespace Week5test
{
    class Person
    {
        private string name;
        private string surname;
        private int yearOfBirth;
        private string address;

        public Person(string fname, string sfurname, int yob)
        {
            name = fname;
            surname = sfurname;
            yearOfBirth = yob;
            address = "";
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public int GetYearOfBirth()
        {
            return yearOfBirth;
        }

        public void SetAddress(string addr)
        {
            address = addr;
        }

        public string GetAddress()
        {
            return address;
        }

        public void Display()
        {
            Console.WriteLine("Personal Information");
            Console.WriteLine($"Name: {name} {surname}");
            Console.WriteLine($"Year Of Birth: {yearOfBirth}");
            Console.WriteLine($"Address: {address}");
        }
    }
}

namespace Week5test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random r = new Random();
            //double number = r.NextDouble();
            //int number = r.Next(1, 7);

            //Console.WriteLine(number);

            
            Person jason = new Person ("Jason", "Samuels", 1888);
            Person sarah = new Person("Sarah", "Samuels", 1889);

            sarah.SetAddress("12 Violet Street");
            jason.Display();
            Console.WriteLine();
            sarah.Display();
            jason.SetAddress("Admiralty Avenue");
            sarah.SetAddress("Glover Court");
                
        }
    }
}
