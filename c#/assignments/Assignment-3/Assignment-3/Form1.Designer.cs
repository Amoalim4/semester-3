namespace Assignment_3
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
            this.cmbstate_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcapital = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pichead = new System.Windows.Forms.PictureBox();
            this.picflag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pichead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picflag)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbstate_list
            // 
            this.cmbstate_list.FormattingEnabled = true;
            this.cmbstate_list.Items.AddRange(new object[] {
            "(none)",
            "Somali-land",
            "Goonfur-galbeed",
            "Hirshabeele",
            "Banaadir",
            "Galmudug",
            "Puntland",
            "Jubaland"});
            this.cmbstate_list.Location = new System.Drawing.Point(103, 113);
            this.cmbstate_list.Name = "cmbstate_list";
            this.cmbstate_list.Size = new System.Drawing.Size(289, 21);
            this.cmbstate_list.TabIndex = 0;
            this.cmbstate_list.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Somali states";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(178, 279);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(65, 24);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "State Capital :";
            // 
            // lblcapital
            // 
            this.lblcapital.AutoSize = true;
            this.lblcapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapital.Location = new System.Drawing.Point(176, 358);
            this.lblcapital.Name = "lblcapital";
            this.lblcapital.Size = new System.Drawing.Size(41, 24);
            this.lblcapital.TabIndex = 11;
            this.lblcapital.Text = "city";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Head of state";
            // 
            // pichead
            // 
            this.pichead.Image = global::Assignment_3.Properties.Resources.image;
            this.pichead.Location = new System.Drawing.Point(192, 159);
            this.pichead.Name = "pichead";
            this.pichead.Size = new System.Drawing.Size(125, 97);
            this.pichead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichead.TabIndex = 14;
            this.pichead.TabStop = false;
            // 
            // picflag
            // 
            this.picflag.Image = global::Assignment_3.Properties.Resources.image;
            this.picflag.Location = new System.Drawing.Point(398, 104);
            this.picflag.Name = "picflag";
            this.picflag.Size = new System.Drawing.Size(159, 152);
            this.picflag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picflag.TabIndex = 23;
            this.picflag.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 413);
            this.Controls.Add(this.picflag);
            this.Controls.Add(this.pichead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcapital);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbstate_list);
            this.Name = "Form1";
            this.Text = "Assignment-3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pichead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picflag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbstate_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcapital;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pichead;
        private System.Windows.Forms.PictureBox picflag;
    }
}

