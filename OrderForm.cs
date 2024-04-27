using ST10361554_PROG6221_ICE_Task_3.App_icon;
using System.Collections;

namespace ST10361554_PROG6221_ICE_Task_3
{
    public partial class Form1 : Form
    {
        ItemMethods methods = new ItemMethods();

        public Form1()
        {
            InitializeComponent();
            ItemQuantityNumBox.Maximum = Decimal.MaxValue;
            ItemQuantityToDeleteNumBox.Maximum = Decimal.MaxValue;
            InitializeMenuDisplay();
            InitializeItemSelectComboBox();

        }

        private void ConfirmActionButton_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = ItemSelectComboBox.Text;
                int itemQuantity = Convert.ToInt32(ItemQuantityNumBox.Value);

                methods.AddItemToCart(itemName, itemQuantity);

                methods.DisplayShoppingCart();

                ShoppingCartListBox.Items.Clear();

                foreach (string item in methods.shoppingCartDisplay)
                {
                    ShoppingCartListBox.Items.Add(item);
                }

                methods.deleteItemComboBoxItems = methods.DisplayMenuItemsNames(methods.shoppingCart);

                ItemDeleteComboBox.Items.Clear();

                foreach (string item in methods.deleteItemComboBoxItems)
                {
                    ItemDeleteComboBox.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add item failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ItemSelectComboBox.SelectedIndex = -1;
                ItemQuantityNumBox.Value = 0;
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = ItemDeleteComboBox.Text;
                int itemQuantity = Convert.ToInt32(ItemQuantityToDeleteNumBox.Value);


                methods.RemoveItemFromCart(itemName, itemQuantity);
                
                ShoppingCartListBox.Items.Clear();

                if (methods.shoppingCart.Count > 0)
                {
                    methods.DisplayShoppingCart();

                    foreach (string item in methods.shoppingCartDisplay)
                    {
                        ShoppingCartListBox.Items.Add(item);
                    }

                    ItemDeleteComboBox.Items.Clear();

                    methods.deleteItemComboBoxItems = methods.DisplayMenuItemsNames(methods.shoppingCart);

                    foreach (string item in methods.deleteItemComboBoxItems)
                    {
                        ItemDeleteComboBox.Items.Add(item);
                    }
                }
                else
                {
                    ItemDeleteComboBox.Items.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete item failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ItemDeleteComboBox.SelectedIndex = -1;
                ItemDeleteComboBox.Text = null;
                ItemQuantityToDeleteNumBox.Value = 0;
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                RecieptRichTextbox.Clear();
                ArrayList bill = methods.DisplayBill();

                foreach (string item in bill)
                {
                    RecieptRichTextbox.AppendText(item);
                    RecieptRichTextbox.AppendText("\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Receipt generation failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (methods.shoppingCart.Count > 0)
                {
                    methods.shoppingCart.Clear();

                    ShoppingCartListBox.Items.Clear();

                    ItemDeleteComboBox.Items.Clear();
                }
                else throw new Exception(message: "No Items in cart to clear");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Clear Cart failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InitializeMenuDisplay()
        {
            List<string> items = methods.DisplayMenu();

            foreach (string item in items)
            {
                MenuRichTextbox.AppendText(item);
            }

        }

        public void InitializeItemSelectComboBox()
        {
            List<string> items = methods.DisplayMenuItemsNames(methods.items);

            foreach (string item in items)
            {
                ItemSelectComboBox.Items.Add(item);
            }
        }

        
    }
}
