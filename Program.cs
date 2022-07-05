namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            CreatePerson createPerson = new CreatePerson();

            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Enter \'add\' to Add a person, Enter \'list' to list person AddressBook;");
                command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        createPerson.AddPerson();
                        break;
                    case "list":
                        createPerson.ListPerson();
                        break;
                    case "edit":
                        Console.Write("Enter the full name to edit: ");
                        string Name = Console.ReadLine();
                        createPerson.Edit(Name.Trim());
                        break;

                }

                Console.WriteLine("Enter \'exit\' to exit the AddressBook or \'1\' to continue");
                command=Console.ReadLine();

            }


        }
    }
}