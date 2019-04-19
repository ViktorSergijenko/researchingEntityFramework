namespace WindowsFormsApp1
{
    partial class AcessuaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcessuaryForm));
            this.getDataButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.acessuaryDataGrid = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.addEditButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.acessuaryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(12, 12);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(75, 23);
            this.getDataButton.TabIndex = 4;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 41);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(544, 20);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // acessuaryDataGrid
            // 
            this.acessuaryDataGrid.AllowUserToAddRows = false;
            this.acessuaryDataGrid.AllowUserToDeleteRows = false;
            this.acessuaryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acessuaryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.acessuaryDataGrid.Location = new System.Drawing.Point(12, 67);
            this.acessuaryDataGrid.Name = "acessuaryDataGrid";
            this.acessuaryDataGrid.ReadOnly = true;
            this.acessuaryDataGrid.Size = new System.Drawing.Size(544, 279);
            this.acessuaryDataGrid.TabIndex = 6;
            this.acessuaryDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.acessuaryDataGrid_CellContentClick);
            this.acessuaryDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.acessuaryDataGrid_CellDoubleClick);
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
            this.IdBox.Location = new System.Drawing.Point(772, 12);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(141, 20);
            this.IdBox.TabIndex = 12;
            this.IdBox.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(772, 41);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(141, 20);
            this.nameBox.TabIndex = 13;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(772, 67);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(141, 20);
            this.priceBox.TabIndex = 15;
            // 
            // addEditButton
            // 
            this.addEditButton.Location = new System.Drawing.Point(772, 104);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(141, 23);
            this.addEditButton.TabIndex = 17;
            this.addEditButton.Text = "Add/Edit";
            this.addEditButton.UseVisualStyleBackColor = true;
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Price";
            // 
            // AcessuaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addEditButton);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.acessuaryDataGrid);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.getDataButton);
            this.Name = "AcessuaryForm";
            this.Text = "AcessuaryForm";
            ((System.ComponentModel.ISupportInitialize)(this.acessuaryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView acessuaryDataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}