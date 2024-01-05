namespace LibrarySystemNew
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsAndVendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollClientDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollVemdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollEmployeesDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollItemDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollItemCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeConvertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDistributedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBuyingProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSellingProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finanicalAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsDebitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientsTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsDebitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVendorTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainProcessToolStripMenuItem,
            this.programProcessToolStripMenuItem,
            this.finanicalAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1920, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mainProcessToolStripMenuItem
            // 
            this.mainProcessToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainProcessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsAndVendorsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.itemsDataToolStripMenuItem,
            this.storesToolStripMenuItem});
            this.mainProcessToolStripMenuItem.Name = "mainProcessToolStripMenuItem";
            this.mainProcessToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.mainProcessToolStripMenuItem.Text = "Main Process";
            // 
            // clientsAndVendorsToolStripMenuItem
            // 
            this.clientsAndVendorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollClientDataToolStripMenuItem,
            this.enrollVemdToolStripMenuItem});
            this.clientsAndVendorsToolStripMenuItem.Name = "clientsAndVendorsToolStripMenuItem";
            this.clientsAndVendorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientsAndVendorsToolStripMenuItem.Text = "Clients And Vendors";
            // 
            // enrollClientDataToolStripMenuItem
            // 
            this.enrollClientDataToolStripMenuItem.Name = "enrollClientDataToolStripMenuItem";
            this.enrollClientDataToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.enrollClientDataToolStripMenuItem.Text = "Enroll Client Data";
            this.enrollClientDataToolStripMenuItem.Click += new System.EventHandler(this.enrollClientDataToolStripMenuItem_Click);
            // 
            // enrollVemdToolStripMenuItem
            // 
            this.enrollVemdToolStripMenuItem.Name = "enrollVemdToolStripMenuItem";
            this.enrollVemdToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.enrollVemdToolStripMenuItem.Text = "Enroll Vendor Data";
            this.enrollVemdToolStripMenuItem.Click += new System.EventHandler(this.enrollVemdToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollEmployeesDataToolStripMenuItem,
            this.jobTypeToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // enrollEmployeesDataToolStripMenuItem
            // 
            this.enrollEmployeesDataToolStripMenuItem.Name = "enrollEmployeesDataToolStripMenuItem";
            this.enrollEmployeesDataToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.enrollEmployeesDataToolStripMenuItem.Text = "Enroll Employees Data";
            this.enrollEmployeesDataToolStripMenuItem.Click += new System.EventHandler(this.enrollEmployeesDataToolStripMenuItem_Click);
            // 
            // jobTypeToolStripMenuItem
            // 
            this.jobTypeToolStripMenuItem.Name = "jobTypeToolStripMenuItem";
            this.jobTypeToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.jobTypeToolStripMenuItem.Text = "Job Type";
            this.jobTypeToolStripMenuItem.Click += new System.EventHandler(this.jobTypeToolStripMenuItem_Click);
            // 
            // itemsDataToolStripMenuItem
            // 
            this.itemsDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollItemDetailsToolStripMenuItem,
            this.enrollItemCategoryToolStripMenuItem});
            this.itemsDataToolStripMenuItem.Name = "itemsDataToolStripMenuItem";
            this.itemsDataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.itemsDataToolStripMenuItem.Text = "Items Data";
            // 
            // enrollItemDetailsToolStripMenuItem
            // 
            this.enrollItemDetailsToolStripMenuItem.Name = "enrollItemDetailsToolStripMenuItem";
            this.enrollItemDetailsToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.enrollItemDetailsToolStripMenuItem.Text = "Enroll Item Details";
            this.enrollItemDetailsToolStripMenuItem.Click += new System.EventHandler(this.enrollItemDetailsToolStripMenuItem_Click);
            // 
            // enrollItemCategoryToolStripMenuItem
            // 
            this.enrollItemCategoryToolStripMenuItem.Name = "enrollItemCategoryToolStripMenuItem";
            this.enrollItemCategoryToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.enrollItemCategoryToolStripMenuItem.Text = "Enroll Item Category";
            this.enrollItemCategoryToolStripMenuItem.Click += new System.EventHandler(this.enrollItemCategoryToolStripMenuItem_Click);
            // 
            // storesToolStripMenuItem
            // 
            this.storesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeDetailsToolStripMenuItem,
            this.storeConvertsToolStripMenuItem,
            this.itemDistributedToolStripMenuItem});
            this.storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            this.storesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.storesToolStripMenuItem.Text = "Stores";
            // 
            // storeDetailsToolStripMenuItem
            // 
            this.storeDetailsToolStripMenuItem.Name = "storeDetailsToolStripMenuItem";
            this.storeDetailsToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.storeDetailsToolStripMenuItem.Text = "Store Details";
            this.storeDetailsToolStripMenuItem.Click += new System.EventHandler(this.storeDetailsToolStripMenuItem_Click);
            // 
            // storeConvertsToolStripMenuItem
            // 
            this.storeConvertsToolStripMenuItem.Name = "storeConvertsToolStripMenuItem";
            this.storeConvertsToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.storeConvertsToolStripMenuItem.Text = "Store Converts";
            this.storeConvertsToolStripMenuItem.Click += new System.EventHandler(this.storeConvertsToolStripMenuItem_Click);
            // 
            // itemDistributedToolStripMenuItem
            // 
            this.itemDistributedToolStripMenuItem.Name = "itemDistributedToolStripMenuItem";
            this.itemDistributedToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.itemDistributedToolStripMenuItem.Text = "Item Distributed";
            this.itemDistributedToolStripMenuItem.Click += new System.EventHandler(this.itemDistributedToolStripMenuItem_Click);
            // 
            // programProcessToolStripMenuItem
            // 
            this.programProcessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyingToolStripMenuItem,
            this.sellingToolStripMenuItem});
            this.programProcessToolStripMenuItem.Name = "programProcessToolStripMenuItem";
            this.programProcessToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.programProcessToolStripMenuItem.Text = "Program Process";
            // 
            // buyingToolStripMenuItem
            // 
            this.buyingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeBuyingProcessToolStripMenuItem});
            this.buyingToolStripMenuItem.Name = "buyingToolStripMenuItem";
            this.buyingToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.buyingToolStripMenuItem.Text = "Buying";
            // 
            // makeBuyingProcessToolStripMenuItem
            // 
            this.makeBuyingProcessToolStripMenuItem.Name = "makeBuyingProcessToolStripMenuItem";
            this.makeBuyingProcessToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.makeBuyingProcessToolStripMenuItem.Text = "Make Buying Process";
            this.makeBuyingProcessToolStripMenuItem.Click += new System.EventHandler(this.makeBuyingProcessToolStripMenuItem_Click);
            // 
            // sellingToolStripMenuItem
            // 
            this.sellingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeSellingProcessToolStripMenuItem});
            this.sellingToolStripMenuItem.Name = "sellingToolStripMenuItem";
            this.sellingToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.sellingToolStripMenuItem.Text = "Selling";
            // 
            // makeSellingProcessToolStripMenuItem
            // 
            this.makeSellingProcessToolStripMenuItem.Name = "makeSellingProcessToolStripMenuItem";
            this.makeSellingProcessToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.makeSellingProcessToolStripMenuItem.Text = "Make Selling Process";
            this.makeSellingProcessToolStripMenuItem.Click += new System.EventHandler(this.makeSellingProcessToolStripMenuItem_Click);
            // 
            // finanicalAccountToolStripMenuItem
            // 
            this.finanicalAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.vendorsToolStripMenuItem});
            this.finanicalAccountToolStripMenuItem.Name = "finanicalAccountToolStripMenuItem";
            this.finanicalAccountToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.finanicalAccountToolStripMenuItem.Text = "Finanical Account";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsDebitsToolStripMenuItem,
            this.showClientsTransactionToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // clientsDebitsToolStripMenuItem
            // 
            this.clientsDebitsToolStripMenuItem.Name = "clientsDebitsToolStripMenuItem";
            this.clientsDebitsToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.clientsDebitsToolStripMenuItem.Text = "Client Debits";
            this.clientsDebitsToolStripMenuItem.Click += new System.EventHandler(this.clientsDebitsToolStripMenuItem_Click);
            // 
            // showClientsTransactionToolStripMenuItem
            // 
            this.showClientsTransactionToolStripMenuItem.Name = "showClientsTransactionToolStripMenuItem";
            this.showClientsTransactionToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.showClientsTransactionToolStripMenuItem.Text = "Show Client Transaction";
            this.showClientsTransactionToolStripMenuItem.Click += new System.EventHandler(this.showClientsTransactionToolStripMenuItem_Click);
            // 
            // vendorsToolStripMenuItem
            // 
            this.vendorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorsDebitsToolStripMenuItem,
            this.showVendorTransactionToolStripMenuItem});
            this.vendorsToolStripMenuItem.Name = "vendorsToolStripMenuItem";
            this.vendorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vendorsToolStripMenuItem.Text = "Vendors";
            // 
            // vendorsDebitsToolStripMenuItem
            // 
            this.vendorsDebitsToolStripMenuItem.Name = "vendorsDebitsToolStripMenuItem";
            this.vendorsDebitsToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.vendorsDebitsToolStripMenuItem.Text = "Vendor Debits";
            this.vendorsDebitsToolStripMenuItem.Click += new System.EventHandler(this.vendorsDebitsToolStripMenuItem_Click);
            // 
            // showVendorTransactionToolStripMenuItem
            // 
            this.showVendorTransactionToolStripMenuItem.Name = "showVendorTransactionToolStripMenuItem";
            this.showVendorTransactionToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.showVendorTransactionToolStripMenuItem.Text = "Show Vendor Transaction";
            this.showVendorTransactionToolStripMenuItem.Click += new System.EventHandler(this.showVendorTransactionToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsAndVendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollClientDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollVemdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollEmployeesDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollItemDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollItemCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeConvertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBuyingProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSellingProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finanicalAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsDebitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClientsTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsDebitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVendorTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemDistributedToolStripMenuItem;
    }
}