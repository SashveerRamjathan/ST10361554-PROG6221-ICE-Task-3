using ST10361554_PROG6221_ICE_Task_3.App_icon;
using System.Collections;

namespace ST10361554_PROG6221_ICE_Task_3
{
    public partial class Form1 : Form
    {
        // Initialize the ItemMethods object
        ItemMethods methods = new ItemMethods();

        // Constructor for the Form1 class
        public Form1()
        {
            // Initialize the components of the form
            InitializeComponent();

            // Set the maximum value of the ItemQuantityNumBox to the maximum value of the Decimal data type
            ItemQuantityNumBox.Maximum = Decimal.MaxValue;

            // Set the maximum value of the ItemQuantityToDeleteNumBox to the maximum value of the Decimal data type
            ItemQuantityToDeleteNumBox.Maximum = Decimal.MaxValue;

            // Call the InitializeMenuDisplay method to initialize the menu display
            InitializeMenuDisplay();

            // Call the InitializeItemSelectComboBox method to initialize the item select combo box
            InitializeItemSelectComboBox();
        }

        // Event handler for the ConfirmActionButton click event
        private void ConfirmActionButton_Click(object sender, EventArgs e)
        {
            // Try to execute the following code
            try
            {
                // Get the selected item name from the ItemSelectComboBox
                string itemName = ItemSelectComboBox.Text;

                // Convert the selected item quantity from the ItemQuantityNumBox to an integer
                int itemQuantity = Convert.ToInt32(ItemQuantityNumBox.Value);

                // Call the AddItemToCart method of the ItemMethods object to add the selected item and quantity to the shopping cart
                methods.AddItemToCart(itemName, itemQuantity);

                // Call the DisplayShoppingCart method of the ItemMethods object to display the shopping cart
                methods.DisplayShoppingCart();

                // Clear the items in the ShoppingCartListBox
                ShoppingCartListBox.Items.Clear();

                // Loop through the shopping cart display and add each item to the ShoppingCartListBox
                foreach (string item in methods.shoppingCartDisplay)
                {
                    ShoppingCartListBox.Items.Add(item);
                }

                // Get the items in the shopping cart to be displayed in the ItemDeleteComboBox
                methods.deleteItemComboBoxItems = methods.DisplayMenuItemsNames(methods.shoppingCart);

                // Clear the items in the ItemDeleteComboBox
                ItemDeleteComboBox.Items.Clear();

                // Loop through the items in the shopping cart and add each item to the ItemDeleteComboBox
                foreach (string item in methods.deleteItemComboBoxItems)
                {
                    ItemDeleteComboBox.Items.Add(item);
                }
            }
            // Catch any exceptions that occur during the execution of the code
            catch (Exception ex)
            {
                // Display a message box with the error message
                MessageBox.Show($"Add item failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Finally, set the selected index of the ItemSelectComboBox to -1 and set the value of the ItemQuantityNumBox to 0
            finally
            {
                ItemSelectComboBox.SelectedIndex = -1;
                ItemQuantityNumBox.Value = 0;
            }
        }

        // Event handler for the DeleteItemButton click event
        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            // Try to execute the following code
            try
            {
                // Get the selected item name from the ItemDeleteComboBox
                string itemName = ItemDeleteComboBox.Text;

                // Convert the selected item quantity from the ItemQuantityToDeleteNumBox to an integer
                int itemQuantity = Convert.ToInt32(ItemQuantityToDeleteNumBox.Value);

                // Call the RemoveItemFromCart method of the ItemMethods object to remove the selected item and quantity from the shopping cart
                methods.RemoveItemFromCart(itemName, itemQuantity);

                // Clear the items in the ShoppingCartListBox
                ShoppingCartListBox.Items.Clear();

                // Check if the shopping cart is not empty
                if (methods.shoppingCart.Count > 0)
                {
                    // Call the DisplayShoppingCart method of the ItemMethods object to display the shopping cart
                    methods.DisplayShoppingCart();

                    // Loop through the shopping cart display and add each item to the ShoppingCartListBox
                    foreach (string item in methods.shoppingCartDisplay)
                    {
                        ShoppingCartListBox.Items.Add(item);
                    }

                    // Clear the items in the ItemDeleteComboBox
                    ItemDeleteComboBox.Items.Clear();

                    // Get the items in the shopping cart to be displayed in the ItemDeleteComboBox
                    methods.deleteItemComboBoxItems = methods.DisplayMenuItemsNames(methods.shoppingCart);

                    // Loop through the items in the shopping cart and add each item to the ItemDeleteComboBox
                    foreach (string item in methods.deleteItemComboBoxItems)
                    {
                        ItemDeleteComboBox.Items.Add(item);
                    }
                }
                // If the shopping cart is empty, clear the items in the ItemDeleteComboBox
                else
                {
                    ItemDeleteComboBox.Items.Clear();
                }
            }
            // Catch any exceptions that occur during the execution of the code
            catch (Exception ex)
            {
                // Display a message box with the error message
                MessageBox.Show($"Delete item failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Finally, set the selected index of the ItemDeleteComboBox to -1 and set the value of the ItemQuantityToDeleteNumBox to 0
            finally
            {
                ItemDeleteComboBox.SelectedIndex = -1;
                ItemDeleteComboBox.Text = null;
                ItemQuantityToDeleteNumBox.Value = 0;
            }
        }

        // Event handler for the CheckOutButton click event
        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            // Try to execute the following code
            try
            {
                // Clear the RecieptRichTextbox
                RecieptRichTextbox.Clear();

                // Call the DisplayBill method of the ItemMethods object to display the bill
                ArrayList bill = methods.DisplayBill();

                // Loop through the bill and add each item to the RecieptRichTextbox
                foreach (string item in bill)
                {
                    RecieptRichTextbox.AppendText(item);
                    RecieptRichTextbox.AppendText("\n");
                }
            }
            // Catch any exceptions that occur during the execution of the code
            catch (Exception ex)
            {
                // Display a message box with the error message
                MessageBox.Show($"Receipt generation failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the ClearCartButton click event
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            // Try to execute the following code
            try
            {
                // Check if the shopping cart is not empty
                if (methods.shoppingCart.Count > 0)
                {
                    // Clear the shopping cart
                    methods.shoppingCart.Clear();

                    // Clear the items in the ShoppingCartListBox
                    ShoppingCartListBox.Items.Clear();

                    // Clear the items in the ItemDeleteComboBox
                    ItemDeleteComboBox.Items.Clear();
                }
                // If the shopping cart is empty, display a message box with a warning message
                else
                {
                    MessageBox.Show("No Items in cart to clear", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Catch any exceptions that occur during the execution of the code
            catch (Exception ex)
            {
                // Display a message box with the error message
                MessageBox.Show($"Clear Cart failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public void InitializeMenuDisplay()
        {
            // Initialize the ItemMethods object
            ItemMethods methods = new ItemMethods();

            // Get the menu items from the ItemMethods object
            List<string> items = methods.DisplayMenu();

            // Loop through the menu items and add each item to the MenuRichTextbox
            foreach (string item in items)
            {
                MenuRichTextbox.AppendText(item);
                MenuRichTextbox.AppendText("\n");
            }
        }

        
        public void InitializeItemSelectComboBox()
        {
            // Initialize the ItemMethods object
            ItemMethods methods = new ItemMethods();

            // Get the menu items from the ItemMethods object
            List<string> items = methods.DisplayMenuItemsNames(methods.items);

            // Loop through the menu items and add each item to the ItemSelectComboBox
            foreach (string item in items)
            {
                ItemSelectComboBox.Items.Add(item);
            }
        }


    }
}
