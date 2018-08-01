namespace StockManagementSystem.UI.ItemSetup
{
    partial class CategorySetupUI
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
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpdateButton = new System.Windows.Forms.Button();
            this.gridMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AllowUserToDeleteRows = false;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Location = new System.Drawing.Point(56, 101);
            this.categoryDataGridView.MultiSelect = false;
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.ReadOnly = true;
            this.categoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.categoryDataGridView.Size = new System.Drawing.Size(326, 150);
            this.categoryDataGridView.TabIndex = 7;
            this.categoryDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGridView_CellDoubleClick);
            this.categoryDataGridView.MouseHover += new System.EventHandler(this.categoryDataGridView_MouseHover);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(307, 56);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(111, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(271, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(307, 56);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // gridMessage
            // 
            this.gridMessage.AutoSize = true;
            this.gridMessage.ForeColor = System.Drawing.Color.Red;
            this.gridMessage.Location = new System.Drawing.Point(118, 268);
            this.gridMessage.Name = "gridMessage";
            this.gridMessage.Size = new System.Drawing.Size(0, 13);
            this.gridMessage.TabIndex = 9;
            this.gridMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CategorySetupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 300);
            this.Controls.Add(this.gridMessage);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CategorySetupUI";
            this.Text = "Category Setup ";
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label gridMessage;
    }
}