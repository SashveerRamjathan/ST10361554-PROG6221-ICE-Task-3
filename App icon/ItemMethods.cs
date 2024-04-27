using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task_3.App_icon
{
    public class ItemMethods
    {
        public List<MenuItem> items = new List<MenuItem>()
        {
            new MenuItem{ItemName="Avocado Toast with Poached Egg", ItemDescription="Multigrain toast topped with avocado, poached egg, cherry tomatoes, and feta cheese.", ItemPrice=75.99},
            new MenuItem{ItemName="Caprese Panini", ItemDescription="Ciabatta sandwich with fresh mozzarella, tomatoes, basil, and balsamic glaze.", ItemPrice=65.00},
            new MenuItem{ItemName="Mushroom and Spinach Quiche", ItemDescription="Savoury quiche with mushrooms, spinach, and Swiss cheese in a flaky crust.", ItemPrice=120.00},
            new MenuItem{ItemName="Classic Caesar Salad with Grilled Chicken", ItemDescription="Romaine lettuce, grilled chicken, cherry tomatoes, croutons, and Parmesan in Caesar dressing.", ItemPrice=110.00},
            new MenuItem{ItemName="Triple Chocolate Muffin", ItemDescription="Decadent muffin with dark and milk chocolate, topped with white chocolate drizzle.", ItemPrice=54.99},
            new MenuItem{ItemName="Caramel Macchiato", ItemDescription="Espresso, steamed milk, and a caramel drizzle for a sweet coffee treat.", ItemPrice=49.99},
            new MenuItem{ItemName="Berry Blast Smoothie", ItemDescription="Mixed berry, banana, yogurt, and honey blend for a refreshing smoothie.", ItemPrice=69.99},
            new MenuItem{ItemName="Chai Latte", ItemDescription="Black tea with aromatic spices and steamed milk for a comforting spiced beverage.", ItemPrice=35.00}
        };

        // List of MenuItem objects representing the items in the shopping cart
        public List<MenuItem> shoppingCart = new List<MenuItem>();

        // List of strings representing the names of items to be displayed
        public List<string> itemsNamesDisplay = new List<string>();

        // List of strings representing the items in the shopping cart to be displayed
        public List<string> shoppingCartDisplay = new List<string>();

        // List of strings representing the items that can be deleted from the shopping cart
        public List<string> deleteItemComboBoxItems = new List<string>();

        // Method to add an item to the shopping cart
        // Parameters:
        // name: string representing the name of the item to be added
        // quantity: integer representing the quantity of the item to be added
        public void AddItemToCart(string name, int quantity)
        {
            // Check if the name and quantity parameters are valid
            if (name!= null && name!= "" && quantity!= 0)
            {
                // Iterate through the list of MenuItem objects
                foreach (MenuItem item in items)
                {
                    // Check if the current MenuItem object's name matches the name parameter
                    if (item.ItemName.Equals(name))
                    {
                        // Update the quantity of the current MenuItem object
                        item.ItemQuantity = quantity;

                        // Add the current MenuItem object to the shopping cart
                        shoppingCart.Add(item);
                    }
                }
            }
            else
            {
                // Throw an exception if the name or quantity parameters are invalid
                throw new Exception(message: "No item was selected / Item quantity = 0 \nCheck both before continuing");
            }
        }

        // Method to remove an item from the shopping cart
        // Parameters:
        // name: string representing the name of the item to be removed
        // quantity: integer representing the quantity of the item to be removed
        public void RemoveItemFromCart(string name, int quantity)
        {
            // Initialize a variable to store the index of the item to be removed
            int itemToRemoveIndex = -1;

            // Check if the name and quantity parameters are valid
            if (name!= null && quantity!= 0)
            {
                // Iterate through the list of MenuItem objects in the shopping cart
                foreach (MenuItem item in shoppingCart)
                {
                    // Check if the current MenuItem object's name matches the name parameter
                    if (item.ItemName.Equals(name))
                    {
                        // Check if the quantity parameter is less than the current MenuItem object's quantity
                        if (quantity < item.ItemQuantity)
                        {
                            // Update the quantity of the current MenuItem object
                            item.ItemQuantity -= quantity;
                        }
                        // Check if the quantity parameter is equal to the current MenuItem object's quantity
                        else if (quantity == item.ItemQuantity)
                        {
                            // Store the index of the current MenuItem object
                            itemToRemoveIndex = shoppingCart.IndexOf(item);
                        }
                        // Throw an exception if the quantity parameter is greater than the current MenuItem object's quantity
                        else throw new Exception(message: "The item quantity you have entered is a invalid value");
                    }
                }

                // Check if the item to be removed has been found
                if (itemToRemoveIndex!= -1)
                {
                    // Remove the item from the shopping cart
                    shoppingCart.RemoveAt(itemToRemoveIndex);
                }
            }
            else
            {
                // Throw an exception if the name or quantity parameters are invalid
                throw new Exception(message: "No item was selected / Item quantity = 0 \nCheck both before continuing");
            }
        }

        // This method, DisplayMenuItemsNames, takes a list of MenuItem objects as an argument.
        // It initializes a new list of strings called names.
        public List<string> DisplayMenuItemsNames(List<MenuItem> items)
        {
            List<string> names = new List<string>();

            // The method checks if the list of MenuItem objects is not empty.
            if (items.Count > 0)
            {
                // It then iterates through each MenuItem object in the list.
                foreach (MenuItem item in items)
                {
                    // If the ItemName property of the MenuItem object is not null,
                    // it adds the ItemName to the names list.
                    if (item.ItemName!= null)
                    {
                        names.Add(item.ItemName);
                    }
                    // If the ItemName property is null, it throws an exception.
                    else
                    {
                        throw new Exception(message: "Menu item name is null");
                    }
                }
            }
            // If the list of MenuItem objects is empty, it throws an exception.
            else
            {
                throw new Exception(message: "There are no menu items stored");
            }

            // The method returns the list of strings containing the names of the menu items.
            return names;
        }

        // This method displays the menu for the user to choose an item
        public List<string> DisplayMenu()
        {
            // Initialize a new list to store the menu items
            List<string> menu = new List<string>();

            // Initialize a string variable to store each menu item
            string menuItem;

            // Loop through each MenuItem in the items list
            foreach (MenuItem item in items)
            {
                // Create the menu item string with the item's index, name, price, and description
                menuItem = $"{(items.IndexOf(item) + 1)}. {item.ItemName} - R{item.ItemPrice}" +
                           $"\n{item.ItemDescription}\n\n";

                // Add the menu item string to the menu list
                menu.Add(menuItem);
            }

            // Return the menu list
            return menu;
        }

        // This method displays the contents of the shopping cart
        public void DisplayShoppingCart()
        {
            // Check if the shopping cart contains any items
            if (shoppingCart.Count > 0)
            {
                // Clear the display before adding new items
                shoppingCartDisplay.Clear();

                // Initialize a string variable to hold the menu item details
                string menuItem;

                // Iterate through each item in the shopping cart
                foreach (MenuItem item in shoppingCart)
                {
                    // Format the menu item details as a string
                    menuItem = $"{item.ItemQuantity} - {item.ItemName} \n\n";

                    // Add the formatted menu item details to the display
                    shoppingCartDisplay.Add(menuItem);
                }
            }
            // If the shopping cart is empty, throw an exception
            else throw new Exception(message: "Shopping cart has no items, try adding one first");
        }

        // This method calculates the total price of all items in the shopping cart
        public double CalculateTotal()
        {
            // Initialize the total variable to zero
            double total = 0;

            // Check if the shopping cart contains any items
            if (shoppingCart.Count > 0)
            {
                // Iterate through each item in the shopping cart
                foreach (MenuItem item in shoppingCart)
                {
                    // Add the price of the current item, multiplied by its quantity, to the total
                    total += (item.ItemPrice * item.ItemQuantity);
                }
            }
            else
            {
                // If there are no items in the cart, throw an exception with a custom message
                throw new Exception(message: "No items in cart, try adding one");
            }

            // Return the calculated total
            return total;
        }

        // This method calculates the Value Added Tax (VAT) based on the total cost
        public double CalculateVAT(double total)
        {
            // Calculate VAT at 15% of the total cost
            double vat = (total * 0.15);

            // Return the calculated VAT
            return vat;
        }

        // This method calculates the total amount payable, including VAT (Value Added Tax)
        public double CalculateTotalPayable(double total, double VAT)
        {
            // Calculate the total payable by adding VAT to the total
            double totalPayable = (total + VAT);

            // Return the total payable amount
            return totalPayable;
        }

        // Generates and returns an ArrayList containing the details of the bill/invoice.
        public ArrayList DisplayBill()
        {
            // Initialize an ArrayList to store the bill details
            ArrayList bill = new ArrayList();

            // Generate invoice details
            string receiptHeading = "Café App Invoice"; // Heading of the receipt
            Random random = new Random(); // Initialize a Random object to generate a random receipt number
            int receiptNumber = random.Next(10000, 100000); // Generate a random receipt number between 10000 and 100000
            DateTime receiptGenerationDateTime = DateTime.Now; // Get the current date and time
            string dateTimeOfReceipt = receiptGenerationDateTime.ToString(); // Convert date and time to string
            double total = Math.Round(CalculateTotal(), 2); // Calculate total cost and round it to 2 decimal places
            double VAT = Math.Round(CalculateVAT(total), 2); // Calculate VAT and round it to 2 decimal places
            double totalPayable = Math.Round(CalculateTotalPayable(total, VAT), 2); // Calculate total payable and round it to 2 decimal places

            // Add receipt heading to the bill
            bill.Add(receiptHeading);

            // Add receipt number and date-time to the bill
            bill.Add($"Receipt Number: {receiptNumber}");
            bill.Add(dateTimeOfReceipt);

            // Add a label for the items section
            bill.Add("Items: ");

            // Iterate through the shopping cart and add each item to the bill
            foreach (MenuItem item in shoppingCart)
            {
                bill.Add($"{item.ItemQuantity} {item.ItemName} @ R{item.ItemPrice} => R{(item.ItemPrice * item.ItemQuantity)}");
            }

            // Add VAT and total payable to the bill
            bill.Add($"VAT: R{VAT}");
            bill.Add($"Total Due: R{totalPayable}");

            // Add closing remarks to the bill
            bill.Add("Thank You For Your Support");
            bill.Add("Please Call Again!");

            // Return the bill
            return bill;
        }
    }
}
