namespace InventoryManagmentSystem
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameerrorLbl = new System.Windows.Forms.Label();
            this.BarcodeErrorLbl = new System.Windows.Forms.Label();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExpDateDate = new System.Windows.Forms.DateTimePicker();
            this.ExpiryErrorLable = new System.Windows.Forms.Label();
            this.CategoryErrorLable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.Rightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTxt
            // 
            this.SearchTxt.Size = new System.Drawing.Size(83, 23);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.CategoryCombo);
            this.LeftPanel.Controls.Add(this.ExpDateDate);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.label8);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.BarcodeTxt);
            this.LeftPanel.Controls.Add(this.CategoryErrorLable);
            this.LeftPanel.Controls.Add(this.NameTxt);
            this.LeftPanel.Controls.Add(this.ExpiryErrorLable);
            this.LeftPanel.Controls.Add(this.BarcodeErrorLbl);
            this.LeftPanel.Controls.Add(this.nameerrorLbl);
            this.LeftPanel.Size = new System.Drawing.Size(250, 775);
            this.LeftPanel.Controls.SetChildIndex(this.nameerrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ExpiryErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.NameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CategoryErrorLable, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label8, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ExpDateDate, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CategoryCombo, 0);
            // 
            // Rightpanel
            // 
            this.Rightpanel.Controls.Add(this.dataGridView1);
            this.Rightpanel.Size = new System.Drawing.Size(550, 775);
            this.Rightpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(7, 173);
            this.NameTxt.MaxLength = 50;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(237, 23);
            this.NameTxt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // nameerrorLbl
            // 
            this.nameerrorLbl.AutoSize = true;
            this.nameerrorLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameerrorLbl.ForeColor = System.Drawing.Color.Orange;
            this.nameerrorLbl.Location = new System.Drawing.Point(97, 151);
            this.nameerrorLbl.Name = "nameerrorLbl";
            this.nameerrorLbl.Size = new System.Drawing.Size(20, 25);
            this.nameerrorLbl.TabIndex = 4;
            this.nameerrorLbl.Text = "*";
            this.nameerrorLbl.Visible = false;
            // 
            // BarcodeErrorLbl
            // 
            this.BarcodeErrorLbl.AutoSize = true;
            this.BarcodeErrorLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BarcodeErrorLbl.ForeColor = System.Drawing.Color.Orange;
            this.BarcodeErrorLbl.Location = new System.Drawing.Point(97, 197);
            this.BarcodeErrorLbl.Name = "BarcodeErrorLbl";
            this.BarcodeErrorLbl.Size = new System.Drawing.Size(20, 25);
            this.BarcodeErrorLbl.TabIndex = 4;
            this.BarcodeErrorLbl.Text = "*";
            this.BarcodeErrorLbl.Visible = false;
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Location = new System.Drawing.Point(7, 219);
            this.BarcodeTxt.MaxLength = 50;
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(237, 23);
            this.BarcodeTxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Expiry Date";
            // 
            // ExpDateDate
            // 
            this.ExpDateDate.CustomFormat = "dd-MM-yyyy";
            this.ExpDateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpDateDate.Location = new System.Drawing.Point(7, 264);
            this.ExpDateDate.Name = "ExpDateDate";
            this.ExpDateDate.Size = new System.Drawing.Size(234, 23);
            this.ExpDateDate.TabIndex = 2;
            this.ExpDateDate.Value = new System.DateTime(2023, 7, 10, 0, 0, 0, 0);
            // 
            // ExpiryErrorLable
            // 
            this.ExpiryErrorLable.AutoSize = true;
            this.ExpiryErrorLable.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ExpiryErrorLable.ForeColor = System.Drawing.Color.Orange;
            this.ExpiryErrorLable.Location = new System.Drawing.Point(97, 245);
            this.ExpiryErrorLable.Name = "ExpiryErrorLable";
            this.ExpiryErrorLable.Size = new System.Drawing.Size(20, 25);
            this.ExpiryErrorLable.TabIndex = 4;
            this.ExpiryErrorLable.Text = "*";
            this.ExpiryErrorLable.Visible = false;
            // 
            // CategoryErrorLable
            // 
            this.CategoryErrorLable.AutoSize = true;
            this.CategoryErrorLable.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CategoryErrorLable.ForeColor = System.Drawing.Color.Orange;
            this.CategoryErrorLable.Location = new System.Drawing.Point(96, 289);
            this.CategoryErrorLable.Name = "CategoryErrorLable";
            this.CategoryErrorLable.Size = new System.Drawing.Size(20, 25);
            this.CategoryErrorLable.TabIndex = 4;
            this.CategoryErrorLable.Text = "*";
            this.CategoryErrorLable.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Category";
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(7, 308);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(237, 23);
            this.CategoryCombo.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDGV,
            this.NameGV,
            this.BarcodeGV,
            this.ExpiryGV,
            this.CatIdGV,
            this.CatNameGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(550, 670);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IdDGV
            // 
            this.IdDGV.HeaderText = "Product Id";
            this.IdDGV.Name = "IdDGV";
            this.IdDGV.ReadOnly = true;
            this.IdDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Product";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // BarcodeGV
            // 
            this.BarcodeGV.HeaderText = "Barcode";
            this.BarcodeGV.Name = "BarcodeGV";
            this.BarcodeGV.ReadOnly = true;
            // 
            // ExpiryGV
            // 
            this.ExpiryGV.HeaderText = "Expiry";
            this.ExpiryGV.Name = "ExpiryGV";
            this.ExpiryGV.ReadOnly = true;
            // 
            // CatIdGV
            // 
            this.CatIdGV.HeaderText = "Category ID";
            this.CatIdGV.Name = "CatIdGV";
            this.CatIdGV.ReadOnly = true;
            this.CatIdGV.Visible = false;
            // 
            // CatNameGV
            // 
            this.CatNameGV.HeaderText = "Category";
            this.CatNameGV.Name = "CatNameGV";
            this.CatNameGV.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 775);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.Rightpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label nameerrorLbl;
        private System.Windows.Forms.DateTimePicker ExpDateDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.Label BarcodeErrorLbl;
        private System.Windows.Forms.Label ExpiryErrorLable;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CategoryErrorLable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatNameGV;
    }
}