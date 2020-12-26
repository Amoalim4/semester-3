namespace ConvertionBinaryDecimal
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
            this.radioBinary = new System.Windows.Forms.RadioButton();
            this.radioDecimal = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblnote = new System.Windows.Forms.Label();
            this.btnconvert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblshow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBinary
            // 
            this.radioBinary.AutoSize = true;
            this.radioBinary.BackColor = System.Drawing.Color.Transparent;
            this.radioBinary.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBinary.Location = new System.Drawing.Point(3, 3);
            this.radioBinary.Name = "radioBinary";
            this.radioBinary.Size = new System.Drawing.Size(102, 93);
            this.radioBinary.TabIndex = 0;
            this.radioBinary.TabStop = true;
            this.radioBinary.Text = "Binary";
            this.radioBinary.UseVisualStyleBackColor = false;
            this.radioBinary.CheckedChanged += new System.EventHandler(this.radioBinary_CheckedChanged);
            // 
            // radioDecimal
            // 
            this.radioDecimal.AutoSize = true;
            this.radioDecimal.BackColor = System.Drawing.Color.Transparent;
            this.radioDecimal.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDecimal.Location = new System.Drawing.Point(109, 4);
            this.radioDecimal.Name = "radioDecimal";
            this.radioDecimal.Size = new System.Drawing.Size(109, 93);
            this.radioDecimal.TabIndex = 1;
            this.radioDecimal.TabStop = true;
            this.radioDecimal.Text = "decimal";
            this.radioDecimal.UseVisualStyleBackColor = false;
            this.radioDecimal.CheckedChanged += new System.EventHandler(this.radioDecimal_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioBinary);
            this.panel1.Controls.Add(this.radioDecimal);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(78, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 86);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TO :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lblnote);
            this.groupBox1.Controls.Add(this.btnconvert);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtinput);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(183, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 468);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "converter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblnote.Location = new System.Drawing.Point(125, 136);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(31, 15);
            this.lblnote.TabIndex = 8;
            this.lblnote.Text = "note";
            this.lblnote.Visible = false;
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(130, 378);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(94, 36);
            this.btnconvert.TabIndex = 7;
            this.btnconvert.Text = "convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblshow);
            this.panel2.Location = new System.Drawing.Point(96, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 36);
            this.panel2.TabIndex = 6;
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.BackColor = System.Drawing.Color.Transparent;
            this.lblshow.Location = new System.Drawing.Point(62, 9);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(53, 19);
            this.lblshow.TabIndex = 7;
            this.lblshow.Text = "Result :";
            this.lblshow.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(101, 192);
            this.txtinput.Multiline = true;
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(182, 28);
            this.txtinput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 549);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBinary;
        private System.Windows.Forms.RadioButton radioDecimal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Label lblnote;
    }
}

