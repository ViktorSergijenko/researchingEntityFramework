namespace WindowsFormsApp1.AppForms
{
    partial class PurchasesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesForm));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.amountOfWeaponsTextBox = new System.Windows.Forms.TextBox();
            this.weaponComboBox = new System.Windows.Forms.ComboBox();
            this.ammoComboBox = new System.Windows.Forms.ComboBox();
            this.amountOfAmmoTextBox = new System.Windows.Forms.TextBox();
            this.weaponShopComboBox = new System.Windows.Forms.ComboBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.acessuaryComboBox = new System.Windows.Forms.ComboBox();
            this.amountOfAcessuaryTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.purchasesDataGrid = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(801, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 1;
            // 
            // amountOfWeaponsTextBox
            // 
            this.amountOfWeaponsTextBox.Location = new System.Drawing.Point(539, 37);
            this.amountOfWeaponsTextBox.Name = "amountOfWeaponsTextBox";
            this.amountOfWeaponsTextBox.Size = new System.Drawing.Size(76, 20);
            this.amountOfWeaponsTextBox.TabIndex = 2;
            // 
            // weaponComboBox
            // 
            this.weaponComboBox.FormattingEnabled = true;
            this.weaponComboBox.Location = new System.Drawing.Point(621, 37);
            this.weaponComboBox.Name = "weaponComboBox";
            this.weaponComboBox.Size = new System.Drawing.Size(121, 21);
            this.weaponComboBox.TabIndex = 3;
            // 
            // ammoComboBox
            // 
            this.ammoComboBox.FormattingEnabled = true;
            this.ammoComboBox.Location = new System.Drawing.Point(621, 64);
            this.ammoComboBox.Name = "ammoComboBox";
            this.ammoComboBox.Size = new System.Drawing.Size(121, 21);
            this.ammoComboBox.TabIndex = 4;
            // 
            // amountOfAmmoTextBox
            // 
            this.amountOfAmmoTextBox.Location = new System.Drawing.Point(539, 63);
            this.amountOfAmmoTextBox.Name = "amountOfAmmoTextBox";
            this.amountOfAmmoTextBox.Size = new System.Drawing.Size(76, 20);
            this.amountOfAmmoTextBox.TabIndex = 5;
            // 
            // weaponShopComboBox
            // 
            this.weaponShopComboBox.FormattingEnabled = true;
            this.weaponShopComboBox.Location = new System.Drawing.Point(801, 12);
            this.weaponShopComboBox.Name = "weaponShopComboBox";
            this.weaponShopComboBox.Size = new System.Drawing.Size(192, 21);
            this.weaponShopComboBox.TabIndex = 6;
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(801, 50);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(192, 21);
            this.customerComboBox.TabIndex = 7;
            // 
            // acessuaryComboBox
            // 
            this.acessuaryComboBox.FormattingEnabled = true;
            this.acessuaryComboBox.Location = new System.Drawing.Point(621, 91);
            this.acessuaryComboBox.Name = "acessuaryComboBox";
            this.acessuaryComboBox.Size = new System.Drawing.Size(121, 21);
            this.acessuaryComboBox.TabIndex = 8;
            // 
            // amountOfAcessuaryTextBox
            // 
            this.amountOfAcessuaryTextBox.Location = new System.Drawing.Point(539, 91);
            this.amountOfAcessuaryTextBox.Name = "amountOfAcessuaryTextBox";
            this.amountOfAcessuaryTextBox.Size = new System.Drawing.Size(76, 20);
            this.amountOfAcessuaryTextBox.TabIndex = 9;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(539, 129);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(76, 20);
            this.totalPriceTextBox.TabIndex = 10;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(801, 124);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(192, 21);
            this.employeeComboBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(621, 129);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add purchase";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount of weapons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Amount of ammo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Amount of acessuary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total price";
            // 
            // purchasesDataGrid
            // 
            this.purchasesDataGrid.AllowUserToAddRows = false;
            this.purchasesDataGrid.AllowUserToDeleteRows = false;
            this.purchasesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.purchasesDataGrid.Location = new System.Drawing.Point(12, 12);
            this.purchasesDataGrid.Name = "purchasesDataGrid";
            this.purchasesDataGrid.ReadOnly = true;
            this.purchasesDataGrid.Size = new System.Drawing.Size(408, 244);
            this.purchasesDataGrid.TabIndex = 17;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 549);
            this.Controls.Add(this.purchasesDataGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.amountOfAcessuaryTextBox);
            this.Controls.Add(this.acessuaryComboBox);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.weaponShopComboBox);
            this.Controls.Add(this.amountOfAmmoTextBox);
            this.Controls.Add(this.ammoComboBox);
            this.Controls.Add(this.weaponComboBox);
            this.Controls.Add(this.amountOfWeaponsTextBox);
            this.Controls.Add(this.textBox2);
            this.Name = "PurchasesForm";
            this.Text = "PurchasesForm";
            this.Load += new System.EventHandler(this.PurchasesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox amountOfWeaponsTextBox;
        private System.Windows.Forms.ComboBox weaponComboBox;
        private System.Windows.Forms.ComboBox ammoComboBox;
        private System.Windows.Forms.TextBox amountOfAmmoTextBox;
        private System.Windows.Forms.ComboBox weaponShopComboBox;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox acessuaryComboBox;
        private System.Windows.Forms.TextBox amountOfAcessuaryTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView purchasesDataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}