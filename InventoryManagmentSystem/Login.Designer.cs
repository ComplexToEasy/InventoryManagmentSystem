namespace InventoryManagmentSystem
{
    partial class Login
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
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.LbleUserName = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nameerrorLbl = new System.Windows.Forms.Label();
            this.PassErrorlabel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.button1);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.LbleUserName);
            this.LeftPanel.Controls.Add(this.PasswordTxt);
            this.LeftPanel.Controls.Add(this.UserNameTxt);
            this.LeftPanel.Controls.Add(this.PassErrorlabel);
            this.LeftPanel.Controls.Add(this.nameerrorLbl);
            this.LeftPanel.Size = new System.Drawing.Size(250, 705);
            this.LeftPanel.Controls.SetChildIndex(this.nameerrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PassErrorlabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.LeftPanel.Controls.SetChildIndex(this.UserNameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PasswordTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.LbleUserName, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.button1, 0);
            // 
            // Rightpanel
            // 
            this.Rightpanel.Size = new System.Drawing.Size(550, 705);
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UserNameTxt.Location = new System.Drawing.Point(12, 282);
            this.UserNameTxt.MaxLength = 30;
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(216, 29);
            this.UserNameTxt.TabIndex = 1;
            this.UserNameTxt.TextChanged += new System.EventHandler(this.UserNameTxt_TextChanged);
            // 
            // LbleUserName
            // 
            this.LbleUserName.AutoSize = true;
            this.LbleUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LbleUserName.Location = new System.Drawing.Point(12, 258);
            this.LbleUserName.Name = "LbleUserName";
            this.LbleUserName.Size = new System.Drawing.Size(88, 21);
            this.LbleUserName.TabIndex = 2;
            this.LbleUserName.Text = "User Name";
            this.LbleUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PasswordTxt.Location = new System.Drawing.Point(12, 343);
            this.PasswordTxt.MaxLength = 30;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(216, 29);
            this.PasswordTxt.TabIndex = 2;
            this.PasswordTxt.UseSystemPasswordChar = true;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(12, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameerrorLbl
            // 
            this.nameerrorLbl.AutoSize = true;
            this.nameerrorLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameerrorLbl.ForeColor = System.Drawing.Color.Orange;
            this.nameerrorLbl.Location = new System.Drawing.Point(106, 258);
            this.nameerrorLbl.Name = "nameerrorLbl";
            this.nameerrorLbl.Size = new System.Drawing.Size(20, 25);
            this.nameerrorLbl.TabIndex = 5;
            this.nameerrorLbl.Text = "*";
            this.nameerrorLbl.Visible = false;
            // 
            // PassErrorlabel
            // 
            this.PassErrorlabel.AutoSize = true;
            this.PassErrorlabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PassErrorlabel.ForeColor = System.Drawing.Color.Orange;
            this.PassErrorlabel.Location = new System.Drawing.Point(106, 315);
            this.PassErrorlabel.Name = "PassErrorlabel";
            this.PassErrorlabel.Size = new System.Drawing.Size(20, 25);
            this.PassErrorlabel.TabIndex = 5;
            this.PassErrorlabel.Text = "*";
            this.PassErrorlabel.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 705);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbleUserName;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PassErrorlabel;
        private System.Windows.Forms.Label nameerrorLbl;
    }
}