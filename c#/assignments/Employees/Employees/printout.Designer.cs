namespace Employees
{
    partial class printout
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
            this.lbladdress = new System.Windows.Forms.Label();
            this.lbldamiin = new System.Windows.Forms.Label();
            this.lbltell = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(178, 299);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(45, 13);
            this.lbladdress.TabIndex = 13;
            this.lbladdress.Text = "Address";
            // 
            // lbldamiin
            // 
            this.lbldamiin.AutoSize = true;
            this.lbldamiin.Location = new System.Drawing.Point(188, 344);
            this.lbldamiin.Name = "lbldamiin";
            this.lbldamiin.Size = new System.Drawing.Size(39, 13);
            this.lbldamiin.TabIndex = 12;
            this.lbldamiin.Text = "Damiin";
            // 
            // lbltell
            // 
            this.lbltell.AutoSize = true;
            this.lbltell.Location = new System.Drawing.Point(199, 262);
            this.lbltell.Name = "lbltell";
            this.lbltell.Size = new System.Drawing.Size(24, 13);
            this.lbltell.TabIndex = 11;
            this.lbltell.Text = "Tell";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(198, 221);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(25, 13);
            this.lblage.TabIndex = 10;
            this.lblage.Text = "age";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(188, 165);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(40, 13);
            this.lblgender.TabIndex = 9;
            this.lblgender.Text = "gender";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(188, 123);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Name";
            // 
            // printout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 510);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lbldamiin);
            this.Controls.Add(this.lbltell);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Name = "printout";
            this.Text = "printout";
            this.Load += new System.EventHandler(this.printout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lbldamiin;
        private System.Windows.Forms.Label lbltell;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblname;
    }
}