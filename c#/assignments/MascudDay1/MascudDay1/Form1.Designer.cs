namespace MascudDay1
{
    partial class Form1
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
            this.lblname = new System.Windows.Forms.Label();
            this.lbltell = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttell = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblshowtell = new System.Windows.Forms.Label();
            this.lblshowname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(61, 83);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(33, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "name";
            // 
            // lbltell
            // 
            this.lbltell.AutoSize = true;
            this.lbltell.Location = new System.Drawing.Point(51, 179);
            this.lbltell.Name = "lbltell";
            this.lbltell.Size = new System.Drawing.Size(24, 13);
            this.lbltell.TabIndex = 1;
            this.lbltell.Text = "Tell";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(132, 83);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(167, 25);
            this.txtname.TabIndex = 2;
            // 
            // txttell
            // 
            this.txttell.Location = new System.Drawing.Point(132, 176);
            this.txttell.Name = "txttell";
            this.txttell.Size = new System.Drawing.Size(167, 20);
            this.txttell.TabIndex = 3;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(187, 288);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblshowtell
            // 
            this.lblshowtell.AutoSize = true;
            this.lblshowtell.Location = new System.Drawing.Point(391, 183);
            this.lblshowtell.Name = "lblshowtell";
            this.lblshowtell.Size = new System.Drawing.Size(24, 13);
            this.lblshowtell.TabIndex = 6;
            this.lblshowtell.Text = "Tell";
            this.lblshowtell.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblshowname
            // 
            this.lblshowname.AutoSize = true;
            this.lblshowname.Location = new System.Drawing.Point(391, 86);
            this.lblshowname.Name = "lblshowname";
            this.lblshowname.Size = new System.Drawing.Size(33, 13);
            this.lblshowname.TabIndex = 5;
            this.lblshowname.Text = "name";
            this.lblshowname.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 417);
            this.Controls.Add(this.lblshowtell);
            this.Controls.Add(this.lblshowname);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txttell);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbltell);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltell;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttell;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblshowtell;
        private System.Windows.Forms.Label lblshowname;
    }
}

