namespace InventoryManagmentSystem
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SalesOpnBtn = new System.Windows.Forms.Button();
            this.BtnPurchase = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.CategoryOpnBtn = new System.Windows.Forms.Button();
            this.SupplierOpnBtn = new System.Windows.Forms.Button();
            this.ProductPricingBtn = new System.Windows.Forms.Button();
            this.SaleReportRptBtn = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.Rightpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LeftPanel.Size = new System.Drawing.Size(250, 795);
            // 
            // Rightpanel
            // 
            this.Rightpanel.Controls.Add(this.tableLayoutPanel1);
            this.Rightpanel.Size = new System.Drawing.Size(1165, 795);
            this.Rightpanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.SalesOpnBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnPurchase, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStocks, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProducts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddUsers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CategoryOpnBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SupplierOpnBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProductPricingBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaleReportRptBtn, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 742);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SalesOpnBtn
            // 
            this.SalesOpnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesOpnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesOpnBtn.FlatAppearance.BorderSize = 2;
            this.SalesOpnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesOpnBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SalesOpnBtn.Location = new System.Drawing.Point(935, 3);
            this.SalesOpnBtn.Name = "SalesOpnBtn";
            this.SalesOpnBtn.Size = new System.Drawing.Size(227, 142);
            this.SalesOpnBtn.TabIndex = 4;
            this.SalesOpnBtn.Text = "Sales";
            this.SalesOpnBtn.UseVisualStyleBackColor = true;
            this.SalesOpnBtn.Click += new System.EventHandler(this.SalesOpnBtn_Click);
            // 
            // BtnPurchase
            // 
            this.BtnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPurchase.FlatAppearance.BorderSize = 2;
            this.BtnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPurchase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnPurchase.Location = new System.Drawing.Point(702, 3);
            this.BtnPurchase.Name = "BtnPurchase";
            this.BtnPurchase.Size = new System.Drawing.Size(227, 142);
            this.BtnPurchase.TabIndex = 3;
            this.BtnPurchase.Text = "Purchase Invoice";
            this.BtnPurchase.UseVisualStyleBackColor = true;
            this.BtnPurchase.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStocks.FlatAppearance.BorderSize = 2;
            this.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStocks.Location = new System.Drawing.Point(469, 3);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(227, 142);
            this.btnStocks.TabIndex = 2;
            this.btnStocks.Text = "Stock";
            this.btnStocks.UseVisualStyleBackColor = true;
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.FlatAppearance.BorderSize = 2;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnProducts.Location = new System.Drawing.Point(236, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(227, 142);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddUsers.FlatAppearance.BorderSize = 2;
            this.btnAddUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddUsers.Location = new System.Drawing.Point(3, 3);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(227, 142);
            this.btnAddUsers.TabIndex = 0;
            this.btnAddUsers.Text = "Users";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // CategoryOpnBtn
            // 
            this.CategoryOpnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryOpnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryOpnBtn.FlatAppearance.BorderSize = 2;
            this.CategoryOpnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryOpnBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CategoryOpnBtn.Location = new System.Drawing.Point(3, 151);
            this.CategoryOpnBtn.Name = "CategoryOpnBtn";
            this.CategoryOpnBtn.Size = new System.Drawing.Size(227, 142);
            this.CategoryOpnBtn.TabIndex = 6;
            this.CategoryOpnBtn.Text = "Category";
            this.CategoryOpnBtn.UseVisualStyleBackColor = true;
            this.CategoryOpnBtn.Click += new System.EventHandler(this.CategoryOpnBtn_Click);
            // 
            // SupplierOpnBtn
            // 
            this.SupplierOpnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupplierOpnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupplierOpnBtn.FlatAppearance.BorderSize = 2;
            this.SupplierOpnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupplierOpnBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SupplierOpnBtn.Location = new System.Drawing.Point(236, 151);
            this.SupplierOpnBtn.Name = "SupplierOpnBtn";
            this.SupplierOpnBtn.Size = new System.Drawing.Size(227, 142);
            this.SupplierOpnBtn.TabIndex = 7;
            this.SupplierOpnBtn.Text = "Suppliers";
            this.SupplierOpnBtn.UseVisualStyleBackColor = true;
            this.SupplierOpnBtn.Click += new System.EventHandler(this.SupplierOpnBtn_Click);
            // 
            // ProductPricingBtn
            // 
            this.ProductPricingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductPricingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPricingBtn.FlatAppearance.BorderSize = 2;
            this.ProductPricingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductPricingBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ProductPricingBtn.Location = new System.Drawing.Point(469, 151);
            this.ProductPricingBtn.Name = "ProductPricingBtn";
            this.ProductPricingBtn.Size = new System.Drawing.Size(227, 142);
            this.ProductPricingBtn.TabIndex = 8;
            this.ProductPricingBtn.Text = "Product Pricing";
            this.ProductPricingBtn.UseVisualStyleBackColor = true;
            this.ProductPricingBtn.Click += new System.EventHandler(this.ProductPricingBtn_Click);
            // 
            // SaleReportRptBtn
            // 
            this.SaleReportRptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaleReportRptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleReportRptBtn.FlatAppearance.BorderSize = 2;
            this.SaleReportRptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleReportRptBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SaleReportRptBtn.Location = new System.Drawing.Point(702, 151);
            this.SaleReportRptBtn.Name = "SaleReportRptBtn";
            this.SaleReportRptBtn.Size = new System.Drawing.Size(227, 142);
            this.SaleReportRptBtn.TabIndex = 9;
            this.SaleReportRptBtn.Text = "Sale Report";
            this.SaleReportRptBtn.UseVisualStyleBackColor = true;
            this.SaleReportRptBtn.Click += new System.EventHandler(this.SaleReportRptBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 795);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "HomeScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.LeftPanel.ResumeLayout(false);
            this.Rightpanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button SalesOpnBtn;
        private System.Windows.Forms.Button BtnPurchase;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button CategoryOpnBtn;
        private System.Windows.Forms.Button SupplierOpnBtn;
        private System.Windows.Forms.Button ProductPricingBtn;
        private System.Windows.Forms.Button SaleReportRptBtn;
    }
}