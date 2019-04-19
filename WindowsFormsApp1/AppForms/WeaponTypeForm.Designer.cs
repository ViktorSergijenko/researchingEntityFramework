namespace WindowsFormsApp1
{
    partial class WeaponTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponTypeForm));
            this.weaponTypeDataGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.weaponTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getDataButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.weaponTypeNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addEditWeaponTypeButton = new System.Windows.Forms.Button();
            this.weaponTypeIdBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.weaponTypeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // weaponTypeDataGrid
            // 
            this.weaponTypeDataGrid.AllowUserToAddRows = false;
            this.weaponTypeDataGrid.AllowUserToDeleteRows = false;
            this.weaponTypeDataGrid.AutoGenerateColumns = false;
            this.weaponTypeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weaponTypeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Delete});
            this.weaponTypeDataGrid.DataSource = this.weaponTypeBindingSource;
            this.weaponTypeDataGrid.Location = new System.Drawing.Point(12, 102);
            this.weaponTypeDataGrid.Name = "weaponTypeDataGrid";
            this.weaponTypeDataGrid.ReadOnly = true;
            this.weaponTypeDataGrid.Size = new System.Drawing.Size(244, 198);
            this.weaponTypeDataGrid.TabIndex = 0;
            this.weaponTypeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.weaponTypeDataGrid_CellContentClick);
            this.weaponTypeDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.weaponTypeDataGrid_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Name";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // weaponTypeBindingSource
            // 
            this.weaponTypeBindingSource.DataSource = typeof(WindowsFormsApp1.Models.WeaponType);
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(12, 45);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(75, 23);
            this.getDataButton.TabIndex = 3;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 74);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(244, 20);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // weaponTypeNameBox
            // 
            this.weaponTypeNameBox.Location = new System.Drawing.Point(727, 84);
            this.weaponTypeNameBox.Name = "weaponTypeNameBox";
            this.weaponTypeNameBox.Size = new System.Drawing.Size(141, 20);
            this.weaponTypeNameBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // addEditWeaponTypeButton
            // 
            this.addEditWeaponTypeButton.Location = new System.Drawing.Point(727, 119);
            this.addEditWeaponTypeButton.Name = "addEditWeaponTypeButton";
            this.addEditWeaponTypeButton.Size = new System.Drawing.Size(141, 23);
            this.addEditWeaponTypeButton.TabIndex = 10;
            this.addEditWeaponTypeButton.Text = "Edit/Add weapon type";
            this.addEditWeaponTypeButton.UseVisualStyleBackColor = true;
            this.addEditWeaponTypeButton.Click += new System.EventHandler(this.addEditWeaponTypeButton_Click);
            // 
            // weaponTypeIdBox
            // 
            this.weaponTypeIdBox.Location = new System.Drawing.Point(727, 26);
            this.weaponTypeIdBox.Name = "weaponTypeIdBox";
            this.weaponTypeIdBox.Size = new System.Drawing.Size(141, 20);
            this.weaponTypeIdBox.TabIndex = 11;
            this.weaponTypeIdBox.Visible = false;
            // 
            // WeaponTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 446);
            this.Controls.Add(this.weaponTypeIdBox);
            this.Controls.Add(this.addEditWeaponTypeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weaponTypeNameBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.weaponTypeDataGrid);
            this.Name = "WeaponTypeForm";
            this.Text = "WeaponTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.weaponTypeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView weaponTypeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource weaponTypeBindingSource;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox weaponTypeNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEditWeaponTypeButton;
        private System.Windows.Forms.TextBox weaponTypeIdBox;
    }
}