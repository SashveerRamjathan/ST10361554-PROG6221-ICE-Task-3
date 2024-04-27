namespace ST10361554_PROG6221_ICE_Task_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            WelcomeLabel = new Label();
            MenuLabel = new Label();
            ItemUserChoiceLabel = new Label();
            ItemSelectComboBox = new ComboBox();
            ItemQuantityLabel = new Label();
            ShoppingCartLabel = new Label();
            ShoppingCartListBox = new ListBox();
            ConfirmActionButton = new Button();
            OrderInfoLabel = new Label();
            CheckOutInstructionLabel = new Label();
            CheckOutButton = new Button();
            WarningLabelQuantity = new Label();
            DeleteItemLabel = new Label();
            ItemDeleteComboBox = new ComboBox();
            DeleteItemButton = new Button();
            ItemQuantityNumBox = new NumericUpDown();
            RecieptRichTextbox = new RichTextBox();
            MenuRichTextbox = new RichTextBox();
            ItemQuantityDeleteLabel = new Label();
            ItemQuantityToDeleteNumBox = new NumericUpDown();
            ClearCartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ItemQuantityNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemQuantityToDeleteNumBox).BeginInit();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = SystemColors.ControlText;
            WelcomeLabel.Location = new Point(12, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(192, 20);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome to my Cafe App!";
            // 
            // MenuLabel
            // 
            MenuLabel.AutoSize = true;
            MenuLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuLabel.ForeColor = SystemColors.ControlText;
            MenuLabel.Location = new Point(12, 33);
            MenuLabel.Name = "MenuLabel";
            MenuLabel.Size = new Size(41, 15);
            MenuLabel.TabIndex = 1;
            MenuLabel.Text = "Menu:";
            // 
            // ItemUserChoiceLabel
            // 
            ItemUserChoiceLabel.AutoSize = true;
            ItemUserChoiceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemUserChoiceLabel.ForeColor = SystemColors.ControlText;
            ItemUserChoiceLabel.Location = new Point(565, 279);
            ItemUserChoiceLabel.Name = "ItemUserChoiceLabel";
            ItemUserChoiceLabel.Size = new Size(273, 15);
            ItemUserChoiceLabel.TabIndex = 3;
            ItemUserChoiceLabel.Text = "Please select one of our items from the box below:";
            // 
            // ItemSelectComboBox
            // 
            ItemSelectComboBox.BackColor = Color.FromArgb(241, 240, 239);
            ItemSelectComboBox.ForeColor = SystemColors.ControlText;
            ItemSelectComboBox.FormattingEnabled = true;
            ItemSelectComboBox.Location = new Point(565, 297);
            ItemSelectComboBox.Name = "ItemSelectComboBox";
            ItemSelectComboBox.Size = new Size(417, 23);
            ItemSelectComboBox.TabIndex = 4;
            // 
            // ItemQuantityLabel
            // 
            ItemQuantityLabel.AutoSize = true;
            ItemQuantityLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemQuantityLabel.ForeColor = SystemColors.ControlText;
            ItemQuantityLabel.Location = new Point(565, 333);
            ItemQuantityLabel.Name = "ItemQuantityLabel";
            ItemQuantityLabel.Size = new Size(417, 15);
            ItemQuantityLabel.TabIndex = 5;
            ItemQuantityLabel.Text = "Please enter the quantity of the item you would like to order in the box below:";
            // 
            // ShoppingCartLabel
            // 
            ShoppingCartLabel.AutoSize = true;
            ShoppingCartLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShoppingCartLabel.ForeColor = SystemColors.ControlText;
            ShoppingCartLabel.Location = new Point(565, 33);
            ShoppingCartLabel.Name = "ShoppingCartLabel";
            ShoppingCartLabel.Size = new Size(88, 15);
            ShoppingCartLabel.TabIndex = 7;
            ShoppingCartLabel.Text = "Shopping cart: ";
            // 
            // ShoppingCartListBox
            // 
            ShoppingCartListBox.BackColor = Color.FromArgb(241, 240, 239);
            ShoppingCartListBox.ForeColor = SystemColors.ControlText;
            ShoppingCartListBox.FormattingEnabled = true;
            ShoppingCartListBox.ItemHeight = 15;
            ShoppingCartListBox.Location = new Point(565, 51);
            ShoppingCartListBox.Name = "ShoppingCartListBox";
            ShoppingCartListBox.Size = new Size(458, 214);
            ShoppingCartListBox.TabIndex = 8;
            // 
            // ConfirmActionButton
            // 
            ConfirmActionButton.BackColor = Color.ForestGreen;
            ConfirmActionButton.FlatStyle = FlatStyle.Popup;
            ConfirmActionButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ConfirmActionButton.ForeColor = Color.Snow;
            ConfirmActionButton.Location = new Point(565, 386);
            ConfirmActionButton.Name = "ConfirmActionButton";
            ConfirmActionButton.Size = new Size(131, 31);
            ConfirmActionButton.TabIndex = 9;
            ConfirmActionButton.Text = "Add to Cart";
            ConfirmActionButton.UseVisualStyleBackColor = false;
            ConfirmActionButton.Click += ConfirmActionButton_Click;
            // 
            // OrderInfoLabel
            // 
            OrderInfoLabel.AutoSize = true;
            OrderInfoLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderInfoLabel.ForeColor = SystemColors.ControlText;
            OrderInfoLabel.Location = new Point(12, 279);
            OrderInfoLabel.Name = "OrderInfoLabel";
            OrderInfoLabel.Size = new Size(170, 15);
            OrderInfoLabel.TabIndex = 10;
            OrderInfoLabel.Text = "Customer Reciept Information:";
            // 
            // CheckOutInstructionLabel
            // 
            CheckOutInstructionLabel.AutoSize = true;
            CheckOutInstructionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutInstructionLabel.ForeColor = SystemColors.ControlText;
            CheckOutInstructionLabel.Location = new Point(12, 526);
            CheckOutInstructionLabel.Name = "CheckOutInstructionLabel";
            CheckOutInstructionLabel.Size = new Size(263, 15);
            CheckOutInstructionLabel.TabIndex = 12;
            CheckOutInstructionLabel.Text = "Click the Check Out button to generate a reciept:";
            // 
            // CheckOutButton
            // 
            CheckOutButton.BackColor = Color.Teal;
            CheckOutButton.FlatStyle = FlatStyle.Popup;
            CheckOutButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CheckOutButton.ForeColor = Color.Snow;
            CheckOutButton.Location = new Point(12, 553);
            CheckOutButton.Name = "CheckOutButton";
            CheckOutButton.Size = new Size(116, 35);
            CheckOutButton.TabIndex = 13;
            CheckOutButton.Text = "Check Out";
            CheckOutButton.UseVisualStyleBackColor = false;
            CheckOutButton.Click += CheckOutButton_Click;
            // 
            // WarningLabelQuantity
            // 
            WarningLabelQuantity.AutoSize = true;
            WarningLabelQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WarningLabelQuantity.ForeColor = Color.Red;
            WarningLabelQuantity.Location = new Point(702, 386);
            WarningLabelQuantity.Name = "WarningLabelQuantity";
            WarningLabelQuantity.Size = new Size(0, 17);
            WarningLabelQuantity.TabIndex = 14;
            // 
            // DeleteItemLabel
            // 
            DeleteItemLabel.AutoSize = true;
            DeleteItemLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteItemLabel.ForeColor = SystemColors.ControlText;
            DeleteItemLabel.Location = new Point(565, 437);
            DeleteItemLabel.Name = "DeleteItemLabel";
            DeleteItemLabel.Size = new Size(254, 15);
            DeleteItemLabel.TabIndex = 15;
            DeleteItemLabel.Text = "To delete an item, select it from the box below:";
            // 
            // ItemDeleteComboBox
            // 
            ItemDeleteComboBox.BackColor = Color.FromArgb(241, 240, 239);
            ItemDeleteComboBox.ForeColor = SystemColors.ControlText;
            ItemDeleteComboBox.FormattingEnabled = true;
            ItemDeleteComboBox.Location = new Point(565, 455);
            ItemDeleteComboBox.Name = "ItemDeleteComboBox";
            ItemDeleteComboBox.Size = new Size(417, 23);
            ItemDeleteComboBox.TabIndex = 16;
            // 
            // DeleteItemButton
            // 
            DeleteItemButton.BackColor = Color.Firebrick;
            DeleteItemButton.FlatStyle = FlatStyle.Popup;
            DeleteItemButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DeleteItemButton.ForeColor = Color.Snow;
            DeleteItemButton.Location = new Point(565, 553);
            DeleteItemButton.Name = "DeleteItemButton";
            DeleteItemButton.Size = new Size(131, 34);
            DeleteItemButton.TabIndex = 17;
            DeleteItemButton.Text = "Delete item";
            DeleteItemButton.UseVisualStyleBackColor = false;
            DeleteItemButton.Click += DeleteItemButton_Click;
            // 
            // ItemQuantityNumBox
            // 
            ItemQuantityNumBox.BackColor = Color.FromArgb(241, 240, 239);
            ItemQuantityNumBox.Location = new Point(565, 351);
            ItemQuantityNumBox.Name = "ItemQuantityNumBox";
            ItemQuantityNumBox.Size = new Size(417, 23);
            ItemQuantityNumBox.TabIndex = 19;
            // 
            // RecieptRichTextbox
            // 
            RecieptRichTextbox.BackColor = Color.FromArgb(241, 240, 239);
            RecieptRichTextbox.Location = new Point(12, 297);
            RecieptRichTextbox.Name = "RecieptRichTextbox";
            RecieptRichTextbox.Size = new Size(528, 208);
            RecieptRichTextbox.TabIndex = 22;
            RecieptRichTextbox.Text = "";
            // 
            // MenuRichTextbox
            // 
            MenuRichTextbox.BackColor = Color.FromArgb(241, 240, 239);
            MenuRichTextbox.Location = new Point(12, 51);
            MenuRichTextbox.Name = "MenuRichTextbox";
            MenuRichTextbox.Size = new Size(528, 214);
            MenuRichTextbox.TabIndex = 23;
            MenuRichTextbox.Text = "";
            // 
            // ItemQuantityDeleteLabel
            // 
            ItemQuantityDeleteLabel.AutoSize = true;
            ItemQuantityDeleteLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemQuantityDeleteLabel.ForeColor = SystemColors.ControlText;
            ItemQuantityDeleteLabel.Location = new Point(565, 490);
            ItemQuantityDeleteLabel.Name = "ItemQuantityDeleteLabel";
            ItemQuantityDeleteLabel.Size = new Size(214, 15);
            ItemQuantityDeleteLabel.TabIndex = 24;
            ItemQuantityDeleteLabel.Text = "Enter the quantity of the item to delete:";
            // 
            // ItemQuantityToDeleteNumBox
            // 
            ItemQuantityToDeleteNumBox.Location = new Point(565, 508);
            ItemQuantityToDeleteNumBox.Name = "ItemQuantityToDeleteNumBox";
            ItemQuantityToDeleteNumBox.Size = new Size(417, 23);
            ItemQuantityToDeleteNumBox.TabIndex = 25;
            // 
            // ClearCartButton
            // 
            ClearCartButton.BackColor = Color.Red;
            ClearCartButton.FlatStyle = FlatStyle.Popup;
            ClearCartButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ClearCartButton.ForeColor = Color.Snow;
            ClearCartButton.Location = new Point(851, 553);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(131, 34);
            ClearCartButton.TabIndex = 26;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = false;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1035, 600);
            Controls.Add(ClearCartButton);
            Controls.Add(ItemQuantityToDeleteNumBox);
            Controls.Add(ItemQuantityDeleteLabel);
            Controls.Add(MenuRichTextbox);
            Controls.Add(RecieptRichTextbox);
            Controls.Add(ItemQuantityNumBox);
            Controls.Add(DeleteItemButton);
            Controls.Add(ItemDeleteComboBox);
            Controls.Add(DeleteItemLabel);
            Controls.Add(WarningLabelQuantity);
            Controls.Add(CheckOutButton);
            Controls.Add(CheckOutInstructionLabel);
            Controls.Add(OrderInfoLabel);
            Controls.Add(ConfirmActionButton);
            Controls.Add(ShoppingCartListBox);
            Controls.Add(ShoppingCartLabel);
            Controls.Add(ItemQuantityLabel);
            Controls.Add(ItemSelectComboBox);
            Controls.Add(ItemUserChoiceLabel);
            Controls.Add(MenuLabel);
            Controls.Add(WelcomeLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafe App";
            ((System.ComponentModel.ISupportInitialize)ItemQuantityNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemQuantityToDeleteNumBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Label MenuLabel;
        private Label ItemUserChoiceLabel;
        private ComboBox ItemSelectComboBox;
        private Label ItemQuantityLabel;
        private Label ShoppingCartLabel;
        private ListBox ShoppingCartListBox;
        private Button ConfirmActionButton;
        private Label OrderInfoLabel;
        private Label CheckOutInstructionLabel;
        private Button CheckOutButton;
        private Label WarningLabelQuantity;
        private Label DeleteItemLabel;
        private ComboBox ItemDeleteComboBox;
        private Button DeleteItemButton;
        private NumericUpDown ItemQuantityNumBox;
        private RichTextBox RecieptRichTextbox;
        private RichTextBox MenuRichTextbox;
        private Label ItemQuantityDeleteLabel;
        private NumericUpDown ItemQuantityToDeleteNumBox;
        private Button ClearCartButton;
    }
}
