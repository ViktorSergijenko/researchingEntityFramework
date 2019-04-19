namespace WindowsFormsApp1
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ammoShopListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ammoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponTypeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessuaryListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ammoShopListToolStripMenuItem,
            this.weaponListToolStripMenuItem,
            this.ammoListToolStripMenuItem,
            this.employeeListToolStripMenuItem,
            this.purchasesListToolStripMenuItem,
            this.weaponTypeListToolStripMenuItem,
            this.acessuaryListToolStripMenuItem,
            this.customerListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ammoShopListToolStripMenuItem
            // 
            this.ammoShopListToolStripMenuItem.Name = "ammoShopListToolStripMenuItem";
            this.ammoShopListToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.ammoShopListToolStripMenuItem.Text = "Ammo Shop List";
            this.ammoShopListToolStripMenuItem.Click += new System.EventHandler(this.ammoShopListToolStripMenuItem_Click);
            // 
            // weaponListToolStripMenuItem
            // 
            this.weaponListToolStripMenuItem.Name = "weaponListToolStripMenuItem";
            this.weaponListToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.weaponListToolStripMenuItem.Text = "Weapon List";
            this.weaponListToolStripMenuItem.Click += new System.EventHandler(this.weaponListToolStripMenuItem_Click);
            // 
            // ammoListToolStripMenuItem
            // 
            this.ammoListToolStripMenuItem.Name = "ammoListToolStripMenuItem";
            this.ammoListToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.ammoListToolStripMenuItem.Text = "Ammo List";
            this.ammoListToolStripMenuItem.Click += new System.EventHandler(this.ammoListToolStripMenuItem_Click);
            // 
            // employeeListToolStripMenuItem
            // 
            this.employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            this.employeeListToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.employeeListToolStripMenuItem.Text = "Employee List";
            this.employeeListToolStripMenuItem.Click += new System.EventHandler(this.employeeListToolStripMenuItem_Click);
            // 
            // purchasesListToolStripMenuItem
            // 
            this.purchasesListToolStripMenuItem.Name = "purchasesListToolStripMenuItem";
            this.purchasesListToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.purchasesListToolStripMenuItem.Text = "Purchases List";
            this.purchasesListToolStripMenuItem.Click += new System.EventHandler(this.purchasesListToolStripMenuItem_Click);
            // 
            // weaponTypeListToolStripMenuItem
            // 
            this.weaponTypeListToolStripMenuItem.Name = "weaponTypeListToolStripMenuItem";
            this.weaponTypeListToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.weaponTypeListToolStripMenuItem.Text = "Weapon type list";
            this.weaponTypeListToolStripMenuItem.Click += new System.EventHandler(this.weaponTypeListToolStripMenuItem_Click);
            // 
            // acessuaryListToolStripMenuItem
            // 
            this.acessuaryListToolStripMenuItem.Name = "acessuaryListToolStripMenuItem";
            this.acessuaryListToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.acessuaryListToolStripMenuItem.Text = "Acessuary List";
            this.acessuaryListToolStripMenuItem.Click += new System.EventHandler(this.acessuaryListToolStripMenuItem_Click);
            // 
            // customerListToolStripMenuItem
            // 
            this.customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            this.customerListToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.customerListToolStripMenuItem.Text = "Customer List";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 614);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ammoShopListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weaponListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ammoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weaponTypeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessuaryListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerListToolStripMenuItem;
    }
}

