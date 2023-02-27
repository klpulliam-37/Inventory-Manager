namespace InventoryProgramClassLibrary
{
    partial class ItemForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.itemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemIDTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemIDLabel = new System.Windows.Forms.Label();
            this.itemDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemDetailsGroupBox
            // 
            this.itemDetailsGroupBox.Controls.Add(this.itemQuantityTextBox);
            this.itemDetailsGroupBox.Controls.Add(this.itemPriceTextBox);
            this.itemDetailsGroupBox.Controls.Add(this.itemNameTextBox);
            this.itemDetailsGroupBox.Controls.Add(this.itemIDTextBox);
            this.itemDetailsGroupBox.Controls.Add(this.quantityLabel);
            this.itemDetailsGroupBox.Controls.Add(this.priceLabel);
            this.itemDetailsGroupBox.Controls.Add(this.itemNameLabel);
            this.itemDetailsGroupBox.Controls.Add(this.itemIDLabel);
            this.itemDetailsGroupBox.Location = new System.Drawing.Point(16, 16);
            this.itemDetailsGroupBox.Name = "itemDetailsGroupBox";
            this.itemDetailsGroupBox.Size = new System.Drawing.Size(315, 122);
            this.itemDetailsGroupBox.TabIndex = 0;
            this.itemDetailsGroupBox.TabStop = false;
            this.itemDetailsGroupBox.Text = "Item Details";
            // 
            // itemQuantityTextBox
            // 
            this.itemQuantityTextBox.Location = new System.Drawing.Point(87, 88);
            this.itemQuantityTextBox.Name = "itemQuantityTextBox";
            this.itemQuantityTextBox.Size = new System.Drawing.Size(206, 20);
            this.itemQuantityTextBox.TabIndex = 7;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(87, 66);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemPriceTextBox.TabIndex = 6;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(87, 44);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(206, 20);
            this.itemNameTextBox.TabIndex = 5;
            // 
            // itemIDTextBox
            // 
            this.itemIDTextBox.Location = new System.Drawing.Point(87, 22);
            this.itemIDTextBox.Name = "itemIDTextBox";
            this.itemIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemIDTextBox.TabIndex = 4;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(17, 91);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(17, 69);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(17, 47);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(58, 13);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "Item Name";
            // 
            // itemIDLabel
            // 
            this.itemIDLabel.AutoSize = true;
            this.itemIDLabel.Location = new System.Drawing.Point(17, 25);
            this.itemIDLabel.Name = "itemIDLabel";
            this.itemIDLabel.Size = new System.Drawing.Size(41, 13);
            this.itemIDLabel.TabIndex = 0;
            this.itemIDLabel.Text = "Item ID";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemDetailsGroupBox);
            this.Name = "ItemForm";
            this.Size = new System.Drawing.Size(363, 149);
            this.itemDetailsGroupBox.ResumeLayout(false);
            this.itemDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox itemDetailsGroupBox;
        private System.Windows.Forms.TextBox itemQuantityTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemIDTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label itemIDLabel;
    }
}
