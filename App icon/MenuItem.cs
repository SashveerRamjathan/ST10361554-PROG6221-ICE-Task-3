using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task_3.App_icon
{
    public class MenuItem
    {
        // A public property that requires a string value for the item's name
        public required string ItemName { get; set; }

        // An optional string property to store the item's description
        // This property can be null if no description is provided
        public string? ItemDescription { get; set; }

        // A public property that stores the item's price as a double
        public double ItemPrice { get; set; }

        // A public property that stores the item's quantity as an integer
        public int ItemQuantity { get; set; }
    }
}
