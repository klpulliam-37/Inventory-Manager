using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram
{
    // Class that represents our child business forms
    // and their inventories.
    public partial class BusinessDetailsForm : Form
    {
        // Default format settings for string representation of records
        String headersFormat = "{0, -40}{1, -50}{2, -40}{3, -10}";
        List<Record> records = new List<Record>();

        public BusinessDetailsForm()
        {
            InitializeComponent();
        }

        // Property for the store's list of records
        public List<Record> Records { get { return records; } }

        // Adds the given record to the list of records and
        // represents it as a string in the list box.
        public void AddItem(Record record)
        {
            records.Add(record);
            inventoryListBox.Items.Add(String.Format(headersFormat, 
                record.Id, record.Name, record.Price, record.Quantity));
            inventoryCountLabel.Text = 
                $"There are {inventoryListBox.Items.Count - 1} items in this store.";
        }

        // Removes the selected record from the list of records
        // and the list box.
        public void RemoveItem()
        {
            try
            {
                // Ensures that the headers are being deleted.
                if (inventoryListBox.SelectedIndex != 0)
                {
                    records.RemoveAt(inventoryListBox.SelectedIndex - 1);
                    inventoryListBox.Items.RemoveAt(inventoryListBox.SelectedIndex);
                    inventoryCountLabel.Text = 
                        $"There are {inventoryListBox.Items.Count - 1} items in this store.";
                }
                else
                {
                    MessageBox.Show(
                        "This row is immutable.\nPlease make another selection...", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select an item to delete it...", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Initial setup of headers on the form loading.
        private void BusinessDetailsForm_Load(object sender, EventArgs e)
        {
            inventoryListBox.Items.Clear();
            inventoryListBox.Items.Add(String.Format(headersFormat, 
                "ID", "Name", "Price", "Quantity"));
        }
    }
}
