namespace InventoryManagmentSystem
{
    partial class ProductPricing
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
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitMarginGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalSalePriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.Rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTxt
            // 
            this.SearchTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchTxt.Size = new System.Drawing.Size(207, 23);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.CategoryCombo);
            this.LeftPanel.Controls.Add(this.label8);
            this.LeftPanel.Size = new System.Drawing.Size(250, 763);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label8, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CategoryCombo, 0);
            // 
            // Rightpanel
            // 
            this.Rightpanel.Controls.Add(this.dataGridView1);
            this.Rightpanel.Size = new System.Drawing.Size(1294, 763);
            this.Rightpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(7, 174);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(237, 23);
            this.CategoryCombo.TabIndex = 6;
            this.CategoryCombo.SelectedIndexChanged += new System.EventHandler(this.CategoryCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Category";
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
            this.SelectItem,
            this.IdDGV,
            this.NameGV,
            this.PurPriceGV,
            this.ProfitMarginGV,
            this.DiscountGV,
            this.FinalSalePriceGV});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1294, 658);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // SelectItem
            // 
            this.SelectItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SelectItem.FalseValue = "0";
            this.SelectItem.HeaderText = "";
            this.SelectItem.Name = "SelectItem";
            this.SelectItem.TrueValue = "1";
            this.SelectItem.Width = 5;
            // 
            // IdDGV
            // 
            this.IdDGV.HeaderText = "Product Id";
            this.IdDGV.Name = "IdDGV";
            this.IdDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Product";
            this.NameGV.Name = "NameGV";
            // 
            // PurPriceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.PurPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.PurPriceGV.HeaderText = "Purchase Price";
            this.PurPriceGV.Name = "PurPriceGV";
            // 
            // ProfitMarginGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            this.ProfitMarginGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProfitMarginGV.HeaderText = "Profit Margin %";
            this.ProfitMarginGV.Name = "ProfitMarginGV";
            // 
            // DiscountGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            this.DiscountGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.DiscountGV.HeaderText = "Discount %";
            this.DiscountGV.Name = "DiscountGV";
            // 
            // FinalSalePriceGV
            // 
            dataGridViewCellStyle5.Format = "N2";
            this.FinalSalePriceGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.FinalSalePriceGV.HeaderText = "Final Selling Price";
            this.FinalSalePriceGV.Name = "FinalSalePriceGV";
            // 
            // ProductPricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 763);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "ProductPricing";
            this.Text = "Product Pricing";
            this.Load += new System.EventHandler(this.ProductPricing_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.Rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitMarginGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalSalePriceGV;
    }
}