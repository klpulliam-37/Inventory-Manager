using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgramClassLibrary
{
    // Class representing our text boxes to take
    // in user data.
    public partial class ItemForm : UserControl
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        public int GetItemId() { return Convert.ToInt32(itemIDTextBox.Text); }

        public String GetItemName() { return itemNameTextBox.Text; }

        public double GetItemPrice() { return Convert.ToDouble(itemPriceTextBox.Text); }

        public int GetItemQuantity() { return Convert.ToInt32(itemQuantityTextBox.Text); }
    }
}
