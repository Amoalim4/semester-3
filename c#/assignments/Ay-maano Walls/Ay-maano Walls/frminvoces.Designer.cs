namespace Ay_maano_Walls
{
    partial class frminvoces
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprevious = new System.Windows.Forms.TextBox();
            this.txtnewm3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxmembership = new System.Windows.Forms.ComboBox();
            this.lblinvoce = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblinvoce);
            this.groupBox1.Controls.Add(this.cbxmembership);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnewm3);
            this.groupBox1.Controls.Add(this.txtprevious);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.btncalculate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoce ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "new Invoce :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "previous M3 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "new M3 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "name :";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(129, 330);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(104, 34);
            this.btncalculate.TabIndex = 16;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(175, 57);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(195, 29);
            this.txtname.TabIndex = 17;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtprevious
            // 
            this.txtprevious.Location = new System.Drawing.Point(175, 152);
            this.txtprevious.Name = "txtprevious";
            this.txtprevious.Size = new System.Drawing.Size(195, 29);
            this.txtprevious.TabIndex = 18;
            // 
            // txtnewm3
            // 
            this.txtnewm3.Location = new System.Drawing.Point(175, 201);
            this.txtnewm3.Name = "txtnewm3";
            this.txtnewm3.Size = new System.Drawing.Size(195, 29);
            this.txtnewm3.TabIndex = 19;
            this.txtnewm3.TextChanged += new System.EventHandler(this.txtnewm3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Member ship :";
            // 
            // cbxmembership
            // 
            this.cbxmembership.FormattingEnabled = true;
            this.cbxmembership.Items.AddRange(new object[] {
            "Gold -- 0.85 $",
            "premium -- 0.95 $",
            "normal -- 1.05  $"});
            this.cbxmembership.Location = new System.Drawing.Point(175, 107);
            this.cbxmembership.Name = "cbxmembership";
            this.cbxmembership.Size = new System.Drawing.Size(195, 32);
            this.cbxmembership.TabIndex = 22;
            // 
            // lblinvoce
            // 
            this.lblinvoce.AutoSize = true;
            this.lblinvoce.Location = new System.Drawing.Point(204, 265);
            this.lblinvoce.Name = "lblinvoce";
            this.lblinvoce.Size = new System.Drawing.Size(79, 24);
            this.lblinvoce.TabIndex = 23;
            this.lblinvoce.Text = "amount";
            // 
            // frminvoces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 481);
            this.Controls.Add(this.groupBox1);
            this.Name = "frminvoces";
            this.Text = "frminvoces";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtnewm3;
        private System.Windows.Forms.TextBox txtprevious;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxmembership;
        private System.Windows.Forms.Label lblinvoce;

    }
}