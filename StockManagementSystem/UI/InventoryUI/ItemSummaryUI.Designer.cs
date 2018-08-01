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
            ((System.ComponentModel.ISupportInitialize)(this.itemSummaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemSummaryDataGridView
            // 
            this.itemSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemSummaryDataGridView.Location = new System.Drawing.Point(90, 136);
            this.itemSummaryDataGridView.Name = "itemSummaryDataGridView";
            this.itemSummaryDataGridView.Size = new System.Drawing.Size(645, 276);
            this.itemSummaryDataGridView.TabIndex = 34;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(360, 77);
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
            this.companyComboBox.Location = new System.Drawing.Point(320, 43);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(211, 21);
            this.companyComboBox.TabIndex = 38;
            this.companyComboBox.Click += new System.EventHandler(this.companyComboBox_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(320, 12);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(211, 21);
            this.categoryComboBox.TabIndex = 37;
            this.categoryComboBox.Click += new System.EventHandler(this.categoryComboBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Category";
            // 
            // ItemSummaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemSummaryDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Name = "ItemSummaryUI";
            this.Text = "Item Summary View";
            ((System.ComponentModel.ISupportInitialize)(this.itemSummaryDataGridView)).EndInit();
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
    }
}