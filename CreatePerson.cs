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

        public void AddPerson()
        {
            Person person = new Person();
            Console.WriteLine("Enter First name: ");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Enter Phone number : ");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Write Your Address");
            string[] addresses = new string[4];
            addresses[0]= Console.ReadLine();
            Console.WriteLine("Enter CityName: ");
            addresses[1]= Console.ReadLine();
            Console.WriteLine("Enter state: ");
            addresses[2]= Console.ReadLine();
            Console.WriteLine("Enter Pin: ");
            addresses[3]= Console.ReadLine();
            person.Addresses = addresses;

            People.Add(person);


        }
        public void PrintPerson(Person person )
        {

            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address: Area " + person.Addresses[0]);
            Console.WriteLine(" City: " + person.Addresses[1]);
            Console.WriteLine(" State: " + person.Addresses[2]);
            Console.WriteLine(" ZipCOde: " + person.Addresses[3]);



        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public string[] Addresses { get; set; }
    }
    
}