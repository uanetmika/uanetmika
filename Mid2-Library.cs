using System;
using System.Collections.Generic;

enum Selectmenu { Login = 1 , Register = 2}

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu()
        {
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("------------------------------");
            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Register");
            Console.Write("Select Menu : ");
            Selectmenu mn = (Selectmenu)(int.Parse(Console.ReadLine()));
            Register();


        }
        static void selectmenu(Selectmenu mn)
        {
            if (mn == Selectmenu.Login)
            {

            }
            else if (mn == Selectmenu.Register)
            {
                Register();
            }
        }

        static void Register()
        {
            Console.WriteLine("Register new Person");
            Console.WriteLine("-----------------------");
            Inputyourtype();
        }
        static string Inputyourtype()
        {
            
            Console.Write("Input name : ");
            string name = Console.ReadLine(); 
            Console.Write("Input password : ");
            int pw = int.Parse(Console.ReadLine());
            Console.Write("Input type : ");
            int t = int.Parse(Console.ReadLine());

            if (t == 1)
            {
                informationStudent();
                Console.Clear();
                Student student = creatnewstudent();
                Program.personlist.AddPerson(student);
                MainMenu();
            }
            else if (t == 2)
            {
                informationEmployee();
                Console.Clear();
                Employee employee = creatnewemployee();
                Program.personlist.AddPerson(employee);
                MainMenu();
            }
            return Console.ReadLine();
        }
        static PersonList personlist;
        static void PreparePersonListWhenLoading()
        {
            Program.personlist = new PersonList();
        }
        static Student creatnewstudent() 
        {
            return new Student(InputYourName(),InputYourPassword(),Inputyourtype(), informationStudent());

        }
        static string InputYourName()
        {
            Console.Write("Input Name: ");

            return Console.ReadLine();
        }
        static string InputYourPassword()
        {
            Console.Write("Input Password : ");

            return Console.ReadLine();
        }

        static string informationStudent() 
        {
            Console.Write("StudentID : ");
            return Console.ReadLine();
        }
        static Employee creatnewemployee()
        {
            return new Employee(InputYourName(), InputYourPassword(),Inputyourtype(), informationEmployee());

        }
        static string informationEmployee() 
        {
            Console.Write("EmployeeID : ");
            return Console.ReadLine();
        }

    }
    class Person 
    {
        public string name;
        public string password;
        public string type;
        public Person(String valuename, String valuepassword,string valuetype)
        {
            name = valuename;
            password = valuepassword;
            type = valuetype;
        }
    }
    class Student : Person
    {
        public string name;
        public string password;
        public string StudentID;
        public string type;
        public Student(String valuename, String valuepassword, String valueStudentID,string valuetype) : base(valuename,valuepassword,valuetype)
        {
            name = valuename;
            password = valuepassword;
            StudentID = valueStudentID;
            type = valuetype;
    }
    }
    class Employee : Person
    {
        public string name;
        public string password;
        public string EmployeeID;
        public string type;
        public Employee(String valuename, String valuepassword, String valueEmployeeID,string valuetype) : base(valuename, valuepassword,valuetype)
        {
            name = valuename;
            password = valuepassword;
            EmployeeID = valueEmployeeID;
            type = valuetype;
        }
    }
    class PersonList
    {
        private List<Person> personLists;

        public PersonList()
        {
            this.personLists = new List<Person>();
        }
        public void AddPerson(Person person)
        {
            this.personLists.Add(person);
        }
    }
}
