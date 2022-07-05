using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook
{
    public class CreatePerson
    {
        public List<Person> People = new List<Person>();
        public void ListPerson()
        {
           if(People.Count == 0)
            {
                if (People.Count == 0) ;
                Console.WriteLine("Your Address book is empty please press to continue ....");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your Address book");
            foreach(var person in People)
            {
                PrintPerson(person);

            }
            Console.WriteLine("press key to continue");
            Console.ReadLine();
        }

        public void AddPerson(int a = -1)
        {
            Person person = new Person();
            Console.WriteLine("Enter First name: ");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Enter Phone number : ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter Your Address\nEnter Area/Colony Name: ");
            person.Area = Console.ReadLine();
            Console.Write("Enter CityName: ");
            person.City = Console.ReadLine();
            Console.Write("Enter State: ");
            person.State = Console.ReadLine();
            Console.Write("Enter ZipCode: ");
            person.ZipCode = Console.ReadLine();

            if (a == -1)
            {
                People.Add(person);
            }
            else
            {
                People.Insert(a, person);
            }

        }


        public void PrintPerson(Person person )
        {

            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address: Area " + person.Area);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("ZipCOde: " + person.ZipCode);


        }
        public void Edit(string Name)
        {
            for (int i = 0; i<People.Count; i++)
            {
                if(People[i].FirstName + " " + People[i].LastName == Name)
                {
                    Console.WriteLine("What you want to change: ");
                    Console.WriteLine("Enter \'1\' for Firstname '2\' for Last name\'3\' for phone number\'4\' for address\'5\' for ALL");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Enter the first name : ");
                            People[i].FirstName = Console.ReadLine();
                            Console.WriteLine();
                            PrintPerson(People[i]);
                            break;
                        case 2:
                            Console.WriteLine("Enter the Last name : ");
                            People[i].LastName = Console.ReadLine();
                            Console.WriteLine();
                            PrintPerson(People[i]);
                            break;
                        case 3:
                            Console.WriteLine("Enter the Phone Number : ");
                            People[i].PhoneNumber = Console.ReadLine();
                            Console.WriteLine();
                            PrintPerson(People[i]);
                            break;
                        case 4:
                            Console.WriteLine("Enter the Area name : ");
                            People[i].Area = Console.ReadLine();
                            Console.WriteLine("Enter City name: ");
                            People[i].City = Console.ReadLine();
                            Console.WriteLine("Enter a state name: ");
                            People[i].State = Console.ReadLine();
                            Console.WriteLine("Enter zipcode: ");
                            People[i].ZipCode = Console.ReadLine();
                            Console.WriteLine();
                            PrintPerson(People[i]);
                            break;
                        case 5:
                            AddPerson(i);
                            Console.WriteLine();
                            PrintPerson(People[i]);
                            break;
                        default:
                            Console.WriteLine("Invalid Number: ");
                            break;

                    }
                }
            }
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

    }
    
}