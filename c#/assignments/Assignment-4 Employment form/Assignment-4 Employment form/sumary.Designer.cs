namespace Assignment_4_Employment_form
{
    partial class sumary
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
            this.btngobackf3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngobackf3
            // 
            this.btngobackf3.Location = new System.Drawing.Point(212, 432);
            this.btngobackf3.Name = "btngobackf3";
            this.btngobackf3.Size = new System.Drawing.Size(158, 44);
            this.btngobackf3.TabIndex = 0;
            this.btngobackf3.Text = "Go back";
            this.btngobackf3.UseVisualStyleBackColor = true;
            this.btngobackf3.Click += new System.EventHandler(this.btngobackf3_Click);
            // 
            // sumary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 500);
            this.Controls.Add(this.btngobackf3);
            this.Name = "sumary";
            this.Text = "sumary";
            this.Load += new System.EventHandler(this.sumary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngobackf3;
    }
}