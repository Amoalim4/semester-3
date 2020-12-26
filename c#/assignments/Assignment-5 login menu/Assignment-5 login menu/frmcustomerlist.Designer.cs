namespace Assignment_5_login_menu
{
    partial class frmcustomerlist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxnames = new System.Windows.Forms.ListBox();
            this.lbxgender = new System.Windows.Forms.ListBox();
            this.lbxaddress = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // lbxnames
            // 
            this.lbxnames.FormattingEnabled = true;
            this.lbxnames.Location = new System.Drawing.Point(42, 291);
            this.lbxnames.Name = "lbxnames";
            this.lbxnames.Size = new System.Drawing.Size(283, 134);
            this.lbxnames.TabIndex = 5;
            // 
            // lbxgender
            // 
            this.lbxgender.FormattingEnabled = true;
            this.lbxgender.Location = new System.Drawing.Point(325, 291);
            this.lbxgender.Name = "lbxgender";
            this.lbxgender.Size = new System.Drawing.Size(102, 134);
            this.lbxgender.TabIndex = 6;
            // 
            // lbxaddress
            // 
            this.lbxaddress.FormattingEnabled = true;
            this.lbxaddress.Location = new System.Drawing.Point(427, 291);
            this.lbxaddress.Name = "lbxaddress";
            this.lbxaddress.Size = new System.Drawing.Size(187, 134);
            this.lbxaddress.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer list";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(121, 208);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "label3";
            // 
            // frmcustomerlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 495);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxaddress);
            this.Controls.Add(this.lbxgender);
            this.Controls.Add(this.lbxnames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmcustomerlist";
            this.Text = "frmcustomerlist";
            this.Load += new System.EventHandler(this.frmcustomerlist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxnames;
        private System.Windows.Forms.ListBox lbxgender;
        private System.Windows.Forms.ListBox lbxaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblname;
    }
}