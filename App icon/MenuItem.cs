using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task_3.App_icon
{
    public class MenuItem
    {
        public required string ItemName { get; set; }
        public string? ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
    }
}
