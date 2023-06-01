using System;
using System.Linq;
using InventoryLibrary;

namespace InventoryManager
{
    class InventoryManager
    {
        private static JSONStorage storage = new JSONStorage();

        static void Main(string[] args)
        {
            storage.Load();

            PrintMenu();

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (string.IsNullOrEmpty(command))
                    continue;

                string[] commandParts = command.Split(" ");

                switch (commandParts[0])
                {
                    case "classnames":
                        ClassNames();
                        break;

                    case "all":
                        if (commandParts.Length > 1)
                            All(commandParts[1]);
                        else
                            All();
                        break;

                    case "create":
                        if (commandParts.Length > 1)
                            Create(commandParts[1]);
                        else
                            Console.WriteLine("Invalid command.");
                        break;

                    // TODO: Implement other cases

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }

                PrintMenu();
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<ClassNames> show all ClassNames of objects");
            Console.WriteLine("<All> show all objects");
            Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> a new object");
            Console.WriteLine("<Show [ClassName object_id]> an object");
            Console.WriteLine("<Update [ClassName object_id]> an object");
            Console.WriteLine("<Delete [ClassName object_id]> an object");
            Console.WriteLine("<Exit>");
        }

        private static void ClassNames()
        {
            var classNames = storage.All().Select(x => x.Value.GetType().Name).Distinct();

            foreach (var name in classNames)
            {
                Console.WriteLine(name);
            }
        }

        private static void All(string className = null)
        {
            var objects = storage.All();

            foreach (var obj in objects)
            {
                if (className == null || obj.Value.GetType().Name.ToLower() == className)
                {
                    Console.WriteLine(obj.Value.ToString());
                }
            }
        }

        private static void Create(string className)
        {
            switch (className)
            {
                case "item":
                    Console.WriteLine("Enter name for the new item:");
                    string itemName = Console.ReadLine();

                    var item = new Item(itemName);

                    storage.New(item);
                    storage.Save();

                    Console.WriteLine("Item created and saved successfully.");
                    break;

                case "user":
                    Console.WriteLine("Enter name for the new user:");
                    string userName = Console.ReadLine();

                    var user = new User(userName);

                    storage.New(user);
                    storage.Save();

                    Console.WriteLine("User created and saved successfully.");
                    break;

                case "inventory":
                    Console.WriteLine("Enter user ID for the new inventory:");
                    string userId = Console.ReadLine();

                    Console.WriteLine("Enter item ID for the new inventory:");
                    string itemId = Console.ReadLine();

                    Console.WriteLine("Enter quantity for the new inventory:");
                    int quantity;
                    int.TryParse(Console.ReadLine(), out quantity);

                    var inventory = new Inventory(userId, itemId, quantity);

                    storage.New(inventory);
                    storage.Save();

                    Console.WriteLine("Inventory created and saved successfully.");
                    break;

                default:
                    Console.WriteLine($"{className} is not a valid object type.");
                    break;
            }
        }
    }
}