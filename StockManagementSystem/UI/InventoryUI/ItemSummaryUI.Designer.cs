namespace StockManagementSystem.UI.InventoryUI
{
    partial class ItemSummaryUI
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
            this.itemSummaryDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.itemSummaryDataGridView)).BeginInit();
            this.indexMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemSummaryDataGridView
            // 
            this.itemSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemSummaryDataGridView.Location = new System.Drawing.Point(21, 144);
            this.itemSummaryDataGridView.Name = "itemSummaryDataGridView";
            this.itemSummaryDataGridView.Size = new System.Drawing.Size(645, 276);
            this.itemSummaryDataGridView.TabIndex = 34;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(308, 107);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 33;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(268, 73);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(211, 21);
            this.companyComboBox.TabIndex = 38;
            this.companyComboBox.Click += new System.EventHandler(this.companyComboBox_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(268, 42);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(211, 21);
            this.categoryComboBox.TabIndex = 37;
            this.categoryComboBox.Click += new System.EventHandler(this.categoryComboBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Category";
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
            this.indexMenuStrip.Size = new System.Drawing.Size(687, 24);
            this.indexMenuStrip.TabIndex = 39;
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
            // ItemSummaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 442);
            this.Controls.Add(this.indexMenuStrip);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemSummaryDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Name = "ItemSummaryUI";
            this.Text = "Item Summary View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemSummaryUI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.itemSummaryDataGridView)).EndInit();
            this.indexMenuStrip.ResumeLayout(false);
            this.indexMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView itemSummaryDataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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