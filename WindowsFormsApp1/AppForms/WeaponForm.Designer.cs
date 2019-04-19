namespace WindowsFormsApp1
{
    partial class WeaponForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponForm));
            this.getDataButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.weaponDataGrid = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addEditButton = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.weaponTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weaponBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.weaponDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(12, 12);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(75, 23);
            this.getDataButton.TabIndex = 3;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 41);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(321, 20);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // weaponDataGrid
            // 
            this.weaponDataGrid.AllowUserToAddRows = false;
            this.weaponDataGrid.AllowUserToDeleteRows = false;
            this.weaponDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weaponDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.weaponDataGrid.Location = new System.Drawing.Point(12, 67);
            this.weaponDataGrid.Name = "weaponDataGrid";
            this.weaponDataGrid.ReadOnly = true;
            this.weaponDataGrid.Size = new System.Drawing.Size(321, 229);
            this.weaponDataGrid.TabIndex = 5;
            this.weaponDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.weaponDataGrid_CellContentClick);
            this.weaponDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.weaponDataGrid_CellDoubleClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // addEditButton
            // 
            this.addEditButton.Location = new System.Drawing.Point(788, 253);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(141, 23);
            this.addEditButton.TabIndex = 10;
            this.addEditButton.Text = "Add/Edit";
            this.addEditButton.UseVisualStyleBackColor = true;
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(788, 15);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(141, 20);
            this.IdBox.TabIndex = 11;
            this.IdBox.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(788, 67);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(141, 20);
            this.nameBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(788, 119);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(141, 20);
            this.priceBox.TabIndex = 14;
            // 
            // weaponTypeComboBox
            // 
            this.weaponTypeComboBox.FormattingEnabled = true;
            this.weaponTypeComboBox.Location = new System.Drawing.Point(788, 171);
            this.weaponTypeComboBox.Name = "weaponTypeComboBox";
            this.weaponTypeComboBox.Size = new System.Drawing.Size(141, 21);
            this.weaponTypeComboBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Weapon type";
            // 
            // weaponBindingSource
            // 
            this.weaponBindingSource.DataSource = typeof(WindowsFormsApp1.Models.Weapon);
            // 
            // WeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weaponTypeComboBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.addEditButton);
            this.Controls.Add(this.weaponDataGrid);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.getDataButton);
            this.Name = "WeaponForm";
            this.Text = "WeaponForm";
            ((System.ComponentModel.ISupportInitialize)(this.weaponDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView weaponDataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource weaponBindingSource;
        private System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.ComboBox weaponTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}