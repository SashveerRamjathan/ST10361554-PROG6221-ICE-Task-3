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
            new MenuItem{ItemName="Mushroom and Spinach Quiche", ItemDescription="Savory quiche with mushrooms, spinach, and Swiss cheese in a flaky crust.", ItemPrice=120.00},
            new MenuItem{ItemName="Classic Caesar Salad with Grilled Chicken", ItemDescription="Romaine lettuce, grilled chicken, cherry tomatoes, croutons, and Parmesan in Caesar dressing.", ItemPrice=110.00},
            new MenuItem{ItemName="Triple Chocolate Muffin", ItemDescription="Decadent muffin with dark and milk chocolate, topped with white chocolate drizzle.", ItemPrice=54.99},
            new MenuItem{ItemName="Caramel Macchiato", ItemDescription="Espresso, steamed milk, and a caramel drizzle for a sweet coffee treat.", ItemPrice=49.99},
            new MenuItem{ItemName="Berry Blast Smoothie", ItemDescription="Mixed berry, banana, yogurt, and honey blend for a refreshing smoothie.", ItemPrice=69.99},
            new MenuItem{ItemName="Chai Latte", ItemDescription="Black tea with aromatic spices and steamed milk for a comforting spiced beverage.", ItemPrice=35.00}
        };

        public List<MenuItem> shoppingCart = new List<MenuItem>();

        public List<string> itemsNamesDisplay = new List<string>();

        public List<string> shoppingCartDisplay = new List<string>();

        public List<string> deleteItemComboBoxItems = new List<string>();

        public void AddItemToCart(string name, int quantity)
        {
            if (name != null && name != "" && quantity != 0)
            {
                foreach (MenuItem item in items)
                {
                    if (item.ItemName.Equals(name))
                    {
                        item.ItemQuantity = quantity;
                        shoppingCart.Add(item);
                    }
                }
            }
            else throw new Exception(message: "No item was selected / Item quantity = 0 \nCheck both before continuing");
        }

        public void RemoveItemFromCart(string name, int quantity)
        {
            int itemToRemoveIndex = -1;

            if (name != null && quantity != 0)
            {
                foreach (MenuItem item in shoppingCart)
                {
                    if (item.ItemName.Equals(name))
                    {
                        if(quantity < item.ItemQuantity)
                        {
                            item.ItemQuantity -= quantity;
                        }
                        else if(quantity == item.ItemQuantity)
                        {
                            itemToRemoveIndex = shoppingCart.IndexOf(item);
                        }
                        else throw new Exception(message: "The item quantity you have entered is a invalid value");
                    }
                }

                if (itemToRemoveIndex != -1)
                {
                    shoppingCart.RemoveAt(itemToRemoveIndex);
                }
            }
            else throw new Exception(message: "No item was selected / Item quantity = 0 \nCheck both before continuing");
        }

        public List<string> DisplayMenuItemsNames(List<MenuItem> items)
        {
            List<string> names = new List<string>();

            if (items.Count > 0)
            {
                foreach (MenuItem item in items)
                {
                    if (item.ItemName != null)
                    {
                        names.Add(item.ItemName);
                    }
                    else throw new Exception(message: "Menu item name is null");
                }
            }
            else throw new Exception(message: "There are no menu items stored");

            return names;
        }

        public List<string> DisplayMenu()
        {
            List<string> menu = new List<string>();

            string menuItem;

            foreach(MenuItem item in items)
            {
                menuItem = $"{(items.IndexOf(item) + 1)}. {item.ItemName} - R{item.ItemPrice}" +
                           $"\n{item.ItemDescription}\n\n";

                menu.Add(menuItem);
            }

            return menu;
        }

        public void DisplayShoppingCart()
        {
            if (shoppingCart.Count > 0)
            {
                shoppingCartDisplay.Clear();

                string menuItem;

                foreach (MenuItem item in shoppingCart)
                {
                    menuItem = $"{item.ItemQuantity} - {item.ItemName} \n\n";
                    shoppingCartDisplay.Add(menuItem);
                }
            }
            else throw new Exception(message: "Shopping cart has no items, try adding  one first");
        }

        public double CalculateTotal()
        {
            double total = 0;

            if (shoppingCart.Count > 0)
            {
                foreach (MenuItem item in shoppingCart)
                {
                    total += (item.ItemPrice * item.ItemQuantity);
                }
            }
            else throw new Exception(message: "No items in cart, try adding one");

            return total;
        }

        public double CalculateVAT(double total)
        {
            // Calculate VAT based on the total cost
            double vat = (total * 0.15); // Calculate VAT at 15%
            return vat; // Return the calculated VAT
        }

        public double CalculateTotalPayable(double total, double VAT)
        {
            // Calculate the total amount payable including VAT
            double totalPayable = (total + VAT); // Calculate total payable by adding VAT to the total
            return totalPayable; // Return the total payable amount
        }

        public ArrayList DisplayBill()
        {
            ArrayList bill = new ArrayList();

            // Generate invoice details
            string receiptHeading = "Cafe App Invoice";
            Random random = new Random();
            int receiptNumber = random.Next(10000, 100000); // Generate a random receipt number
            DateTime receiptGenerationDateTime = DateTime.Now; // Get the current date and time
            string dateTimeOfReceipt = receiptGenerationDateTime.ToString(); // Convert date and time to string
            double total = Math.Round(CalculateTotal(), 2); // Calculate total cost
            double VAT = Math.Round(CalculateVAT(total), 2); // Calculate VAT
            double totalPayable = Math.Round(CalculateTotalPayable(total, VAT), 2); // Calculate total payable

            bill.Add(receiptHeading);
            
            bill.Add($"Receipt Number: {receiptNumber}");
            bill.Add(dateTimeOfReceipt);
         
            bill.Add("Items: ");

            foreach (MenuItem item in shoppingCart)
            {
                bill.Add($"{item.ItemQuantity} {item.ItemName} @ R{item.ItemPrice} => R{(item.ItemPrice * item.ItemQuantity)}");
            }

     
            bill.Add($"VAT: R{VAT}");
            bill.Add($"Total Due: R{totalPayable}");
         
            bill.Add("Thank You For Your Support");
            bill.Add("Please Call Again!");

            return bill;
        }
    }
}
