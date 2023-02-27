namespace InventoryProgram
{
    partial class BusinessDetailsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.inventoryDescriptionLabel = new System.Windows.Forms.Label();
            this.inventoryCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.Location = new System.Drawing.Point(12, 115);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(471, 251);
            this.inventoryListBox.TabIndex = 0;
            // 
            // inventoryDescriptionLabel
            // 
            this.inventoryDescriptionLabel.AutoSize = true;
            this.inventoryDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryDescriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.inventoryDescriptionLabel.Name = "inventoryDescriptionLabel";
            this.inventoryDescriptionLabel.Size = new System.Drawing.Size(471, 33);
            this.inventoryDescriptionLabel.TabIndex = 1;
            this.inventoryDescriptionLabel.Text = "Below are store and item details.";
            // 
            // inventoryCountLabel
            // 
            this.inventoryCountLabel.AutoSize = true;
            this.inventoryCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryCountLabel.Location = new System.Drawing.Point(12, 68);
            this.inventoryCountLabel.Name = "inventoryCountLabel";
            this.inventoryCountLabel.Size = new System.Drawing.Size(442, 33);
            this.inventoryCountLabel.TabIndex = 2;
            this.inventoryCountLabel.Text = "There are 0 items in this store.";
            // 
            // BusinessDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 381);
            this.Controls.Add(this.inventoryCountLabel);
            this.Controls.Add(this.inventoryDescriptionLabel);
            this.Controls.Add(this.inventoryListBox);
            this.MinimumSize = new System.Drawing.Size(525, 420);
            this.Name = "BusinessDetailsForm";
            this.Text = "BusinessDetailsForm";
            this.Load += new System.EventHandler(this.BusinessDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Label inventoryDescriptionLabel;
        private System.Windows.Forms.Label inventoryCountLabel;
    }
}