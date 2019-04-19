namespace WindowsFormsApp1
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.getDataButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.employeeDataGrid = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personalCodeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ammoShopComboBox = new System.Windows.Forms.ComboBox();
            this.reportsToComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addEditButton = new System.Windows.Forms.Button();
            this.employeeTreeView = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(23, 12);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(75, 23);
            this.getDataButton.TabIndex = 4;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(23, 41);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(544, 20);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // employeeDataGrid
            // 
            this.employeeDataGrid.AllowUserToAddRows = false;
            this.employeeDataGrid.AllowUserToDeleteRows = false;
            this.employeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.employeeDataGrid.Location = new System.Drawing.Point(23, 109);
            this.employeeDataGrid.Name = "employeeDataGrid";
            this.employeeDataGrid.ReadOnly = true;
            this.employeeDataGrid.Size = new System.Drawing.Size(544, 279);
            this.employeeDataGrid.TabIndex = 6;
            this.employeeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGrid_CellContentClick);
            this.employeeDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGrid_CellDoubleClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(857, 15);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(141, 20);
            this.IdBox.TabIndex = 12;
            this.IdBox.Visible = false;
            // 
            // fullNameBox
            // 
            this.fullNameBox.Location = new System.Drawing.Point(857, 57);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(141, 20);
            this.fullNameBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Full name";
            // 
            // personalCodeBox
            // 
            this.personalCodeBox.Location = new System.Drawing.Point(857, 83);
            this.personalCodeBox.Name = "personalCodeBox";
            this.personalCodeBox.Size = new System.Drawing.Size(141, 20);
            this.personalCodeBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(776, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Personal code";
            // 
            // ammoShopComboBox
            // 
            this.ammoShopComboBox.FormattingEnabled = true;
            this.ammoShopComboBox.Location = new System.Drawing.Point(857, 109);
            this.ammoShopComboBox.Name = "ammoShopComboBox";
            this.ammoShopComboBox.Size = new System.Drawing.Size(141, 21);
            this.ammoShopComboBox.TabIndex = 19;
            // 
            // reportsToComboBox
            // 
            this.reportsToComboBox.FormattingEnabled = true;
            this.reportsToComboBox.Location = new System.Drawing.Point(857, 136);
            this.reportsToComboBox.Name = "reportsToComboBox";
            this.reportsToComboBox.Size = new System.Drawing.Size(141, 21);
            this.reportsToComboBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(776, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ammo shop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(776, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Reports to";
            // 
            // addEditButton
            // 
            this.addEditButton.Location = new System.Drawing.Point(857, 176);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(141, 23);
            this.addEditButton.TabIndex = 23;
            this.addEditButton.Text = "Add/Edit";
            this.addEditButton.UseVisualStyleBackColor = true;
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // employeeTreeView
            // 
            this.employeeTreeView.Location = new System.Drawing.Point(790, 254);
            this.employeeTreeView.Name = "employeeTreeView";
            this.employeeTreeView.Size = new System.Drawing.Size(255, 239);
            this.employeeTreeView.TabIndex = 24;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1235, 630);
            this.Controls.Add(this.employeeTreeView);
            this.Controls.Add(this.addEditButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportsToComboBox);
            this.Controls.Add(this.ammoShopComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.personalCodeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.employeeDataGrid);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.getDataButton);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView employeeDataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personalCodeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ammoShopComboBox;
        private System.Windows.Forms.ComboBox reportsToComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.TreeView employeeTreeView;
    }
}