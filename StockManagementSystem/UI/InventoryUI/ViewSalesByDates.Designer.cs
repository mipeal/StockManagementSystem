namespace StockManagementSystem.UI.InventoryUI
{
    partial class ViewSalesByDates
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
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.saleSummaryGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.saleSummaryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toDatePicker
            // 
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDatePicker.Location = new System.Drawing.Point(419, 39);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(183, 20);
            this.toDatePicker.TabIndex = 36;
            this.toDatePicker.Value = new System.DateTime(2018, 7, 28, 0, 0, 0, 0);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "";
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDatePicker.Location = new System.Drawing.Point(189, 39);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(183, 20);
            this.fromDatePicker.TabIndex = 35;
            this.fromDatePicker.Value = new System.DateTime(2018, 7, 28, 0, 0, 0, 0);
            // 
            // saleSummaryGridView
            // 
            this.saleSummaryGridView.AllowUserToAddRows = false;
            this.saleSummaryGridView.AllowUserToDeleteRows = false;
            this.saleSummaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleSummaryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNo,
            this.itemName,
            this.saleQuantity});
            this.saleSummaryGridView.Location = new System.Drawing.Point(105, 136);
            this.saleSummaryGridView.MultiSelect = false;
            this.saleSummaryGridView.Name = "saleSummaryGridView";
            this.saleSummaryGridView.ReadOnly = true;
            this.saleSummaryGridView.Size = new System.Drawing.Size(590, 276);
            this.saleSummaryGridView.TabIndex = 34;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "To";
            // 
            // serialNo
            // 
            this.serialNo.HeaderText = "SL";
            this.serialNo.Name = "serialNo";
            this.serialNo.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // saleQuantity
            // 
            this.saleQuantity.HeaderText = "Sale Quantity";
            this.saleQuantity.Name = "saleQuantity";
            this.saleQuantity.ReadOnly = true;
            // 
            // ViewSalesByDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.saleSummaryGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewSalesByDates";
            this.Text = "View Sales Between Two Dates";
            ((System.ComponentModel.ISupportInitialize)(this.saleSummaryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DataGridView saleSummaryGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleQuantity;
    }
}