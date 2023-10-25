using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    partial class PurchaseInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.SupplierCmbo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BarCodeTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.AddToCartBtn = new System.Windows.Forms.Button();
            this.TotalAmtTxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductIdDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmtGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteDV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GrossTotLable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuppliererrorLbl = new System.Windows.Forms.Label();
            this.ProductErrorLbl = new System.Windows.Forms.Label();
            this.QtyErrorLable = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.Rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTxt
            // 
            this.SearchTxt.Size = new System.Drawing.Size(153, 23);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.AddToCartBtn);
            this.LeftPanel.Controls.Add(this.Price);
            this.LeftPanel.Controls.Add(this.Qty);
            this.LeftPanel.Controls.Add(this.BarCodeTxt);
            this.LeftPanel.Controls.Add(this.ProductNameTxt);
            this.LeftPanel.Controls.Add(this.TotalAmtTxt);
            this.LeftPanel.Controls.Add(this.label6);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.SupplierCmbo);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.QtyErrorLable);
            this.LeftPanel.Controls.Add(this.ProductErrorLbl);
            this.LeftPanel.Controls.Add(this.SuppliererrorLbl);
            this.LeftPanel.Size = new System.Drawing.Size(250, 736);
            this.LeftPanel.Controls.SetChildIndex(this.SuppliererrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.QtyErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SupplierCmbo, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label6, 0);
            this.LeftPanel.Controls.SetChildIndex(this.TotalAmtTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductNameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarCodeTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Qty, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Price, 0);
            this.LeftPanel.Controls.SetChildIndex(this.AddToCartBtn, 0);
            // 
            // Rightpanel
            // 
            this.Rightpanel.Controls.Add(this.panel4);
            this.Rightpanel.Controls.Add(this.dataGridView1);
            this.Rightpanel.Size = new System.Drawing.Size(970, 736);
            this.Rightpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Rightpanel.Controls.SetChildIndex(this.panel4, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Supplier";
            // 
            // SupplierCmbo
            // 
            this.SupplierCmbo.FormattingEnabled = true;
            this.SupplierCmbo.Location = new System.Drawing.Point(4, 209);
            this.SupplierCmbo.Name = "SupplierCmbo";
            this.SupplierCmbo.Size = new System.Drawing.Size(240, 23);
            this.SupplierCmbo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(6, 291);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(238, 23);
            this.ProductNameTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity";
            // 
            // Qty
            // 
            this.Qty.Location = new System.Drawing.Point(6, 379);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(238, 23);
            this.Qty.TabIndex = 4;
            this.Qty.TextChanged += new System.EventHandler(this.Qty_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product Barcode";
            // 
            // BarCodeTxt
            // 
            this.BarCodeTxt.Location = new System.Drawing.Point(6, 249);
            this.BarCodeTxt.Name = "BarCodeTxt";
            this.BarCodeTxt.Size = new System.Drawing.Size(238, 23);
            this.BarCodeTxt.TabIndex = 1;
            this.BarCodeTxt.TextChanged += new System.EventHandler(this.BarCodeTxt_TextChanged);
            this.BarCodeTxt.Validated += new System.EventHandler(this.BarCodeTxt_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Per Unit Price";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(6, 334);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(238, 23);
            this.Price.TabIndex = 3;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.FlatAppearance.BorderSize = 2;
            this.AddToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToCartBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddToCartBtn.Location = new System.Drawing.Point(6, 414);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(238, 42);
            this.AddToCartBtn.TabIndex = 5;
            this.AddToCartBtn.Text = "Add To Cart";
            this.AddToCartBtn.UseVisualStyleBackColor = true;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // TotalAmtTxt
            // 
            this.TotalAmtTxt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TotalAmtTxt.Location = new System.Drawing.Point(3, 478);
            this.TotalAmtTxt.Name = "TotalAmtTxt";
            this.TotalAmtTxt.Size = new System.Drawing.Size(241, 37);
            this.TotalAmtTxt.TabIndex = 1;
            this.TotalAmtTxt.Text = "0.00";
            this.TotalAmtTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIdDGV,
            this.ProductNameGV,
            this.QuantityGV,
            this.PriceGV,
            this.TotalAmtGV,
            this.DeleteDV});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(970, 525);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ProductIdDGV
            // 
            this.ProductIdDGV.HeaderText = "Product Id";
            this.ProductIdDGV.Name = "ProductIdDGV";
            this.ProductIdDGV.ReadOnly = true;
            this.ProductIdDGV.Visible = false;
            // 
            // ProductNameGV
            // 
            this.ProductNameGV.HeaderText = "Product";
            this.ProductNameGV.Name = "ProductNameGV";
            this.ProductNameGV.ReadOnly = true;
            // 
            // QuantityGV
            // 
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            // 
            // PriceGV
            // 
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.PriceGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.PriceGV.HeaderText = "Price";
            this.PriceGV.Name = "PriceGV";
            this.PriceGV.ReadOnly = true;
            // 
            // TotalAmtGV
            // 
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.TotalAmtGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalAmtGV.HeaderText = "Amount";
            this.TotalAmtGV.Name = "TotalAmtGV";
            this.TotalAmtGV.ReadOnly = true;
            // 
            // DeleteDV
            // 
            this.DeleteDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteDV.HeaderText = "Action";
            this.DeleteDV.Name = "DeleteDV";
            this.DeleteDV.ReadOnly = true;
            this.DeleteDV.Text = "Delete";
            this.DeleteDV.UseColumnTextForButtonValue = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 636);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(970, 100);
            this.panel4.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel2.Controls.Add(this.GrossTotLable, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(970, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // GrossTotLable
            // 
            this.GrossTotLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrossTotLable.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GrossTotLable.Location = new System.Drawing.Point(720, 0);
            this.GrossTotLable.Name = "GrossTotLable";
            this.GrossTotLable.Size = new System.Drawing.Size(247, 100);
            this.GrossTotLable.TabIndex = 1;
            this.GrossTotLable.Text = "0.00";
            this.GrossTotLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(711, 100);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SuppliererrorLbl
            // 
            this.SuppliererrorLbl.AutoSize = true;
            this.SuppliererrorLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SuppliererrorLbl.ForeColor = System.Drawing.Color.Orange;
            this.SuppliererrorLbl.Location = new System.Drawing.Point(227, 184);
            this.SuppliererrorLbl.Name = "SuppliererrorLbl";
            this.SuppliererrorLbl.Size = new System.Drawing.Size(20, 25);
            this.SuppliererrorLbl.TabIndex = 6;
            this.SuppliererrorLbl.Text = "*";
            this.SuppliererrorLbl.Visible = false;
            // 
            // ProductErrorLbl
            // 
            this.ProductErrorLbl.AutoSize = true;
            this.ProductErrorLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ProductErrorLbl.ForeColor = System.Drawing.Color.Orange;
            this.ProductErrorLbl.Location = new System.Drawing.Point(224, 231);
            this.ProductErrorLbl.Name = "ProductErrorLbl";
            this.ProductErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.ProductErrorLbl.TabIndex = 6;
            this.ProductErrorLbl.Text = "*";
            this.ProductErrorLbl.Visible = false;
            // 
            // QtyErrorLable
            // 
            this.QtyErrorLable.AutoSize = true;
            this.QtyErrorLable.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.QtyErrorLable.ForeColor = System.Drawing.Color.Orange;
            this.QtyErrorLable.Location = new System.Drawing.Point(224, 312);
            this.QtyErrorLable.Name = "QtyErrorLable";
            this.QtyErrorLable.Size = new System.Drawing.Size(20, 25);
            this.QtyErrorLable.TabIndex = 6;
            this.QtyErrorLable.Text = "*";
            this.QtyErrorLable.Visible = false;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 736);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.Rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SupplierCmbo;
        private System.Windows.Forms.Button AddToCartBtn;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.TextBox BarCodeTxt;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private decimal AmtLable;
        private Label TotalAmtTxt;
        private Panel panel4;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label GrossTotLable;
        private Label label7;
        private Label QtyErrorLable;
        private Label ProductErrorLbl;
        private Label SuppliererrorLbl;
        private DataGridViewTextBoxColumn ProductIdDGV;
        private DataGridViewTextBoxColumn ProductNameGV;
        private DataGridViewTextBoxColumn QuantityGV;
        private DataGridViewTextBoxColumn PriceGV;
        private DataGridViewTextBoxColumn TotalAmtGV;
        private DataGridViewButtonColumn DeleteDV;
    }
}