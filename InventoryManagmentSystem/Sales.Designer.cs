namespace InventoryManagmentSystem
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarCodeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductErrorLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductIdDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmtGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteDV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GrossTotLable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TestLable = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PaymentTypeCmbo = new System.Windows.Forms.ComboBox();
            this.PayBtn = new System.Windows.Forms.Button();
            this.ChqOutBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeTxt = new System.Windows.Forms.TextBox();
            this.GivenAmtTxt = new System.Windows.Forms.TextBox();
            this.TotDisTxt = new System.Windows.Forms.TextBox();
            this.GrossTotalTxt = new System.Windows.Forms.TextBox();
            this.LeftPanel.SuspendLayout();
            this.Rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTxt
            // 
            this.SearchTxt.Size = new System.Drawing.Size(158, 23);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.groupBox2);
            this.LeftPanel.Controls.Add(this.BarCodeTxt);
            this.LeftPanel.Controls.Add(this.TestLable);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.ProductErrorLbl);
            this.LeftPanel.Size = new System.Drawing.Size(250, 745);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.TestLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarCodeTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // Rightpanel
            // 
            this.Rightpanel.Controls.Add(this.panel4);
            this.Rightpanel.Controls.Add(this.dataGridView1);
            this.Rightpanel.Size = new System.Drawing.Size(1015, 745);
            this.Rightpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Rightpanel.Controls.SetChildIndex(this.panel4, 0);
            // 
            // BarCodeTxt
            // 
            this.BarCodeTxt.Location = new System.Drawing.Point(6, 182);
            this.BarCodeTxt.Name = "BarCodeTxt";
            this.BarCodeTxt.Size = new System.Drawing.Size(238, 23);
            this.BarCodeTxt.TabIndex = 7;
            this.BarCodeTxt.TextChanged += new System.EventHandler(this.BarCodeTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product Barcode";
            // 
            // ProductErrorLbl
            // 
            this.ProductErrorLbl.AutoSize = true;
            this.ProductErrorLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ProductErrorLbl.ForeColor = System.Drawing.Color.Orange;
            this.ProductErrorLbl.Location = new System.Drawing.Point(224, 164);
            this.ProductErrorLbl.Name = "ProductErrorLbl";
            this.ProductErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.ProductErrorLbl.TabIndex = 9;
            this.ProductErrorLbl.Text = "*";
            this.ProductErrorLbl.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIdDGV,
            this.ProductNameGV,
            this.QuantityGV,
            this.DiscountGV,
            this.PriceGV,
            this.TotalAmtGV,
            this.DeleteDV});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 537);
            this.dataGridView1.TabIndex = 5;
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
            dataGridViewCellStyle2.Format = "N2";
            this.QuantityGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            // 
            // DiscountGV
            // 
            dataGridViewCellStyle3.Format = "n2";
            this.DiscountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiscountGV.HeaderText = "Discount";
            this.DiscountGV.Name = "DiscountGV";
            this.DiscountGV.ReadOnly = true;
            // 
            // PriceGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.PriceGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.PriceGV.HeaderText = "Price";
            this.PriceGV.Name = "PriceGV";
            this.PriceGV.ReadOnly = true;
            // 
            // TotalAmtGV
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.TotalAmtGV.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.panel4.Location = new System.Drawing.Point(0, 645);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1015, 100);
            this.panel4.TabIndex = 6;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1015, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // GrossTotLable
            // 
            this.GrossTotLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrossTotLable.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GrossTotLable.Location = new System.Drawing.Point(754, 0);
            this.GrossTotLable.Name = "GrossTotLable";
            this.GrossTotLable.Size = new System.Drawing.Size(258, 100);
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
            this.label7.Size = new System.Drawing.Size(745, 100);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TestLable
            // 
            this.TestLable.AutoSize = true;
            this.TestLable.Location = new System.Drawing.Point(12, 120);
            this.TestLable.Name = "TestLable";
            this.TestLable.Size = new System.Drawing.Size(26, 15);
            this.TestLable.TabIndex = 8;
            this.TestLable.Text = "test";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PaymentTypeCmbo);
            this.groupBox2.Controls.Add(this.PayBtn);
            this.groupBox2.Controls.Add(this.ChqOutBtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ChangeTxt);
            this.groupBox2.Controls.Add(this.GivenAmtTxt);
            this.groupBox2.Controls.Add(this.TotDisTxt);
            this.groupBox2.Controls.Add(this.GrossTotalTxt);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 534);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payments";
            // 
            // PaymentTypeCmbo
            // 
            this.PaymentTypeCmbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentTypeCmbo.FormattingEnabled = true;
            this.PaymentTypeCmbo.Items.AddRange(new object[] {
            "CASH",
            "DEBIT CARD",
            "CREDIT CARD"});
            this.PaymentTypeCmbo.Location = new System.Drawing.Point(9, 130);
            this.PaymentTypeCmbo.Name = "PaymentTypeCmbo";
            this.PaymentTypeCmbo.Size = new System.Drawing.Size(234, 23);
            this.PaymentTypeCmbo.TabIndex = 10;
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.Coral;
            this.PayBtn.FlatAppearance.BorderSize = 2;
            this.PayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBtn.Location = new System.Drawing.Point(9, 332);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(234, 69);
            this.PayBtn.TabIndex = 9;
            this.PayBtn.Text = "&Pay";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // ChqOutBtn
            // 
            this.ChqOutBtn.BackColor = System.Drawing.Color.Coral;
            this.ChqOutBtn.FlatAppearance.BorderSize = 2;
            this.ChqOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChqOutBtn.Location = new System.Drawing.Point(9, 257);
            this.ChqOutBtn.Name = "ChqOutBtn";
            this.ChqOutBtn.Size = new System.Drawing.Size(234, 69);
            this.ChqOutBtn.TabIndex = 9;
            this.ChqOutBtn.Text = "&CHECKOUT";
            this.ChqOutBtn.UseVisualStyleBackColor = false;
            this.ChqOutBtn.Click += new System.EventHandler(this.ChqOutBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Change";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Amount Given";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Payment Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Discount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Gross Total";
            // 
            // ChangeTxt
            // 
            this.ChangeTxt.Location = new System.Drawing.Point(9, 213);
            this.ChangeTxt.Name = "ChangeTxt";
            this.ChangeTxt.Size = new System.Drawing.Size(238, 23);
            this.ChangeTxt.TabIndex = 7;
            this.ChangeTxt.Text = "0";
            // 
            // GivenAmtTxt
            // 
            this.GivenAmtTxt.Location = new System.Drawing.Point(9, 171);
            this.GivenAmtTxt.Name = "GivenAmtTxt";
            this.GivenAmtTxt.Size = new System.Drawing.Size(238, 23);
            this.GivenAmtTxt.TabIndex = 7;
            this.GivenAmtTxt.Text = "0";
            this.GivenAmtTxt.TextChanged += new System.EventHandler(this.GivenAmtTxt_TextChanged);
            // 
            // TotDisTxt
            // 
            this.TotDisTxt.Enabled = false;
            this.TotDisTxt.Location = new System.Drawing.Point(6, 80);
            this.TotDisTxt.Name = "TotDisTxt";
            this.TotDisTxt.Size = new System.Drawing.Size(238, 23);
            this.TotDisTxt.TabIndex = 7;
            this.TotDisTxt.TextChanged += new System.EventHandler(this.BarCodeTxt_TextChanged);
            // 
            // GrossTotalTxt
            // 
            this.GrossTotalTxt.Enabled = false;
            this.GrossTotalTxt.Location = new System.Drawing.Point(6, 36);
            this.GrossTotalTxt.Name = "GrossTotalTxt";
            this.GrossTotalTxt.Size = new System.Drawing.Size(238, 23);
            this.GrossTotalTxt.TabIndex = 7;
            this.GrossTotalTxt.TextChanged += new System.EventHandler(this.BarCodeTxt_TextChanged);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 745);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.Rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox BarCodeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProductErrorLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label GrossTotLable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TestLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmtGV;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteDV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ChangeTxt;
        private System.Windows.Forms.TextBox GivenAmtTxt;
        private System.Windows.Forms.TextBox TotDisTxt;
        private System.Windows.Forms.TextBox GrossTotalTxt;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.Button ChqOutBtn;
        private System.Windows.Forms.ComboBox PaymentTypeCmbo;
    }
}