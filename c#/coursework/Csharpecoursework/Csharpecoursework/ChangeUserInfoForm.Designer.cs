namespace Csharpecoursework
{
    partial class ChangeUserInfoForm
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
            this.btnback = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconform = new System.Windows.Forms.TextBox();
            this.txtnewpasswd = new System.Windows.Forms.TextBox();
            this.txtnewuser = new System.Windows.Forms.TextBox();
            this.txtoldpasswd = new System.Windows.Forms.TextBox();
            this.txtolduser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Controls.Add(this.btnchange);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtconform);
            this.groupBox1.Controls.Add(this.txtnewpasswd);
            this.groupBox1.Controls.Add(this.txtnewuser);
            this.groupBox1.Controls.Add(this.txtoldpasswd);
            this.groupBox1.Controls.Add(this.txtolduser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(65, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change User\'s Info";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(98, 408);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(91, 34);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Go back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(320, 402);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(119, 46);
            this.btnchange.TabIndex = 5;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Conform  Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "new Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Old Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Old user name";
            // 
            // txtconform
            // 
            this.txtconform.Location = new System.Drawing.Point(188, 328);
            this.txtconform.Multiline = true;
            this.txtconform.Name = "txtconform";
            this.txtconform.Size = new System.Drawing.Size(280, 34);
            this.txtconform.TabIndex = 3;
            // 
            // txtnewpasswd
            // 
            this.txtnewpasswd.Location = new System.Drawing.Point(188, 273);
            this.txtnewpasswd.Multiline = true;
            this.txtnewpasswd.Name = "txtnewpasswd";
            this.txtnewpasswd.Size = new System.Drawing.Size(280, 34);
            this.txtnewpasswd.TabIndex = 3;
            // 
            // txtnewuser
            // 
            this.txtnewuser.Location = new System.Drawing.Point(188, 209);
            this.txtnewuser.Multiline = true;
            this.txtnewuser.Name = "txtnewuser";
            this.txtnewuser.Size = new System.Drawing.Size(280, 36);
            this.txtnewuser.TabIndex = 2;
            // 
            // txtoldpasswd
            // 
            this.txtoldpasswd.Location = new System.Drawing.Point(188, 134);
            this.txtoldpasswd.Multiline = true;
            this.txtoldpasswd.Name = "txtoldpasswd";
            this.txtoldpasswd.Size = new System.Drawing.Size(280, 34);
            this.txtoldpasswd.TabIndex = 1;
            // 
            // txtolduser
            // 
            this.txtolduser.Location = new System.Drawing.Point(188, 68);
            this.txtolduser.Multiline = true;
            this.txtolduser.Name = "txtolduser";
            this.txtolduser.Size = new System.Drawing.Size(280, 34);
            this.txtolduser.TabIndex = 0;
            // 
            // ChangeUserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharpecoursework.Properties.Resources.c3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 493);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChangeUserInfoForm";
            this.Text = "ChangeUserInfoForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconform;
        private System.Windows.Forms.TextBox txtnewpasswd;
        private System.Windows.Forms.TextBox txtnewuser;
        private System.Windows.Forms.TextBox txtoldpasswd;
        private System.Windows.Forms.TextBox txtolduser;
        private System.Windows.Forms.Button btnback;
    }
}