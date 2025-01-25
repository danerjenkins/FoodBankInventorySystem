using FoodBankInventorySystem;

bool run = true;
List<FoodItem> foodItems = new List<FoodItem>();
Console.WriteLine("Welcome to the Food Bank Inventory System App!");
Console.WriteLine("We help tracking items, monitoring expiration dates, and manage donations and distributions!");


while (run)
{
    Console.WriteLine("To choose an action, type the corresponding number.");
    Console.WriteLine("1. Add a new item");
    Console.WriteLine("2. Remove an item");
    Console.WriteLine("3. Print list of current items");
    Console.WriteLine("4. Exit the program");
    Console.Write("What would you like to do? ");
    string input = Console.ReadLine();
    if (input == "1")
    {
        bool isValidInput = false;
        string name, category, quantity, expirationDate;

        do
        {
            Console.Write("Enter the name of the food item: ");
            name = Console.ReadLine();
            if (name != "")
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Name cannot be empty.");
            }
        } while (!isValidInput);

        isValidInput = false;
        do
        {
            Console.Write("Enter the category of the food item: ");
            category = Console.ReadLine();
            if (category != "")
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Category cannot be empty.");
            }
        } while (!isValidInput);

        isValidInput = false;
        do
        {
            Console.Write("Enter the quantity: ");
            quantity = Console.ReadLine();
            if ( int.Parse(quantity)> 0)
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Quantity must be a positive integer.");
            }
        } while (!isValidInput);

        isValidInput = false;
        do
        {
            Console.Write("Enter the expiration date: ");
            expirationDate = Console.ReadLine();
            if (expirationDate!="")
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter date.");
            }
        } while (!isValidInput);

        foodItems.Add(new FoodItem(name, category, quantity, expirationDate));
    }
    else if (input == "2")
    {
        if (foodItems.Count == 0)
        {
            Console.WriteLine("There are no items to remove.");
        }
        else { 
            Console.Write("Enter the name of the food item you would like to remove: ");
            string name = Console.ReadLine();
            for (int i = 0; i < foodItems.Count; i++)
            {
                if (foodItems[i].Name == name)
                {
                    foodItems.RemoveAt(i);
                    break;
                }
            }
        }
    }
    else if (input == "3")
    {
        if (foodItems.Count == 0)
        {
            Console.WriteLine("There are no items in the inventory.");
        }
        else
        {
            for (int i = 0; i < foodItems.Count; i++)
            {
                Console.WriteLine("Food Name: " + foodItems[i].Name + " Food Category: " + foodItems[i].Category + " Item Quantity:  " + foodItems[i].Quantity + " Expiration Date: " + foodItems[i].ExpirationDate);
            }
        }
    }
    else if (input == "4")
    {
        Console.WriteLine("Thank you for using the Food Bank Inventory System App. Goodbye!");
        run = false;
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
    }
}
