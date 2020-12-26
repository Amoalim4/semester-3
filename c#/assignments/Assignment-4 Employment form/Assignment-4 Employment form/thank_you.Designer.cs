namespace Assignment_4_Employment_form
{
    partial class thank_you
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
            this.btngoback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblshowname = new System.Windows.Forms.Label();
            this.lblshowaddress = new System.Windows.Forms.Label();
            this.lblshowtell = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngoback
            // 
            this.btngoback.Location = new System.Drawing.Point(143, 391);
            this.btngoback.Name = "btngoback";
            this.btngoback.Size = new System.Drawing.Size(115, 40);
            this.btngoback.TabIndex = 0;
            this.btngoback.Text = "Go back";
            this.btngoback.UseVisualStyleBackColor = true;
            this.btngoback.Click += new System.EventHandler(this.btngoback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registration saved";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thank you";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblshowname
            // 
            this.lblshowname.AutoSize = true;
            this.lblshowname.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowname.Location = new System.Drawing.Point(259, 138);
            this.lblshowname.Name = "lblshowname";
            this.lblshowname.Size = new System.Drawing.Size(123, 45);
            this.lblshowname.TabIndex = 4;
            this.lblshowname.Text = "name";
            // 
            // lblshowaddress
            // 
            this.lblshowaddress.AutoSize = true;
            this.lblshowaddress.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowaddress.Location = new System.Drawing.Point(215, 276);
            this.lblshowaddress.Name = "lblshowaddress";
            this.lblshowaddress.Size = new System.Drawing.Size(167, 45);
            this.lblshowaddress.TabIndex = 5;
            this.lblshowaddress.Text = "Address";
            this.lblshowaddress.Click += new System.EventHandler(this.lblshowaddress_Click);
            // 
            // lblshowtell
            // 
            this.lblshowtell.AutoSize = true;
            this.lblshowtell.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowtell.Location = new System.Drawing.Point(268, 215);
            this.lblshowtell.Name = "lblshowtell";
            this.lblshowtell.Size = new System.Drawing.Size(79, 45);
            this.lblshowtell.TabIndex = 6;
            this.lblshowtell.Text = "tell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "tell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 45);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // thank_you
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblshowtell);
            this.Controls.Add(this.lblshowaddress);
            this.Controls.Add(this.lblshowname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngoback);
            this.Name = "thank_you";
            this.Text = "thank_you";
            this.Load += new System.EventHandler(this.thank_you_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngoback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblshowname;
        private System.Windows.Forms.Label lblshowaddress;
        private System.Windows.Forms.Label lblshowtell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}