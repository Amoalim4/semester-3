namespace math_window_form
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
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtfirstnumber = new System.Windows.Forms.TextBox();
            this.txtsecondnumber = new System.Windows.Forms.TextBox();
            this.rbtnadd = new System.Windows.Forms.RadioButton();
            this.rbtndivide = new System.Windows.Forms.RadioButton();
            this.rbtnmult = new System.Windows.Forms.RadioButton();
            this.rbtnsub = new System.Windows.Forms.RadioButton();
            this.lblresult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(234, 310);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(104, 45);
            this.btncalculate.TabIndex = 5;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtfirstnumber
            // 
            this.txtfirstnumber.Location = new System.Drawing.Point(234, 92);
            this.txtfirstnumber.Name = "txtfirstnumber";
            this.txtfirstnumber.Size = new System.Drawing.Size(159, 20);
            this.txtfirstnumber.TabIndex = 6;
            this.txtfirstnumber.TextChanged += new System.EventHandler(this.txtfirstnumber_TextChanged);
            // 
            // txtsecondnumber
            // 
            this.txtsecondnumber.Location = new System.Drawing.Point(234, 169);
            this.txtsecondnumber.Name = "txtsecondnumber";
            this.txtsecondnumber.Size = new System.Drawing.Size(159, 20);
            this.txtsecondnumber.TabIndex = 7;
            // 
            // rbtnadd
            // 
            this.rbtnadd.AutoSize = true;
            this.rbtnadd.Location = new System.Drawing.Point(465, 75);
            this.rbtnadd.Name = "rbtnadd";
            this.rbtnadd.Size = new System.Drawing.Size(44, 17);
            this.rbtnadd.TabIndex = 8;
            this.rbtnadd.TabStop = true;
            this.rbtnadd.Text = "Add";
            this.rbtnadd.UseVisualStyleBackColor = true;
            // 
            // rbtndivide
            // 
            this.rbtndivide.AutoSize = true;
            this.rbtndivide.Location = new System.Drawing.Point(465, 197);
            this.rbtndivide.Name = "rbtndivide";
            this.rbtndivide.Size = new System.Drawing.Size(53, 17);
            this.rbtndivide.TabIndex = 9;
            this.rbtndivide.TabStop = true;
            this.rbtndivide.Text = "divide";
            this.rbtndivide.UseVisualStyleBackColor = true;
            // 
            // rbtnmult
            // 
            this.rbtnmult.AutoSize = true;
            this.rbtnmult.Location = new System.Drawing.Point(465, 156);
            this.rbtnmult.Name = "rbtnmult";
            this.rbtnmult.Size = new System.Drawing.Size(44, 17);
            this.rbtnmult.TabIndex = 10;
            this.rbtnmult.TabStop = true;
            this.rbtnmult.Text = "mult";
            this.rbtnmult.UseVisualStyleBackColor = true;
            // 
            // rbtnsub
            // 
            this.rbtnsub.AutoSize = true;
            this.rbtnsub.Location = new System.Drawing.Point(465, 115);
            this.rbtnsub.Name = "rbtnsub";
            this.rbtnsub.Size = new System.Drawing.Size(42, 17);
            this.rbtnsub.TabIndex = 11;
            this.rbtnsub.TabStop = true;
            this.rbtnsub.Text = "sub";
            this.rbtnsub.UseVisualStyleBackColor = true;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(241, 224);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(61, 15);
            this.lblresult.TabIndex = 12;
            this.lblresult.Text = "result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Second number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Frist number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "CASIO 3.7.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 422);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.rbtnsub);
            this.Controls.Add(this.rbtnmult);
            this.Controls.Add(this.rbtndivide);
            this.Controls.Add(this.rbtnadd);
            this.Controls.Add(this.txtsecondnumber);
            this.Controls.Add(this.txtfirstnumber);
            this.Controls.Add(this.btncalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtfirstnumber;
        private System.Windows.Forms.TextBox txtsecondnumber;
        private System.Windows.Forms.RadioButton rbtnadd;
        private System.Windows.Forms.RadioButton rbtndivide;
        private System.Windows.Forms.RadioButton rbtnmult;
        private System.Windows.Forms.RadioButton rbtnsub;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

