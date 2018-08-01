namespace StockManagementSystem.UI.InventoryUI
{
    partial class StockInUI
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
            this.components = new System.ComponentModel.Container();
            this.itemNameComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stockInTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.availableQuantityLabel = new System.Windows.Forms.Label();
            this.reOrderLevelLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.indexMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.indexMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemNameComboBox
            // 
            this.itemNameComboBox.FormattingEnabled = true;
            this.itemNameComboBox.Location = new System.Drawing.Point(270, 170);
            this.itemNameComboBox.Name = "itemNameComboBox";
            this.itemNameComboBox.Size = new System.Drawing.Size(211, 21);
            this.itemNameComboBox.TabIndex = 31;
            this.itemNameComboBox.SelectedIndexChanged += new System.EventHandler(this.itemNameComboBox_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(406, 296);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 28;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(270, 137);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(211, 21);
            this.companyComboBox.TabIndex = 27;
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(270, 106);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(211, 21);
            this.categoryComboBox.TabIndex = 26;
            this.categoryComboBox.Text = "Select Categories";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Category";
            // 
            // stockInTextBox
            // 
            this.stockInTextBox.Location = new System.Drawing.Point(270, 265);
            this.stockInTextBox.Name = "stockInTextBox";
            this.stockInTextBox.Size = new System.Drawing.Size(211, 20);
            this.stockInTextBox.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Stock- In Quantity";
            // 
            // availableQuantityLabel
            // 
            this.availableQuantityLabel.AutoSize = true;
            this.availableQuantityLabel.Location = new System.Drawing.Point(270, 237);
            this.availableQuantityLabel.Name = "availableQuantityLabel";
            this.availableQuantityLabel.Size = new System.Drawing.Size(0, 13);
            this.availableQuantityLabel.TabIndex = 55;
            // 
            // reOrderLevelLabel
            // 
            this.reOrderLevelLabel.AutoSize = true;
            this.reOrderLevelLabel.Location = new System.Drawing.Point(271, 205);
            this.reOrderLevelLabel.Name = "reOrderLevelLabel";
            this.reOrderLevelLabel.Size = new System.Drawing.Size(0, 13);
            this.reOrderLevelLabel.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Re-Order Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Available Quantity";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // indexMenuStrip
            // 
            this.indexMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.addCompanyToolStripMenuItem,
            this.addCategoryToolStripMenuItem,
            this.addItemToolStripMenuItem,
            this.stockInToolStripMenuItem,
            this.stockOutToolStripMenuItem,
            this.itemSummaryToolStripMenuItem,
            this.salesSummaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.indexMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.indexMenuStrip.Name = "indexMenuStrip";
            this.indexMenuStrip.Size = new System.Drawing.Size(690, 24);
            this.indexMenuStrip.TabIndex = 58;
            // 
            // addCompanyToolStripMenuItem
            // 
            this.addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            this.addCompanyToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.addCompanyToolStripMenuItem.Text = "Add Company";
            this.addCompanyToolStripMenuItem.Click += new System.EventHandler(this.addCompanyToolStripMenuItem_Click);
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.addCategoryToolStripMenuItem.Text = "Add Category";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.stockInToolStripMenuItem.Text = "Stock In";
            this.stockInToolStripMenuItem.Click += new System.EventHandler(this.stockInToolStripMenuItem_Click);
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.stockOutToolStripMenuItem.Text = "Stock Out";
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
            // 
            // itemSummaryToolStripMenuItem
            // 
            this.itemSummaryToolStripMenuItem.Name = "itemSummaryToolStripMenuItem";
            this.itemSummaryToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.itemSummaryToolStripMenuItem.Text = "Item Summary";
            this.itemSummaryToolStripMenuItem.Click += new System.EventHandler(this.itemSummaryToolStripMenuItem_Click);
            // 
            // salesSummaryToolStripMenuItem
            // 
            this.salesSummaryToolStripMenuItem.Name = "salesSummaryToolStripMenuItem";
            this.salesSummaryToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.salesSummaryToolStripMenuItem.Text = "Sales Summary";
            this.salesSummaryToolStripMenuItem.Click += new System.EventHandler(this.salesSummaryToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // StockInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 456);
            this.Controls.Add(this.indexMenuStrip);
            this.Controls.Add(this.stockInTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.availableQuantityLabel);
            this.Controls.Add(this.reOrderLevelLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemNameComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockInUI";
            this.Text = "Stock In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockInUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.indexMenuStrip.ResumeLayout(false);
            this.indexMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox itemNameComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stockInTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label availableQuantityLabel;
        private System.Windows.Forms.Label reOrderLevelLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip indexMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}