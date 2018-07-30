namespace StockManagementSystem.UI.InventoryUI
{
    partial class StockOutUI
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
            this.LostButton = new System.Windows.Forms.Button();
            this.DamageButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockOutTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stockInQuantityLabel = new System.Windows.Forms.Label();
            this.itemNameComboBox = new System.Windows.Forms.ComboBox();
            this.availableQuantityLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LostButton
            // 
            this.LostButton.Location = new System.Drawing.Point(476, 517);
            this.LostButton.Name = "LostButton";
            this.LostButton.Size = new System.Drawing.Size(75, 23);
            this.LostButton.TabIndex = 55;
            this.LostButton.Text = "Lost";
            this.LostButton.UseVisualStyleBackColor = true;
            // 
            // DamageButton
            // 
            this.DamageButton.Location = new System.Drawing.Point(395, 517);
            this.DamageButton.Name = "DamageButton";
            this.DamageButton.Size = new System.Drawing.Size(75, 23);
            this.DamageButton.TabIndex = 54;
            this.DamageButton.Text = "Damage";
            this.DamageButton.UseVisualStyleBackColor = true;
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(314, 517);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(75, 23);
            this.SellButton.TabIndex = 53;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(501, 206);
            this.dataGridView1.TabIndex = 52;
            // 
            // stockOutTextBox
            // 
            this.stockOutTextBox.Location = new System.Drawing.Point(248, 193);
            this.stockOutTextBox.Name = "stockOutTextBox";
            this.stockOutTextBox.Size = new System.Drawing.Size(211, 20);
            this.stockOutTextBox.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Stock- Out Quantity";
            // 
            // stockInQuantityLabel
            // 
            this.stockInQuantityLabel.AutoSize = true;
            this.stockInQuantityLabel.Location = new System.Drawing.Point(248, 165);
            this.stockInQuantityLabel.Name = "stockInQuantityLabel";
            this.stockInQuantityLabel.Size = new System.Drawing.Size(0, 13);
            this.stockInQuantityLabel.TabIndex = 49;
            // 
            // itemNameComboBox
            // 
            this.itemNameComboBox.FormattingEnabled = true;
            this.itemNameComboBox.Location = new System.Drawing.Point(248, 99);
            this.itemNameComboBox.Name = "itemNameComboBox";
            this.itemNameComboBox.Size = new System.Drawing.Size(211, 21);
            this.itemNameComboBox.TabIndex = 48;
            // 
            // availableQuantityLabel
            // 
            this.availableQuantityLabel.AutoSize = true;
            this.availableQuantityLabel.Location = new System.Drawing.Point(249, 133);
            this.availableQuantityLabel.Name = "availableQuantityLabel";
            this.availableQuantityLabel.Size = new System.Drawing.Size(0, 13);
            this.availableQuantityLabel.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Re-Order Level";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(384, 228);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 45;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // companyComboBox
            // 
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(248, 66);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(211, 21);
            this.companyComboBox.TabIndex = 44;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(248, 35);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(211, 21);
            this.categoryComboBox.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Available Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Category";
            // 
            // StockOutUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 566);
            this.Controls.Add(this.LostButton);
            this.Controls.Add(this.DamageButton);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stockOutTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stockInQuantityLabel);
            this.Controls.Add(this.itemNameComboBox);
            this.Controls.Add(this.availableQuantityLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockOutUI";
            this.Text = "StockOutUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LostButton;
        private System.Windows.Forms.Button DamageButton;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox stockOutTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label stockInQuantityLabel;
        private System.Windows.Forms.ComboBox itemNameComboBox;
        private System.Windows.Forms.Label availableQuantityLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}