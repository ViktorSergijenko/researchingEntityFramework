namespace WindowsFormsApp1
{
    partial class AmmoShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmmoShopForm));
            this.ammoShopDataGrid = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.ammoNameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.workTimeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addAmmoShop = new System.Windows.Forms.Button();
            this.ammoId = new System.Windows.Forms.TextBox();
            this.getDataButton = new System.Windows.Forms.Button();
            this.shopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammoShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ammoShopDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoShopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ammoShopDataGrid
            // 
            this.ammoShopDataGrid.AllowUserToAddRows = false;
            this.ammoShopDataGrid.AllowUserToDeleteRows = false;
            this.ammoShopDataGrid.AutoGenerateColumns = false;
            this.ammoShopDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ammoShopDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shopNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.workTimeDataGridViewTextBoxColumn,
            this.Delete});
            this.ammoShopDataGrid.DataSource = this.ammoShopBindingSource;
            this.ammoShopDataGrid.Location = new System.Drawing.Point(40, 65);
            this.ammoShopDataGrid.Name = "ammoShopDataGrid";
            this.ammoShopDataGrid.ReadOnly = true;
            this.ammoShopDataGrid.Size = new System.Drawing.Size(519, 254);
            this.ammoShopDataGrid.TabIndex = 0;
            this.ammoShopDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ammoShopDataGrid_CellContentClick);
            this.ammoShopDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ammoShopDataGrid_CellDoubleClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Action";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(40, 39);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(519, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // ammoNameBox
            // 
            this.ammoNameBox.Location = new System.Drawing.Point(882, 39);
            this.ammoNameBox.Name = "ammoNameBox";
            this.ammoNameBox.Size = new System.Drawing.Size(141, 20);
            this.ammoNameBox.TabIndex = 3;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(882, 84);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(141, 20);
            this.addressBox.TabIndex = 4;
            // 
            // workTimeBox
            // 
            this.workTimeBox.Location = new System.Drawing.Point(882, 134);
            this.workTimeBox.Name = "workTimeBox";
            this.workTimeBox.Size = new System.Drawing.Size(141, 20);
            this.workTimeBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(807, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(807, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Work time";
            // 
            // addAmmoShop
            // 
            this.addAmmoShop.Location = new System.Drawing.Point(882, 186);
            this.addAmmoShop.Name = "addAmmoShop";
            this.addAmmoShop.Size = new System.Drawing.Size(141, 23);
            this.addAmmoShop.TabIndex = 9;
            this.addAmmoShop.Text = "Add ammo shop";
            this.addAmmoShop.UseVisualStyleBackColor = true;
            this.addAmmoShop.Click += new System.EventHandler(this.addAmmoShop_Click);
            // 
            // ammoId
            // 
            this.ammoId.Location = new System.Drawing.Point(882, 2);
            this.ammoId.Name = "ammoId";
            this.ammoId.Size = new System.Drawing.Size(141, 20);
            this.ammoId.TabIndex = 10;
            this.ammoId.Visible = false;
            this.ammoId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(40, 13);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(75, 23);
            this.getDataButton.TabIndex = 2;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // shopNameDataGridViewTextBoxColumn
            // 
            this.shopNameDataGridViewTextBoxColumn.DataPropertyName = "ShopName";
            this.shopNameDataGridViewTextBoxColumn.HeaderText = "ShopName";
            this.shopNameDataGridViewTextBoxColumn.Name = "shopNameDataGridViewTextBoxColumn";
            this.shopNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workTimeDataGridViewTextBoxColumn
            // 
            this.workTimeDataGridViewTextBoxColumn.DataPropertyName = "WorkTime";
            this.workTimeDataGridViewTextBoxColumn.HeaderText = "WorkTime";
            this.workTimeDataGridViewTextBoxColumn.Name = "workTimeDataGridViewTextBoxColumn";
            this.workTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ammoShopBindingSource
            // 
            this.ammoShopBindingSource.DataSource = typeof(WindowsFormsApp1.Models.AmmoShop);
            // 
            // AmmoShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 566);
            this.Controls.Add(this.ammoId);
            this.Controls.Add(this.addAmmoShop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workTimeBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.ammoNameBox);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.ammoShopDataGrid);
            this.Name = "AmmoShopForm";
            this.Text = "AmmoShop";
            ((System.ComponentModel.ISupportInitialize)(this.ammoShopDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoShopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ammoShopDataGrid;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox ammoNameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox workTimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addAmmoShop;
        private System.Windows.Forms.TextBox ammoId;
        private System.Windows.Forms.BindingSource ammoShopBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button getDataButton;
    }
}