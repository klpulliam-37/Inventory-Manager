using InventoryProgramClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram
{
    // Class responsible for taking user input, 
    // and sending it to the BusinessDetailsForm
    // for processing.
    public partial class InputDataForm : Form
    {
        // Reference to the active child in the main form.
        BusinessDetailsForm activeChild;

        public InputDataForm()
        {
            InitializeComponent();
        }

        // Property for our custom user control.
        public ItemForm ItemForm { get { return this.itemForm; } set {} }

        // Sends data to the active store upon selecting 
        // the 'OK' button.
        private void okButton_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.Id = ItemForm.GetItemId();
            record.Name = ItemForm.GetItemName();
            record.Price = ItemForm.GetItemPrice();
            record.Quantity = ItemForm.GetItemQuantity();

            if (activeChild != null)
            {
                activeChild.AddItem(record);
            }
        }

        // Sets the reference for the active child so we can 
        // send data to it from this class.
        public void SetActiveChild(BusinessDetailsForm form)
        {
            this.activeChild = form;
        }

        // Closes the insert form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
