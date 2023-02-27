/* Kolten Pulliam
 * November 29th, 2022
 * Program 8 - Inventory Program
 * This program allows you to manage the 
 * inventory of multiple stores you own.
 * You can create, edit, delete, and save
 * the data within your inventory files.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using InventoryProgramClassLibrary;
using System.Runtime.Serialization;

namespace InventoryProgram
{
    public partial class InventoryProgram : Form
    {
        // Necessary objects for managing file streams and serialization.
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream stream;

        public InventoryProgram()
        {
            InitializeComponent();
        }

        // Enables specific menu strip buttons
        // depending if there are any child forms
        private void EnableToolStripMenuItems()
        {
            saveToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = true;
        }

        // Disables specific menu strip buttons
        // depending if there are no child forms
        private void DisableToolStripMenuItems()
        {
            saveToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
        }

        // Allows the user to insert an item into the store inventory
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDataForm child = new InputDataForm();
            child.SetActiveChild((BusinessDetailsForm)this.ActiveMdiChild);
            child.ShowDialog();
        }

        // Allows the user to open a file from the file explorer
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileSelector = new OpenFileDialog();
            DialogResult result = openFileSelector.ShowDialog();
            string fileName = "";

            if (result == DialogResult.OK)
            {
                // Gets the name of the store based on the 
                // filename in the filepath
                String[] filepath = openFileSelector.FileName.Split('\\');
                fileName = filepath[filepath.Length-1].Split('.')[0];

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        EnableToolStripMenuItems();
                        stream = new FileStream(openFileSelector.FileName, 
                            FileMode.Open, FileAccess.Read);

                        stream.Seek(0, SeekOrigin.Begin);

                        BusinessDetailsForm businessForm = new BusinessDetailsForm();
                        businessForm.Text = $"Store: {fileName}";
                        businessForm.MdiParent = this;
                        businessForm.Show();

                        // Loops through the file to deserialize records 
                        // and place them in our child forms listbox
                        while (true)
                        {
                            Record record = (Record)formatter.Deserialize(stream);
                            if (record == null) return;
                            businessForm.AddItem(record);
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("File does not exits.", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SerializationException)
                    {
                        stream.Close();
                    }
                }
            }
        }

        // Allows the user to save the file where they like
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileSelector = new SaveFileDialog();
            DialogResult result = saveFileSelector.ShowDialog();
            string fileName = "";

            BusinessDetailsForm activeChild = (BusinessDetailsForm)this.ActiveMdiChild;

            
            if (result == DialogResult.OK)
            {
                fileName = saveFileSelector.FileName;
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        stream = new FileStream(fileName, FileMode.OpenOrCreate, 
                            FileAccess.Write);
                        stream.Seek(0, SeekOrigin.Begin);

                        // Loops through the stores list of records to 
                        // properly serialize each one and sends 
                        // that information to the filestream
                        foreach (Record record in activeChild.Records)
                        {
                            formatter.Serialize(stream, record);
                        }

                        stream.Close();

                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("File does not exits.", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void InventoryProgram_Load(object sender, EventArgs e)
        {
            DisableToolStripMenuItems(); // Since no child forms are open initially
        }

        // Allows us to delete the selected item from the business inventory
        // based on the selected index in the list box
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessDetailsForm child = (BusinessDetailsForm)this.ActiveMdiChild;
            child.RemoveItem();
        }

        // Closes the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Creates a blank store that can then be saved once edited.
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessDetailsForm businessForm = new BusinessDetailsForm();
            businessForm.Text = $"Store: New Store";
            businessForm.MdiParent = this;
            businessForm.Show();

            EnableToolStripMenuItems();
        }

        // Explains the application, and its purpose.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This application allows you to manage inventories " +
                "of all your businesses.\nYou can create a new file, " +
                "open an existing file, and edit the open file.\n" +
                "Once you are done editing the file, you can save it" +
                " by clicking the 'Save' button.", 
                "About", 
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }
    }
}
